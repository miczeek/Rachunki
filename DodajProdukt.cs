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
    //! Klasa formularza - Dodanie nowego produktu
    public partial class DodajProdukt : Form
    {
        public bool error = false;

        //! Konstuktor inicjalizujący komponenty
        public DodajProdukt()
        {
            InitializeComponent();

            DataRowCollection typy = Program.getRows("SELECT * FROM ProduktTyp");
            if (typy == null)
            {
                error = true;
                Prompt.Error("Brak typów produktów.");
                return;
            }
            else
            {
                for (int i = 0; i < typy.Count; i++)
                {
                    string id = typy[i][0].ToString();
                    string nazwa = (string)typy[i][1];
                    combobox_typ.Items.Add(new ComboBoxItem(nazwa, id));
                }
            }

            DataRowCollection producenci = Program.getRows("SELECT id, nazwa FROM Aktor WHERE rola='" + Program.AKTOR_ROLA_PRODUCENT + "'");
            if (producenci == null)
            {
                error = true;
                Prompt.Error("Brak producentów.");
                return;
            } else
            {
                for (int i = 0; i < producenci.Count; i++)
                {
                    string id = producenci[i][0].ToString();
                    string nazwa = (string)producenci[i][1];
                    combobox_producent.Items.Add(new ComboBoxItem(nazwa, id));
                }
                combobox_producent.SelectedIndex = 0;
            }

        }

        //! Metoda wywoływana po kliknięciu przycisku "Dodaj"
        private void button_dodaj_Click(object sender, EventArgs e)
        {
            string nazwa = textbox_nazwa.Text.Trim();
            string id_typ = ((ComboBoxItem)combobox_typ.SelectedItem).HiddenValue;
            string id_producent = ((ComboBoxItem)combobox_producent.SelectedItem).HiddenValue;
            decimal cena = textbox_cena.Value;

            if (cena <= 0)
            {
                Prompt.Error("Błędna cena.");
                return;
            }
            if (nazwa.Length < 5)
            {
                Prompt.Error("Nazwa jest zbyt krótka.");
                return;
            }
            if (id_typ.Length == 0)
            {
                Prompt.Error("Podaj typ produktu.");
                return;
            }
            if (id_producent.Length == 0)
            {
                Prompt.Error("Podaj producenta produktu.");
                return;
            }

            SqlConnection connection = new SqlConnection(Program.sqlConnect);
            connection.Open();
            SqlCommand command = new SqlCommand(null, connection);
            command.CommandText = "INSERT INTO Produkt (nazwa, id_typ, id_producent, cena) output INSERTED.ID VALUES (@nazwa, @id_typ, @id_producent, @cena)";
            command.Parameters.AddWithValue("@nazwa", nazwa);
            command.Parameters.AddWithValue("@id_typ", id_typ);
            command.Parameters.AddWithValue("@id_producent", id_producent);
            command.Parameters.AddWithValue("@cena", cena);
            int id = (int)command.ExecuteScalar();

            this.Close();
            Prompt.Success("Produkt został dodany z ID: " + id);
        }
    }
}
