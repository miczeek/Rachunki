using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Rachunki
{
    //! Klasa formularza - Edytowanie danych aktora
    public partial class EdytujDane : Form
    {
        private int user_id;
        private string edytor_rola;

        //! Konstuktor inicjalizujący komponenty
        public EdytujDane(int user_id, string edytor_rola)
        {
            InitializeComponent();
            this.user_id = user_id;
            this.edytor_rola = edytor_rola;
            DataRow user = Program.getUser(user_id);

            if (user == null)
            {
                this.Close();
                Prompt.Error("Nie znaleziono aktora o podanym ID");
                return;
            }

            textbox_id.Text = user[Program.AKTOR_ID].ToString();
            textbox_login.Text = ((string)user[Program.AKTOR_LOGIN]).Trim();
            textbox_haslo.Text = ((string)user[Program.AKTOR_HASLO]).Trim();
            combobox_rola.SelectedItem = ((string)user[Program.AKTOR_ROLA]).Trim();
            textbox_nazwa.Text = ((string)user[Program.AKTOR_NAZWA]).Trim();
            textbox_nip.Text = ((string)user[Program.AKTOR_NIP]).Trim();
            textbox_numer_telefonu.Text = ((string)user[Program.AKTOR_NUMER_TELEFONU]).Trim();

            if (edytor_rola == Program.AKTOR_ROLA_ADMIN)
            {
                textbox_login.ReadOnly = false;
                textbox_haslo.ReadOnly = false;
                combobox_rola.Enabled = true;
            }
        }

        //! Metoda wywoływana po kliknięciu przycisku "Zapisz"
        private void button_zapisz_Click(object sender, EventArgs e)
        {
            string login = textbox_login.Text.Trim();
            string haslo = textbox_haslo.Text.Trim();
            string rola = (string)combobox_rola.SelectedItem;


            string nip = textbox_nip.Text.Trim();
            string nr = textbox_numer_telefonu.Text.Trim();
            string nazwa = textbox_nazwa.Text.Trim();
            if (nazwa.Length < 10)
            {
                label_wynik.Text = "Nazwa jest zbyt krótka.";
                return;
            }
            if (nr.Length < 9)
            {
                label_wynik.Text = "Numer telefonu jest zbyt krótki.";
                return;
            }
            if (nr[0] != '+')
            {
                label_wynik.Text = "Numer telefonu powinien zaczynać się od +.";
                return;
            }
            if (!Program.ValidateNip(nip))
            {
                label_wynik.Text = "Podano niepoprawny NIP.";
                return;
            }


            SqlConnection connection = new SqlConnection(Program.sqlConnect);
            connection.Open();
            SqlCommand command = new SqlCommand(null, connection);
            command.CommandText = "UPDATE Aktor SET login=@login, haslo=@haslo, rola=@rola, nazwa=@nazwa, nip=@nip, numer_telefonu=@nr WHERE id=@id";
            command.Parameters.AddWithValue("@id", user_id);
            command.Parameters.AddWithValue("@login", login);
            command.Parameters.AddWithValue("@haslo", haslo);
            command.Parameters.AddWithValue("@rola", rola);
            command.Parameters.AddWithValue("@nazwa", nazwa);
            command.Parameters.AddWithValue("@nip", nip);
            command.Parameters.AddWithValue("@nr", nr);
            command.ExecuteNonQuery();
            label_wynik.Text = "Dane zapisano.";
        }
    }
}
