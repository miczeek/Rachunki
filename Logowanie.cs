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
    public partial class Logowanie : Form
    {
        public Logowanie()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            DataRow user = Program.getUser(textbox_login.Text, textbox_haslo.Text);
            if (user != null)
            {
                label_wynik.Text = "Logowanie udane.";
                this.Hide();

                Form main = new Panel(user);
                main.Show();
            } else
            {
                label_wynik.Text = "Podano bledne dane logowania.";
            }
        }
    }
}
