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
    //! Klasa formularza - Dodanie nowego typu produktu
    public partial class DodajTypProduktu : Form
    {
        //! Konstuktor inicjalizujący komponenty
        public DodajTypProduktu()
        {
            InitializeComponent();
        }

        //! Metoda wywoływana po kliknięciu przycisku "Dodaj"
        private void button_dodaj_Click(object sender, EventArgs e)
        {
            string typ = textbox_typ.Text.Trim();

            if (typ.Length < 3)
            {
                Prompt.Error("Nazwa typu jest zbyt krótka.");
                return;
            }

            SqlConnection connection = new SqlConnection(Program.sqlConnect);
            connection.Open();
            SqlCommand command = new SqlCommand(null, connection);
            command.CommandText = "INSERT INTO ProduktTyp (typ) output INSERTED.ID VALUES (@typ)";
            command.Parameters.AddWithValue("@typ", typ);
            int id = (int)command.ExecuteScalar();

            Prompt.Success("Dodano nowego typ produktu z ID: " + id);
            this.Close();
        }
    }
}
