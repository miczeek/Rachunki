using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;


namespace Rachunki
{
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
    public static class Prompt
    {
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

        public static void Error(string text)
        {
            MessageBox.Show(text, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        public static void Success(string text)
        {
            MessageBox.Show(text, "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    static class Program
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

        static public string sqlConnect = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\db_rachunki.mdf;Integrated Security=True;Connect Timeout=30";

        static public DataRow getUser(string login, string haslo)
        {
            string query = "SELECT * FROM Aktor WHERE login='" + login + "' AND haslo='" + haslo + "'";
            return getRow(query);
        }
        static public DataRow getUser(int id)
        {
            string query = "SELECT * FROM Aktor WHERE id=" + id;
            return getRow(query);
        }

        static public DataRow getRow(string query)
        {
            DataRowCollection rows = getRows(query);
            if (rows != null)
            {
                return rows[0];
            }
            return null;
        }

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
        static public void query(string query)
        {
            SqlConnection connection = new SqlConnection(sqlConnect);
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
        }

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
}
