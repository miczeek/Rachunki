namespace Rachunki
{
    partial class EdytujDane
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
            this.label1 = new System.Windows.Forms.Label();
            this.textbox_login = new System.Windows.Forms.TextBox();
            this.textbox_haslo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textbox_numer_telefonu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textbox_nip = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textbox_nazwa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textbox_id = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.combobox_rola = new System.Windows.Forms.ComboBox();
            this.button_zapisz = new System.Windows.Forms.Button();
            this.label_wynik = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // textbox_login
            // 
            this.textbox_login.Location = new System.Drawing.Point(25, 65);
            this.textbox_login.MaxLength = 32;
            this.textbox_login.Name = "textbox_login";
            this.textbox_login.ReadOnly = true;
            this.textbox_login.Size = new System.Drawing.Size(163, 20);
            this.textbox_login.TabIndex = 1;
            // 
            // textbox_haslo
            // 
            this.textbox_haslo.Location = new System.Drawing.Point(25, 104);
            this.textbox_haslo.MaxLength = 40;
            this.textbox_haslo.Name = "textbox_haslo";
            this.textbox_haslo.PasswordChar = '*';
            this.textbox_haslo.ReadOnly = true;
            this.textbox_haslo.Size = new System.Drawing.Size(163, 20);
            this.textbox_haslo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hasło";
            // 
            // textbox_numer_telefonu
            // 
            this.textbox_numer_telefonu.Location = new System.Drawing.Point(25, 260);
            this.textbox_numer_telefonu.MaxLength = 15;
            this.textbox_numer_telefonu.Name = "textbox_numer_telefonu";
            this.textbox_numer_telefonu.Size = new System.Drawing.Size(163, 20);
            this.textbox_numer_telefonu.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Numer telefonu";
            // 
            // textbox_nip
            // 
            this.textbox_nip.Location = new System.Drawing.Point(25, 221);
            this.textbox_nip.MaxLength = 10;
            this.textbox_nip.Name = "textbox_nip";
            this.textbox_nip.Size = new System.Drawing.Size(163, 20);
            this.textbox_nip.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "NIP";
            // 
            // textbox_nazwa
            // 
            this.textbox_nazwa.Location = new System.Drawing.Point(25, 182);
            this.textbox_nazwa.Name = "textbox_nazwa";
            this.textbox_nazwa.Size = new System.Drawing.Size(402, 20);
            this.textbox_nazwa.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nazwa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rola";
            // 
            // textbox_id
            // 
            this.textbox_id.Location = new System.Drawing.Point(25, 26);
            this.textbox_id.Name = "textbox_id";
            this.textbox_id.ReadOnly = true;
            this.textbox_id.Size = new System.Drawing.Size(163, 20);
            this.textbox_id.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "ID";
            // 
            // combobox_rola
            // 
            this.combobox_rola.Enabled = false;
            this.combobox_rola.FormattingEnabled = true;
            this.combobox_rola.Items.AddRange(new object[] {
            "uzytkownik",
            "sprzedawca",
            "producent",
            "administrator"});
            this.combobox_rola.Location = new System.Drawing.Point(25, 142);
            this.combobox_rola.Name = "combobox_rola";
            this.combobox_rola.Size = new System.Drawing.Size(163, 21);
            this.combobox_rola.TabIndex = 14;
            // 
            // button_zapisz
            // 
            this.button_zapisz.Location = new System.Drawing.Point(25, 300);
            this.button_zapisz.Name = "button_zapisz";
            this.button_zapisz.Size = new System.Drawing.Size(163, 23);
            this.button_zapisz.TabIndex = 15;
            this.button_zapisz.Text = "Zapisz";
            this.button_zapisz.UseVisualStyleBackColor = true;
            this.button_zapisz.Click += new System.EventHandler(this.button_zapisz_Click);
            // 
            // label_wynik
            // 
            this.label_wynik.AutoSize = true;
            this.label_wynik.Location = new System.Drawing.Point(29, 348);
            this.label_wynik.Name = "label_wynik";
            this.label_wynik.Size = new System.Drawing.Size(0, 13);
            this.label_wynik.TabIndex = 16;
            // 
            // EdytujDane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 349);
            this.Controls.Add(this.label_wynik);
            this.Controls.Add(this.button_zapisz);
            this.Controls.Add(this.combobox_rola);
            this.Controls.Add(this.textbox_id);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textbox_numer_telefonu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textbox_nip);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textbox_nazwa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textbox_haslo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textbox_login);
            this.Controls.Add(this.label1);
            this.Name = "EdytujDane";
            this.Text = "Edytowanie danych aktora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textbox_login;
        private System.Windows.Forms.TextBox textbox_haslo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textbox_numer_telefonu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textbox_nip;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textbox_nazwa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textbox_id;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox combobox_rola;
        private System.Windows.Forms.Button button_zapisz;
        private System.Windows.Forms.Label label_wynik;
    }
}