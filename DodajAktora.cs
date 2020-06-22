using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Rachunki
{
    //! Klasa formularza - Dodanie nowego aktora
    public partial class DodajAktora : Form
    {
        //! Zmeinna przechowująca rolę edytującej osoby
        private string edytor_rola;

        //! Konstuktor inicjalizujący komponenty
        public DodajAktora(string nowa_rola, string edytor_rola)
        {
            InitializeComponent();
            this.edytor_rola = edytor_rola;

            combobox_rola.SelectedItem = nowa_rola;

            if (edytor_rola != Program.AKTOR_ROLA_ADMIN)
            {
                combobox_rola.Enabled = false;
            }
        }

        //! Metoda zwracająca wybraną rolę w polu typu Combo
        public string get_wybrana_rola()
        {
            return (string)combobox_rola.SelectedItem;
        }

        //! Metoda wywoływana po kliknięciu przycisku "Zapisz"
        private void button_zapisz_Click(object sender, EventArgs e)
        {
            string login = textbox_login.Text.Trim();
            string haslo = textbox_haslo.Text.Trim();
            string rola = get_wybrana_rola();
            string nip = textbox_nip.Text.Trim();
            string nr = textbox_numer_telefonu.Text.Trim();
            string nazwa = textbox_nazwa.Text.Trim();

            if (login.Length < 4)
            {
                Prompt.Error("Login jest zbyt krótki.");
                return;
            }
            if (haslo.Length < 5)
            {
                Prompt.Error("Haslo jest zbyt krótkie.");
                return;
            }
            if (nazwa.Length < 4)
            {
                Prompt.Error("Nazwa jest zbyt krótka.");
                return;
            }
            if (nr.Length > 0)
            {
                if (nr.Length < 9)
                {
                    Prompt.Error("Numer telefonu jest zbyt krótki.");
                    return;
                }
                if (nr[0] != '+')
                {
                    Prompt.Error("Numer telefonu powinien zaczynać się od +.");
                    return;
                }
            }
            if (nip.Length > 0)
            {
                if (!Program.ValidateNip(nip))
                {
                    Prompt.Error("Podano niepoprawny NIP.");
                    return;
                }
            }


            SqlConnection connection = new SqlConnection(Program.sqlConnect);
            connection.Open();
            SqlCommand command = new SqlCommand(null, connection);
            command.CommandText = "INSERT INTO Aktor (login, haslo, rola, nazwa, nip, numer_telefonu) output INSERTED.ID VALUES (@login, @haslo, @rola, @nazwa, @nip, @nr)";
            command.Parameters.AddWithValue("@login", login);
            command.Parameters.AddWithValue("@haslo", haslo);
            command.Parameters.AddWithValue("@rola", rola);
            command.Parameters.AddWithValue("@nazwa", nazwa);
            command.Parameters.AddWithValue("@nip", nip);
            command.Parameters.AddWithValue("@nr", nr);
            int id = (int)command.ExecuteScalar();

            Prompt.Success("Dodano nowego aktora o ID: " + id);
            this.Close();
        }
    }
}
