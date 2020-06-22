/*! \mainpage Rachunki
 * Autor: Filip Mika \n
 * Opis projektu: Program do wystawiania rachunków wykonany w języku C# jako projekt na uczelnię
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using Rachunki.Properties;

namespace Rachunki
{
    //! Głowna klasa programu 
    public static class Program
    {
        public const int AKTOR_ID = 0;
        public const int AKTOR_LOGIN = 1;
        public const int AKTOR_HASLO = 2;
        public const int AKTOR_ROLA = 3;
        public const int AKTOR_NAZWA = 4;
        public const int AKTOR_NIP = 5;
        public const int AKTOR_NUMER_TELEFONU = 6;

        public const string AKTOR_ROLA_ADMIN = "administrator";
        public const string AKTOR_ROLA_SPRZEDAWCA = "sprzedawca";
        public const string AKTOR_ROLA_UZYTKOWNIK = "uzytkownik";
        public const string AKTOR_ROLA_PRODUCENT = "producent";

        //! Dane dostępowe do bazy danych
        static public string sqlConnect = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Lab\\Rachunki\\db_rachunki.mdf;Integrated Security=True;Connect Timeout=30";

        //! Metoda pobierająca użytkownika po loginie i haśle
        static public DataRow getUser(string login, string haslo)
        {
            string query = "SELECT * FROM Aktor WHERE login='" + login + "' AND haslo='" + haslo + "'";
            return getRow(query);
        }

        //! Metoda pobierjąca użytkownika po identyfikatorze
        static public DataRow getUser(int id)
        {
            string query = "SELECT * FROM Aktor WHERE id=" + id;
            return getRow(query);
        }

        //! Metoda pobierająca jeden rekord z bazy według podanej komendy SQL
        static public DataRow getRow(string query)
        {
            DataRowCollection rows = getRows(query);
            if (rows != null)
            {
                return rows[0];
            }
            return null;
        }

        //! Metoda pobierająca rekordy z bazy według podanej komendy SQL
        static public DataRowCollection getRows(string query)
        {
            SqlConnection connection = new SqlConnection(sqlConnect);
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                var table = new DataTable();
                table.Load(reader);
                return table.Rows;
            }
            return null;
        }

        //! Metoda wykonująca komendę SQL
        static public void query(string query)
        {
            SqlConnection connection = new SqlConnection(sqlConnect);
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
        }

        //! Metoda sprawdzająca poprawność NIPu
        public static bool ValidateNip(string nip)
        {
            if (nip.Length != 10)
                return false;
            if (!nip.All(cyfra => cyfra >= '0' && cyfra <= '9'))
                return false;

            int[] wagi = { 6, 5, 7, 2, 3, 4, 5, 6, 7, 0 };
            int suma = nip.Zip(wagi, (cyfra, waga) => (cyfra - '0') * waga)
                          .Sum();

            return (suma % 11) == (nip[9] - '0');
        }

        //! Główny punkt wejścia dla aplikacji.
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Logowanie());
        }
    }

    //! Klasa odpowiadająca za pojedyncza opcje wyboru typo Combo, z identyfikatorem oraz wyświetlaną nazwą | Kod ze strony: https://stackoverflow.com/
    public class ComboBoxItem
    {
        string displayValue;
        string hiddenValue;

        public ComboBoxItem(string d, string h)
        {
            displayValue = d;
            hiddenValue = h;
        }

        public string HiddenValue
        {
            get
            {
                return hiddenValue;
            }
        }
        public override string ToString()
        {
            return displayValue;
        }
    }

    //! Klasa odpwiadająca za wyświetlane komunikaty i zapytania
    public static class Prompt
    {
        //! Zmienna odpowiadająca za aktywność komunikatów
        public static bool Enabled = true;

        //! Wyświetlenie zapytania i zwrócenie wartości wpisanej przez użytkownika
        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 300,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 200 };
            Button confirmation = new Button() { Text = "OK", Left = 150, Width = 100, Top = 80, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }

        //! Wyświetlanie zapytania i zwrócenie wartości liczbowej wpisanej przez użytkownika
        public static int Int(string text)
        {
            string result = Prompt.ShowDialog(text, "").Trim();
            if (result == "")
            {
                return 0;
            }

            int id = 0;
            try
            {
                id = int.Parse(result);
            }
            catch
            {
            }

            return id;
        }

        //! Wyświetlenie komunikatu o błędzie
        public static void Error(string text)
        {
            if (!Enabled)
            {
                return;
            }
            MessageBox.Show(text, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        //! Wyświetlenie komunikatu o udanej akcji
        public static void Success(string text)
        {
            if (!Enabled)
            {
                return;
            }
            MessageBox.Show(text, "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
