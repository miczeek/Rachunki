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
    //! Klasa formularza - Edytowanie produktu
    public partial class EdytujProdukt : Form
    {
        private DataRow produkt;

        //! Konstuktor inicjalizujący komponenty
        public EdytujProdukt(DataRow produkt)
        {
            InitializeComponent();

            this.produkt = produkt;


            textbox_id.Text = produkt[0].ToString();
            textbox_nazwa.Text = (string)produkt[1];
            textbox_cena.Value = (decimal)produkt[4];

            string id_typ = produkt[2].ToString();
            string id_producent = produkt[3].ToString();

            DataRowCollection typy = Program.getRows("SELECT * FROM ProduktTyp");
            for (int i = 0; i < typy.Count; i++)
            {
                string id = typy[i][0].ToString();
                string nazwa = (string)typy[i][1];
                combobox_typ.Items.Add(new ComboBoxItem(nazwa, id));
                if (id == id_typ)
                {
                    combobox_typ.SelectedIndex = i;
                }
            }

            DataRowCollection producenci = Program.getRows("SELECT id, nazwa FROM Aktor WHERE rola='" + Program.AKTOR_ROLA_PRODUCENT + "'");

            for (int i = 0; i < producenci.Count; i++)
            {
                string id = producenci[i][0].ToString();
                string nazwa = (string)producenci[i][1];
                combobox_producent.Items.Add(new ComboBoxItem(nazwa, id));
                if (id == id_producent)
                {
                    combobox_producent.SelectedIndex = i;
                }
            }
        }

        //! Metoda wywoływana po kliknięciu przycisku "Dodaj"
        private void button_dodaj_Click(object sender, EventArgs e)
        {
            int id = (int)produkt[0];
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
            command.CommandText = "UPDATE Produkt SET nazwa=@nazwa, id_typ=@id_typ, id_producent=@id_producent, cena=@cena WHERE id=@id";
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@nazwa", nazwa);
            command.Parameters.AddWithValue("@id_typ", id_typ);
            command.Parameters.AddWithValue("@id_producent", id_producent);
            command.Parameters.AddWithValue("@cena", cena);
            command.ExecuteNonQuery();

            this.Close();
            Prompt.Success("Produkt został edytowany.");
        }
    }
}
