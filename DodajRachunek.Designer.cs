namespace Rachunki
{
    partial class DodajRachunek
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
            this.button_utworz = new System.Windows.Forms.Button();
            this.combobox_klient = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_dodaj = new System.Windows.Forms.Button();
            this.data_rachunek = new System.Windows.Forms.DataGridView();
            this.id_produktu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nazwa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilosc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.laczna_cena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.data_rachunek)).BeginInit();
            this.SuspendLayout();
            // 
            // button_utworz
            // 
            this.button_utworz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_utworz.Location = new System.Drawing.Point(535, 28);
            this.button_utworz.Name = "button_utworz";
            this.button_utworz.Size = new System.Drawing.Size(235, 55);
            this.button_utworz.TabIndex = 0;
            this.button_utworz.Text = "Utworz rachunek";
            this.button_utworz.UseVisualStyleBackColor = true;
            this.button_utworz.Click += new System.EventHandler(this.button_utworz_Click);
            // 
            // combobox_klient
            // 
            this.combobox_klient.FormattingEnabled = true;
            this.combobox_klient.Location = new System.Drawing.Point(17, 49);
            this.combobox_klient.Name = "combobox_klient";
            this.combobox_klient.Size = new System.Drawing.Size(219, 21);
            this.combobox_klient.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Klient";
            // 
            // button_dodaj
            // 
            this.button_dodaj.Location = new System.Drawing.Point(273, 42);
            this.button_dodaj.Name = "button_dodaj";
            this.button_dodaj.Size = new System.Drawing.Size(219, 28);
            this.button_dodaj.TabIndex = 3;
            this.button_dodaj.Text = "Dodaj produkt";
            this.button_dodaj.UseVisualStyleBackColor = true;
            this.button_dodaj.Click += new System.EventHandler(this.button_dodaj_Click);
            // 
            // data_rachunek
            // 
            this.data_rachunek.AllowUserToAddRows = false;
            this.data_rachunek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_rachunek.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_produktu,
            this.Nazwa,
            this.typ,
            this.producent,
            this.cena,
            this.ilosc,
            this.laczna_cena});
            this.data_rachunek.Location = new System.Drawing.Point(17, 89);
            this.data_rachunek.Name = "data_rachunek";
            this.data_rachunek.ReadOnly = true;
            this.data_rachunek.Size = new System.Drawing.Size(755, 509);
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
            // DodajRachunek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 609);
            this.Controls.Add(this.data_rachunek);
            this.Controls.Add(this.button_dodaj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combobox_klient);
            this.Controls.Add(this.button_utworz);
            this.Name = "DodajRachunek";
            this.Text = "Dodawanie nowego rachunku";
            ((System.ComponentModel.ISupportInitialize)(this.data_rachunek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_utworz;
        private System.Windows.Forms.ComboBox combobox_klient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_dodaj;
        private System.Windows.Forms.DataGridView data_rachunek;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_produktu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nazwa;
        private System.Windows.Forms.DataGridViewTextBoxColumn typ;
        private System.Windows.Forms.DataGridViewTextBoxColumn producent;
        private System.Windows.Forms.DataGridViewTextBoxColumn cena;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilosc;
        private System.Windows.Forms.DataGridViewTextBoxColumn laczna_cena;
    }
}