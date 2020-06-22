using System;

namespace Rachunki
{
    partial class Panel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_logged = new System.Windows.Forms.Label();
            this.button_dodaj_produkt = new System.Windows.Forms.Button();
            this.group_admin = new System.Windows.Forms.GroupBox();
            this.button_edytuj_aktora = new System.Windows.Forms.Button();
            this.button_dodaj_sprzedawce = new System.Windows.Forms.Button();
            this.button_dodaj_producenta = new System.Windows.Forms.Button();
            this.button_dodaj_klienta = new System.Windows.Forms.Button();
            this.button_dodaj_typ_produktu = new System.Windows.Forms.Button();
            this.button_edytuj_produkt = new System.Windows.Forms.Button();
            this.group_uzytkownik = new System.Windows.Forms.GroupBox();
            this.button_historia_rachunkow = new System.Windows.Forms.Button();
            this.button_odbierz_rachunek = new System.Windows.Forms.Button();
            this.button_edytuj_dane = new System.Windows.Forms.Button();
            this.group_sprzedawca = new System.Windows.Forms.GroupBox();
            this.button_edytuj_klienta = new System.Windows.Forms.Button();
            this.button_historia_rachunkow_klienta = new System.Windows.Forms.Button();
            this.button_dodaj_klienta2 = new System.Windows.Forms.Button();
            this.button_nowy_rachunek = new System.Windows.Forms.Button();
            this.button_wyloguj = new System.Windows.Forms.Button();
            this.group_admin.SuspendLayout();
            this.group_uzytkownik.SuspendLayout();
            this.group_sprzedawca.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_logged
            // 
            this.label_logged.AutoSize = true;
            this.label_logged.Location = new System.Drawing.Point(556, 20);
            this.label_logged.Name = "label_logged";
            this.label_logged.Size = new System.Drawing.Size(88, 13);
            this.label_logged.TabIndex = 1;
            this.label_logged.Text = "Zalogowany jako";
            this.label_logged.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button_dodaj_produkt
            // 
            this.button_dodaj_produkt.Location = new System.Drawing.Point(6, 19);
            this.button_dodaj_produkt.Name = "button_dodaj_produkt";
            this.button_dodaj_produkt.Size = new System.Drawing.Size(223, 23);
            this.button_dodaj_produkt.TabIndex = 2;
            this.button_dodaj_produkt.Text = "Dodaj produkt";
            this.button_dodaj_produkt.UseVisualStyleBackColor = true;
            this.button_dodaj_produkt.Click += new System.EventHandler(this.button_dodaj_produkt_Click);
            // 
            // group_admin
            // 
            this.group_admin.Controls.Add(this.button_edytuj_aktora);
            this.group_admin.Controls.Add(this.button_dodaj_sprzedawce);
            this.group_admin.Controls.Add(this.button_dodaj_producenta);
            this.group_admin.Controls.Add(this.button_dodaj_klienta);
            this.group_admin.Controls.Add(this.button_dodaj_typ_produktu);
            this.group_admin.Controls.Add(this.button_edytuj_produkt);
            this.group_admin.Controls.Add(this.button_dodaj_produkt);
            this.group_admin.Location = new System.Drawing.Point(553, 74);
            this.group_admin.Name = "group_admin";
            this.group_admin.Size = new System.Drawing.Size(235, 335);
            this.group_admin.TabIndex = 6;
            this.group_admin.TabStop = false;
            this.group_admin.Text = "Panel administratora";
            // 
            // button_edytuj_aktora
            // 
            this.button_edytuj_aktora.Location = new System.Drawing.Point(6, 217);
            this.button_edytuj_aktora.Name = "button_edytuj_aktora";
            this.button_edytuj_aktora.Size = new System.Drawing.Size(223, 23);
            this.button_edytuj_aktora.TabIndex = 8;
            this.button_edytuj_aktora.Text = "Edytuj aktora";
            this.button_edytuj_aktora.UseVisualStyleBackColor = true;
            this.button_edytuj_aktora.Click += new System.EventHandler(this.button_edytuj_aktora_Click);
            // 
            // button_dodaj_sprzedawce
            // 
            this.button_dodaj_sprzedawce.Location = new System.Drawing.Point(6, 188);
            this.button_dodaj_sprzedawce.Name = "button_dodaj_sprzedawce";
            this.button_dodaj_sprzedawce.Size = new System.Drawing.Size(223, 23);
            this.button_dodaj_sprzedawce.TabIndex = 7;
            this.button_dodaj_sprzedawce.Text = "Dodaj sprzedawce";
            this.button_dodaj_sprzedawce.UseVisualStyleBackColor = true;
            this.button_dodaj_sprzedawce.Click += new System.EventHandler(this.button_dodaj_sprzedawce_Click);
            // 
            // button_dodaj_producenta
            // 
            this.button_dodaj_producenta.Location = new System.Drawing.Point(6, 159);
            this.button_dodaj_producenta.Name = "button_dodaj_producenta";
            this.button_dodaj_producenta.Size = new System.Drawing.Size(223, 23);
            this.button_dodaj_producenta.TabIndex = 6;
            this.button_dodaj_producenta.Text = "Dodaj producenta";
            this.button_dodaj_producenta.UseVisualStyleBackColor = true;
            this.button_dodaj_producenta.Click += new System.EventHandler(this.button_dodaj_producenta_Click);
            // 
            // button_dodaj_klienta
            // 
            this.button_dodaj_klienta.Location = new System.Drawing.Point(6, 130);
            this.button_dodaj_klienta.Name = "button_dodaj_klienta";
            this.button_dodaj_klienta.Size = new System.Drawing.Size(223, 23);
            this.button_dodaj_klienta.TabIndex = 5;
            this.button_dodaj_klienta.Text = "Dodaj klienta";
            this.button_dodaj_klienta.UseVisualStyleBackColor = true;
            this.button_dodaj_klienta.Click += new System.EventHandler(this.button_dodaj_klienta_Click);
            // 
            // button_dodaj_typ_produktu
            // 
            this.button_dodaj_typ_produktu.Location = new System.Drawing.Point(6, 77);
            this.button_dodaj_typ_produktu.Name = "button_dodaj_typ_produktu";
            this.button_dodaj_typ_produktu.Size = new System.Drawing.Size(223, 23);
            this.button_dodaj_typ_produktu.TabIndex = 4;
            this.button_dodaj_typ_produktu.Text = "Dodaj typ produktu";
            this.button_dodaj_typ_produktu.UseVisualStyleBackColor = true;
            this.button_dodaj_typ_produktu.Click += new System.EventHandler(this.button_dodaj_typ_produktu_Click);
            // 
            // button_edytuj_produkt
            // 
            this.button_edytuj_produkt.Location = new System.Drawing.Point(6, 48);
            this.button_edytuj_produkt.Name = "button_edytuj_produkt";
            this.button_edytuj_produkt.Size = new System.Drawing.Size(223, 23);
            this.button_edytuj_produkt.TabIndex = 3;
            this.button_edytuj_produkt.Text = "Edytuj produkt";
            this.button_edytuj_produkt.UseVisualStyleBackColor = true;
            this.button_edytuj_produkt.Click += new System.EventHandler(this.button_edytuj_produkt_Click);
            // 
            // group_uzytkownik
            // 
            this.group_uzytkownik.Controls.Add(this.button_historia_rachunkow);
            this.group_uzytkownik.Controls.Add(this.button_odbierz_rachunek);
            this.group_uzytkownik.Controls.Add(this.button_edytuj_dane);
            this.group_uzytkownik.Location = new System.Drawing.Point(12, 74);
            this.group_uzytkownik.Name = "group_uzytkownik";
            this.group_uzytkownik.Size = new System.Drawing.Size(235, 335);
            this.group_uzytkownik.TabIndex = 7;
            this.group_uzytkownik.TabStop = false;
            this.group_uzytkownik.Text = "Panel uzytkownika";
            // 
            // button_historia_rachunkow
            // 
            this.button_historia_rachunkow.Location = new System.Drawing.Point(6, 92);
            this.button_historia_rachunkow.Name = "button_historia_rachunkow";
            this.button_historia_rachunkow.Size = new System.Drawing.Size(223, 23);
            this.button_historia_rachunkow.TabIndex = 13;
            this.button_historia_rachunkow.Text = "Historia rachunkow";
            this.button_historia_rachunkow.UseVisualStyleBackColor = true;
            this.button_historia_rachunkow.Click += new System.EventHandler(this.button_historia_rachunkow_Click);
            // 
            // button_odbierz_rachunek
            // 
            this.button_odbierz_rachunek.Location = new System.Drawing.Point(6, 63);
            this.button_odbierz_rachunek.Name = "button_odbierz_rachunek";
            this.button_odbierz_rachunek.Size = new System.Drawing.Size(223, 23);
            this.button_odbierz_rachunek.TabIndex = 11;
            this.button_odbierz_rachunek.Text = "Odbierz rachunek";
            this.button_odbierz_rachunek.UseVisualStyleBackColor = true;
            this.button_odbierz_rachunek.Click += new System.EventHandler(this.button_odbierz_rachunek_Click);
            // 
            // button_edytuj_dane
            // 
            this.button_edytuj_dane.Location = new System.Drawing.Point(6, 19);
            this.button_edytuj_dane.Name = "button_edytuj_dane";
            this.button_edytuj_dane.Size = new System.Drawing.Size(223, 23);
            this.button_edytuj_dane.TabIndex = 9;
            this.button_edytuj_dane.Text = "Edytuj dane";
            this.button_edytuj_dane.UseVisualStyleBackColor = true;
            this.button_edytuj_dane.Click += new System.EventHandler(this.button_edytuj_dane_Click);
            // 
            // group_sprzedawca
            // 
            this.group_sprzedawca.Controls.Add(this.button_edytuj_klienta);
            this.group_sprzedawca.Controls.Add(this.button_historia_rachunkow_klienta);
            this.group_sprzedawca.Controls.Add(this.button_dodaj_klienta2);
            this.group_sprzedawca.Controls.Add(this.button_nowy_rachunek);
            this.group_sprzedawca.Location = new System.Drawing.Point(284, 74);
            this.group_sprzedawca.Name = "group_sprzedawca";
            this.group_sprzedawca.Size = new System.Drawing.Size(235, 335);
            this.group_sprzedawca.TabIndex = 8;
            this.group_sprzedawca.TabStop = false;
            this.group_sprzedawca.Text = "Panel sprzedawcy";
            // 
            // button_edytuj_klienta
            // 
            this.button_edytuj_klienta.Location = new System.Drawing.Point(6, 48);
            this.button_edytuj_klienta.Name = "button_edytuj_klienta";
            this.button_edytuj_klienta.Size = new System.Drawing.Size(223, 23);
            this.button_edytuj_klienta.TabIndex = 13;
            this.button_edytuj_klienta.Text = "Edytuj klienta";
            this.button_edytuj_klienta.UseVisualStyleBackColor = true;
            this.button_edytuj_klienta.Click += new System.EventHandler(this.button_edytuj_klienta_Click);
            // 
            // button_historia_rachunkow_klienta
            // 
            this.button_historia_rachunkow_klienta.Location = new System.Drawing.Point(6, 116);
            this.button_historia_rachunkow_klienta.Name = "button_historia_rachunkow_klienta";
            this.button_historia_rachunkow_klienta.Size = new System.Drawing.Size(223, 23);
            this.button_historia_rachunkow_klienta.TabIndex = 12;
            this.button_historia_rachunkow_klienta.Text = "Historia rachunkow klienta";
            this.button_historia_rachunkow_klienta.UseVisualStyleBackColor = true;
            this.button_historia_rachunkow_klienta.Click += new System.EventHandler(this.button_historia_rachunkow_klienta_Click);
            // 
            // button_dodaj_klienta2
            // 
            this.button_dodaj_klienta2.Location = new System.Drawing.Point(6, 19);
            this.button_dodaj_klienta2.Name = "button_dodaj_klienta2";
            this.button_dodaj_klienta2.Size = new System.Drawing.Size(223, 23);
            this.button_dodaj_klienta2.TabIndex = 11;
            this.button_dodaj_klienta2.Text = "Dodaj klienta";
            this.button_dodaj_klienta2.UseVisualStyleBackColor = true;
            this.button_dodaj_klienta2.Click += new System.EventHandler(this.button_dodaj_klienta2_Click);
            // 
            // button_nowy_rachunek
            // 
            this.button_nowy_rachunek.Location = new System.Drawing.Point(6, 87);
            this.button_nowy_rachunek.Name = "button_nowy_rachunek";
            this.button_nowy_rachunek.Size = new System.Drawing.Size(223, 23);
            this.button_nowy_rachunek.TabIndex = 10;
            this.button_nowy_rachunek.Text = "Nowy rachunek";
            this.button_nowy_rachunek.UseVisualStyleBackColor = true;
            this.button_nowy_rachunek.Click += new System.EventHandler(this.button_nowy_rachunek_Click);
            // 
            // button_wyloguj
            // 
            this.button_wyloguj.Location = new System.Drawing.Point(559, 36);
            this.button_wyloguj.Name = "button_wyloguj";
            this.button_wyloguj.Size = new System.Drawing.Size(75, 23);
            this.button_wyloguj.TabIndex = 0;
            this.button_wyloguj.Text = "Wyloguj";
            this.button_wyloguj.UseVisualStyleBackColor = true;
            this.button_wyloguj.Click += new System.EventHandler(this.button_wyloguj_Click);
            // 
            // Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_wyloguj);
            this.Controls.Add(this.group_sprzedawca);
            this.Controls.Add(this.group_uzytkownik);
            this.Controls.Add(this.group_admin);
            this.Controls.Add(this.label_logged);
            this.Name = "Panel";
            this.Text = "Panel zarządzania rachunkami";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Panel_FormClosed);
            this.group_admin.ResumeLayout(false);
            this.group_uzytkownik.ResumeLayout(false);
            this.group_sprzedawca.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_logged;
        private System.Windows.Forms.Button button_dodaj_produkt;
        private System.Windows.Forms.GroupBox group_admin;
        private System.Windows.Forms.GroupBox group_uzytkownik;
        private System.Windows.Forms.GroupBox group_sprzedawca;
        private System.Windows.Forms.Button button_wyloguj;
        private System.Windows.Forms.Button button_edytuj_aktora;
        private System.Windows.Forms.Button button_dodaj_sprzedawce;
        private System.Windows.Forms.Button button_dodaj_producenta;
        private System.Windows.Forms.Button button_dodaj_klienta;
        private System.Windows.Forms.Button button_dodaj_typ_produktu;
        private System.Windows.Forms.Button button_edytuj_produkt;
        private System.Windows.Forms.Button button_nowy_rachunek;
        private System.Windows.Forms.Button button_edytuj_dane;
        private System.Windows.Forms.Button button_odbierz_rachunek;
        private System.Windows.Forms.Button button_historia_rachunkow;
        private System.Windows.Forms.Button button_edytuj_klienta;
        private System.Windows.Forms.Button button_historia_rachunkow_klienta;
        private System.Windows.Forms.Button button_dodaj_klienta2;
    }
}