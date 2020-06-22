﻿using System;
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rachunki;

namespace RachunkiTestyNameSpace
{
    [TestClass]
    public class RachunkiTestyClass
    {
        DataRow user = null;
        int user_id;
        [TestInitialize]
        public void Setup()
        {
            Prompt.Enabled = false;
            user = Rachunki.Program.getRow("SELECT * FROM Aktor");
            user_id = (int)user[Program.AKTOR_ID];
            if (user == null)
            {
                throw new Exception("brak uzytkownikow w bazie");
            }
        }

        [TestMethod]
        public void LogowanieAdmin()
        {
            string login = "admin";
            string haslo = "admin";
            DataRow user = Rachunki.Program.getUser(login, haslo);
            Assert.IsNotNull(user);
        }

        [TestMethod]
        public void LogowanieZle()
        {
            string login = "admin";
            string haslo = "";
            DataRow user = Rachunki.Program.getUser(login, haslo);
            Assert.IsNull(user);
        }

        [TestMethod]
        public void LogowanieFormularz()
        {
            Logowanie popup = new Logowanie();
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void PanelFormularz()
        {
            Panel popup = new Panel(user);
            string label_logged = popup.get_label_logged();
            Assert.AreEqual("Zalogowany jako: " + user[Program.AKTOR_LOGIN], label_logged);
        }

        [TestMethod]
        public void DodajAktoraFormularz()
        {
            string rola = Program.AKTOR_ROLA_UZYTKOWNIK;
            DodajAktora popup = new DodajAktora(rola, Program.AKTOR_ROLA_ADMIN);

            Assert.AreEqual(popup.get_wybrana_rola(), rola);
        }

        [TestMethod]
        public void DodajProduktFormularz()
        {
            DodajProdukt popup = new DodajProdukt();
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void DodajRachunekFormularz()
        {
            DodajRachunek popup = new DodajRachunek(user_id);
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void DodajTypProduktuFormularz()
        {
            DodajTypProduktu popup = new DodajTypProduktu();
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void EdytujAktoraFormularz()
        {
            EdytujDane popup = new EdytujDane(user_id, Program.AKTOR_ROLA_ADMIN);
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void EdytujProduktFormularz()
        {
            DataRow produkt = Program.getRow("SELECT * FROM Produkt");
            if (produkt == null)
            {
                Assert.Inconclusive("brak produktow w bazie");
            }
            EdytujProdukt popup = new EdytujProdukt(produkt);
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void WyswietlHistorieFormularz()
        {
            WyswietlHistorie popup = new WyswietlHistorie(user_id);
            Assert.IsTrue(true);
        }
        [TestMethod]
        public void WyswietlRachunekFormularz()
        {
            DataRow rachunek = Program.getRow("SELECT * FROM rachunek");
            if (rachunek == null)
            {
                Assert.Inconclusive("brak rachunkow w bazie");
            }
            int id = (int)rachunek[0];
            WyswietlRachunek popup = new WyswietlRachunek(id);
            Assert.IsTrue(true);
        }
    }
}
