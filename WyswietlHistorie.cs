using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rachunki
{
    public partial class WyswietlHistorie : Form
    {
        public WyswietlHistorie(int id)
        {
            InitializeComponent();

            DataRow klient = Program.getUser(id);

            textbox_klient.Text = (string)klient[Program.AKTOR_NAZWA];

            DataRowCollection historia = Program.getRows("SELECT R.id, MIN(Sprzedawca.nazwa) as sprzedawca, SUM(RP.ilosc) as laczna_ilosc, SUM(RP.ilosc * RP.cena) as laczna_cena, MIN(data) as data FROM Rachunek R INNER JOIN RachunekProdukt RP ON RP.id_rachunku=R.id INNER JOIN Aktor Sprzedawca ON R.id_sprzedawcy=Sprzedawca.id WHERE R.id_klienta=" + id + " GROUP BY R.id");
            if (historia != null)
            {
                foreach (DataRow row in historia)
                {
                    data_historia.Rows.Add(row[0], row[1], row[2], row[3], row[4]);
                }
            }
        }
    }
}
