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
    //! Klasa formularza - Wyświetlanie rachunku
    public partial class WyswietlRachunek : Form
    {
        //! Konstuktor inicjalizujący komponenty
        public WyswietlRachunek(int id)
        {
            InitializeComponent();

            DataRow rachunek = Program.getRow("SELECT * FROM Rachunek WHERE id=" + id);
            int id_klienta = (int)rachunek[1];
            int id_sprzedawcy = (int)rachunek[2];
            string data = rachunek[3].ToString().Substring(0, 10);
            DataRow klient = Program.getRow("SELECT * FROM Aktor WHERE id=" + id_klienta);
            DataRow sprzedawca = Program.getRow("SELECT * FROM Aktor WHERE id=" + id_sprzedawcy);

            DataRowCollection produkty = Program.getRows("SELECT P.id, P.nazwa, Typ.typ, Producent.nazwa as producent, RP.cena, RP.ilosc FROM RachunekProdukt RP INNER JOIN Produkt P ON P.Id=RP.id_produktu INNER JOIN ProduktTyp Typ ON Typ.id=P.id_typ INNER JOIN Aktor Producent ON Producent.id=P.id_producent WHERE RP.id_rachunku=" + id);

            decimal rachunek_cena = 0;
            int rachunek_ilosc = 0;

            if (produkty != null)
            {
                foreach (DataRow produkt in produkty)
                {
                    int ilosc = (int)produkt[5];
                    decimal laczna_cena = (decimal)produkt[4] * ilosc;
                    rachunek_cena += laczna_cena;
                    rachunek_ilosc += ilosc;
                    data_rachunek.Rows.Add(produkt[0], produkt[1], produkt[2], produkt[3], produkt[4], produkt[5], laczna_cena.ToString());
                }
            }

            textbox_data.Text = data;
            textbox_klient.Text = (string)klient[Program.AKTOR_NAZWA];
            textbox_sprzedawca.Text = (string)sprzedawca[Program.AKTOR_NAZWA];
            textbox_produktow.Text = rachunek_ilosc.ToString();
            textbox_cena.Text = rachunek_cena.ToString();
        }
    }
}