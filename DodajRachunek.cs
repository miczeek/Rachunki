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
using System.Globalization;


namespace Rachunki
{
    public partial class DodajRachunek : Form
    {
        int id_sprzedawcy;
        public DodajRachunek(int id_sprzedawcy)
        {
            InitializeComponent();
            this.id_sprzedawcy = id_sprzedawcy;
            DataRowCollection klienci = Program.getRows("SELECT * FROM Aktor WHERE rola='" + Program.AKTOR_ROLA_UZYTKOWNIK + "'");
            for (int i = 0; i < klienci.Count; i++)
            {
                string id = klienci[i][Program.AKTOR_ID].ToString();
                string nazwa = (string)klienci[i][Program.AKTOR_NAZWA];
                combobox_klient.Items.Add(new ComboBoxItem(nazwa, id));
            }
        }

        private void button_dodaj_Click(object sender, EventArgs e)
        {
            int id = Prompt.Int("Podaj ID produktu");
            DataRow produkt = Program.getRow("SELECT P.id, P.nazwa, Typ.typ, Producent.nazwa as producent, P.cena FROM Produkt P INNER JOIN ProduktTyp Typ ON Typ.id=P.id_typ INNER JOIN Aktor Producent ON Producent.id=P.id_producent WHERE P.id=" + id);
            if (produkt == null)
            {
                Prompt.Error("Nie znaleziono produktu");
                return;
            }

            int ilosc = Prompt.Int("Podaj ilosc produktu");
            if (ilosc <= 0)
            {
                Prompt.Error("Podano zla ilosc");
                return;
            }

            data_rachunek.Rows.Add(produkt[0], produkt[1], produkt[2], produkt[3], produkt[4], ilosc, (decimal)ilosc * (decimal)produkt[4]);

            Prompt.Success("Dodano produkt do rachunku");
        }

        private void button_utworz_Click(object sender, EventArgs e)
        {
            if (combobox_klient.SelectedItem == null)
            {
                Prompt.Error("Nie wybrano klienta");
                return;
            }
            string id_klienta = ((ComboBoxItem)combobox_klient.SelectedItem).HiddenValue;
            DateTime data = DateTime.Today;

            if (id_klienta.Length == 0)
            {
                Prompt.Error("Nie wybrano klienta");
                return;
            }

            if (data_rachunek.Rows.Count == 0)
            {
                Prompt.Error("Nie wybrano produktow");
                return;
            }

            SqlConnection connection = new SqlConnection(Program.sqlConnect);
            connection.Open();
            SqlCommand command = new SqlCommand(null, connection);
            command.CommandText = "INSERT INTO Rachunek (id_klienta, id_sprzedawcy, data) output INSERTED.ID VALUES (@id_klienta, @id_sprzedawcy, @data)";
            command.Parameters.AddWithValue("@id_klienta", id_klienta);
            command.Parameters.AddWithValue("@id_sprzedawcy", id_sprzedawcy);
            command.Parameters.AddWithValue("@data", data);
            int id_rachunku = (int)command.ExecuteScalar();
          
            foreach (DataGridViewRow row in data_rachunek.Rows)
            {
                string id_produktu = row.Cells[0].Value.ToString();

                NumberFormatInfo provider = new NumberFormatInfo();
                provider.NumberDecimalSeparator = ",";
                double cena = Convert.ToDouble(row.Cells[4].Value.ToString(), provider);

                string ilosc = row.Cells[5].Value.ToString();

                SqlCommand cmd = new SqlCommand(null, connection);
                cmd.CommandText = "INSERT INTO RachunekProdukt (id_rachunku, id_produktu, ilosc, cena) VALUES (@id_rachunku, @id_produktu, @ilosc, @cena)";
                cmd.Parameters.AddWithValue("@id_rachunku", id_rachunku);
                cmd.Parameters.AddWithValue("@id_produktu", id_produktu);
                cmd.Parameters.AddWithValue("@ilosc", ilosc);
                cmd.Parameters.AddWithValue("@cena", cena);
                cmd.ExecuteNonQuery();
            }

            Prompt.Success("Utworzono rachunek o ID: " + id_rachunku);
            this.Close();
        }
    }
}