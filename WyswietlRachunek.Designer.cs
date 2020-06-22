namespace Rachunki
{
    partial class WyswietlRachunek
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
            this.data_rachunek = new System.Windows.Forms.DataGridView();
            this.id_produktu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nazwa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilosc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.laczna_cena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textbox_klient = new System.Windows.Forms.TextBox();
            this.textbox_sprzedawca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textbox_data = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textbox_produktow = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textbox_cena = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_rachunek)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Klient";
            // 
            // data_rachunek
            // 
            this.data_rachunek.AllowUserToAddRows = false;
            this.data_rachunek.AllowUserToDeleteRows = false;
            this.data_rachunek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_rachunek.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_produktu,
            this.Nazwa,
            this.typ,
            this.producent,
            this.cena,
            this.ilosc,
            this.laczna_cena});
            this.data_rachunek.Location = new System.Drawing.Point(17, 103);
            this.data_rachunek.Name = "data_rachunek";
            this.data_rachunek.ReadOnly = true;
            this.data_rachunek.Size = new System.Drawing.Size(755, 391);
            this.data_rachunek.TabIndex = 4;
            // 
            // id_produktu
            // 
            this.id_produktu.HeaderText = "ID produktu";
            this.id_produktu.Name = "id_produktu";
            this.id_produktu.ReadOnly = true;
            // 
            // Nazwa
            // 
            this.Nazwa.HeaderText = "Nazwa";
            this.Nazwa.Name = "Nazwa";
            this.Nazwa.ReadOnly = true;
            // 
            // typ
            // 
            this.typ.HeaderText = "Typ";
            this.typ.Name = "typ";
            this.typ.ReadOnly = true;
            // 
            // producent
            // 
            this.producent.HeaderText = "Producent";
            this.producent.Name = "producent";
            this.producent.ReadOnly = true;
            // 
            // cena
            // 
            this.cena.HeaderText = "Cena";
            this.cena.Name = "cena";
            this.cena.ReadOnly = true;
            // 
            // ilosc
            // 
            this.ilosc.HeaderText = "Ilosc";
            this.ilosc.Name = "ilosc";
            this.ilosc.ReadOnly = true;
            // 
            // laczna_cena
            // 
            this.laczna_cena.HeaderText = "Łączna cena";
            this.laczna_cena.Name = "laczna_cena";
            this.laczna_cena.ReadOnly = true;
            // 
            // textbox_klient
            // 
            this.textbox_klient.Location = new System.Drawing.Point(109, 12);
            this.textbox_klient.Name = "textbox_klient";
            this.textbox_klient.ReadOnly = true;
            this.textbox_klient.Size = new System.Drawing.Size(235, 20);
            this.textbox_klient.TabIndex = 5;
            // 
            // textbox_sprzedawca
            // 
            this.textbox_sprzedawca.Location = new System.Drawing.Point(109, 38);
            this.textbox_sprzedawca.Name = "textbox_sprzedawca";
            this.textbox_sprzedawca.ReadOnly = true;
            this.textbox_sprzedawca.Size = new System.Drawing.Size(235, 20);
            this.textbox_sprzedawca.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sprzedawca";
            // 
            // textbox_data
            // 
            this.textbox_data.Location = new System.Drawing.Point(109, 63);
            this.textbox_data.Name = "textbox_data";
            this.textbox_data.ReadOnly = true;
            this.textbox_data.Size = new System.Drawing.Size(235, 20);
            this.textbox_data.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Data";
            // 
            // textbox_produktow
            // 
            this.textbox_produktow.Location = new System.Drawing.Point(537, 67);
            this.textbox_produktow.Name = "textbox_produktow";
            this.textbox_produktow.ReadOnly = true;
            this.textbox_produktow.Size = new System.Drawing.Size(235, 20);
            this.textbox_produktow.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(442, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Produktów";
            // 
            // textbox_cena
            // 
            this.textbox_cena.Location = new System.Drawing.Point(537, 41);
            this.textbox_cena.Name = "textbox_cena";
            this.textbox_cena.ReadOnly = true;
            this.textbox_cena.Size = new System.Drawing.Size(235, 20);
            this.textbox_cena.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(442, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Łączna cena";
            // 
            // WyswietlRachunek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 506);
            this.Controls.Add(this.textbox_produktow);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textbox_cena);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textbox_data);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textbox_sprzedawca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textbox_klient);
            this.Controls.Add(this.data_rachunek);
            this.Controls.Add(this.label1);
            this.Name = "WyswietlRachunek";
            this.Text = "Wyswietlanie rachunku";
            ((System.ComponentModel.ISupportInitialize)(this.data_rachunek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView data_rachunek;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_produktu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nazwa;
        private System.Windows.Forms.DataGridViewTextBoxColumn typ;
        private System.Windows.Forms.DataGridViewTextBoxColumn producent;
        private System.Windows.Forms.DataGridViewTextBoxColumn cena;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilosc;
        private System.Windows.Forms.DataGridViewTextBoxColumn laczna_cena;
        private System.Windows.Forms.TextBox textbox_klient;
        private System.Windows.Forms.TextBox textbox_sprzedawca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textbox_data;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textbox_produktow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textbox_cena;
        private System.Windows.Forms.Label label5;
    }
}