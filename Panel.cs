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
    //! Klasa formularza - Panel sterowania aplikacją
    public partial class Panel : Form
    {
        private DataRow user;
        private int user_id;

        //! Konstuktor inicjalizujący komponenty, ukrywające opcje do których nie mamy dostępu na podstawie roli
        public Panel(DataRow user)
        {
            InitializeComponent();

            this.user = user;
            this.user_id = (int)user[Program.AKTOR_ID];

            group_uzytkownik.Visible = false;
            group_sprzedawca.Visible = false;
            group_admin.Visible = false;

            string rola = ((string)user[Program.AKTOR_ROLA]).Trim();
            if (rola == Program.AKTOR_ROLA_ADMIN)
            {
                group_admin.Visible = true;
                group_sprzedawca.Visible = true;
                group_uzytkownik.Visible = true;
            }
            else if (rola == Program.AKTOR_ROLA_SPRZEDAWCA)
            {
                group_sprzedawca.Visible = true;
                group_uzytkownik.Visible = true;
            }
            else if (rola == Program.AKTOR_ROLA_UZYTKOWNIK)
            {
                group_uzytkownik.Visible = true;
            }

            label_logged.Text = "Zalogowany jako: " + user[Program.AKTOR_LOGIN];
        }

        //! Zwrócenie aktualnego tekstu opisującego na jakie konto jesteśmy zalogowani
        public string get_label_logged()
        {
            return label_logged.Text;
        }

        //! Metoda wywoływana po kliknięciu przycisku "Wyloguj" powodująca zamknięcie aplikacji
        private void button_wyloguj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //! Metoda wywoływana po kliknięciu przycisku "Edytuj dane"
        private void button_edytuj_dane_Click(object sender, EventArgs e)
        {
            string rola = ((string)user[Program.AKTOR_ROLA]).Trim();
            EdytujDane popup = new EdytujDane(user_id, rola);
            popup.Show();
        }

        //! Metoda wywoływana po kliknięciu przycisku "Edytuj aktora"
        private void button_edytuj_aktora_Click(object sender, EventArgs e)
        {

            int id = Prompt.Int("Podaj ID aktora");

            DataRow aktor = Program.getUser(id);
            if (aktor == null)
            {
                Prompt.Error("Brak aktora o tym ID");
                return;
            }

            string rola = ((string)user[Program.AKTOR_ROLA]).Trim();
            EdytujDane popup = new EdytujDane(id, rola);
            popup.Show();
        }

        //! Metoda wywoływana po kliknięciu przycisku "Dodaj sprzedawcę"
        private void button_dodaj_sprzedawce_Click(object sender, EventArgs e)
        {
            string nowa_rola = Program.AKTOR_ROLA_SPRZEDAWCA;
            string rola = ((string)user[Program.AKTOR_ROLA]).Trim();
            DodajAktora popup = new DodajAktora(nowa_rola, rola);
            popup.Show();
        }

        //! Metoda wywoływana po kliknięciu przycisku "Dodaj producenta"
        private void button_dodaj_producenta_Click(object sender, EventArgs e)
        {
            string nowa_rola = Program.AKTOR_ROLA_PRODUCENT;
            string rola = ((string)user[Program.AKTOR_ROLA]).Trim();
            DodajAktora popup = new DodajAktora(nowa_rola, rola);
            popup.Show();
        }

        //! Metoda wywoływana po kliknięciu przycisku "Dodaj klienta"
        private void button_dodaj_klienta_Click(object sender, EventArgs e)
        {
            string nowa_rola = Program.AKTOR_ROLA_UZYTKOWNIK;
            string rola = ((string)user[Program.AKTOR_ROLA]).Trim();
            DodajAktora popup = new DodajAktora(nowa_rola, rola);
            popup.Show();
        }

        //! Metoda wywoływana po kliknięciu przycisku "Dodaj klienta"
        private void button_dodaj_klienta2_Click(object sender, EventArgs e)
        {
            string nowa_rola = Program.AKTOR_ROLA_UZYTKOWNIK;
            string rola = ((string)user[Program.AKTOR_ROLA]).Trim();
            DodajAktora popup = new DodajAktora(nowa_rola, rola);
            popup.Show();
        }

        //! Metoda wywoływana po kliknięciu przycisku "Dodaj produkt"
        private void button_dodaj_produkt_Click(object sender, EventArgs e)
        {
            DodajProdukt popup = new DodajProdukt();
            if (!popup.error)
            {
                popup.Show();
            }
        }

        //! Metoda wywoływana po kliknięciu przycisku "Dodaj typ produktu"
        private void button_dodaj_typ_produktu_Click(object sender, EventArgs e)
        {
            DodajTypProduktu popup = new DodajTypProduktu();
            popup.Show();
        }

        //! Metoda wywoływana po kliknięciu przycisku "Edytuj produkt"
        private void button_edytuj_produkt_Click(object sender, EventArgs e)
        {
            int id = Prompt.Int("Podaj ID produktu");

            DataRow produkt = Program.getRow("SELECT * FROM Produkt WHERE id=" + id);
            if (produkt == null)
            {
                Prompt.Error("Brak produktu o tym ID");
                return;
            }
            EdytujProdukt popup = new EdytujProdukt(produkt);
            popup.Show();
        }

        //! Metoda wywoływana po kliknięciu przycisku "Edytuj klienta"
        private void button_edytuj_klienta_Click(object sender, EventArgs e)
        {
            int id = Prompt.Int("Podaj ID klienta");

            DataRow aktor = Program.getUser(id);
            if (aktor == null)
            {
                Prompt.Error("Brak aktora o tym ID");
                return;
            }

            if (aktor[Program.AKTOR_ROLA].ToString().Trim() != Program.AKTOR_ROLA_UZYTKOWNIK)
            {
                Prompt.Error("Wybrany aktor to nie uzytkownik.");
                return;
            }

            string rola = ((string)user[Program.AKTOR_ROLA]).Trim();
            EdytujDane popup = new EdytujDane(id, rola);
            popup.Show();
        }

        //! Metoda wywoływana po kliknięciu przycisku "Nowy rachunek"
        private void button_nowy_rachunek_Click(object sender, EventArgs e)
        {
            DodajRachunek popup = new DodajRachunek((int)user[0]);
            popup.Show();
        }

        //! Metoda wywoływana po kliknięciu przycisku "Odbierz rachunek"
        private void button_odbierz_rachunek_Click(object sender, EventArgs e)
        {
            int id = Prompt.Int("Podaj ID rachunku");
            DataRow rachunek = Program.getRow("SELECT * FROM rachunek WHERE id=" + id);
            if (rachunek == null)
            {
                Prompt.Error("Wybrany rachunek nie istnieje.");
                return;
            }
            if ((int)rachunek[1] != (int)user[0] && (int)rachunek[2] != (int)user[0] && (string)user[Program.AKTOR_ROLA] != Program.AKTOR_ROLA_ADMIN)
            {
                Prompt.Error("To nie twój rachunek.");
                return;
            }

            WyswietlRachunek popup = new WyswietlRachunek((int)rachunek[0]);
            popup.Show();
        }

        //! Metoda wywoływana po kliknięciu przycisku "Historia rachunków"
        private void button_historia_rachunkow_Click(object sender, EventArgs e)
        {
            int id = (int)user[Program.AKTOR_ID];
            WyswietlHistorie popup = new WyswietlHistorie(id);
            popup.Show();
        }

        //! Metoda wywoływana po kliknięciu przycisku "Historia rachunków klienta"
        private void button_historia_rachunkow_klienta_Click(object sender, EventArgs e)
        {
            int id = Prompt.Int("Podaj ID klienta");

            DataRow aktor = Program.getUser(id);
            if (aktor == null)
            {
                Prompt.Error("Brak aktora o tym ID");
                return;
            }

            if (aktor[Program.AKTOR_ROLA].ToString().Trim() != Program.AKTOR_ROLA_UZYTKOWNIK)
            {
                Prompt.Error("Wybrany aktor to nie uzytkownik.");
                return;
            }

            WyswietlHistorie popup = new WyswietlHistorie(id);
            popup.Show();
        }

        //! Metoda wywoływana po zamknięciu panelu, zamyka również wszystkie inne okna
        private void Panel_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
