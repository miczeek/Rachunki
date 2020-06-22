namespace Rachunki
{
    partial class DodajProdukt
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
            this.button_dodaj = new System.Windows.Forms.Button();
            this.combobox_typ = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textbox_nazwa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textbox_id = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.combobox_producent = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textbox_cena = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.textbox_cena)).BeginInit();
            this.SuspendLayout();
            // 
            // button_dodaj
            // 
            this.button_dodaj.Location = new System.Drawing.Point(29, 257);
            this.button_dodaj.Name = "button_dodaj";
            this.button_dodaj.Size = new System.Drawing.Size(163, 23);
            this.button_dodaj.TabIndex = 24;
            this.button_dodaj.Text = "Dodaj";
            this.button_dodaj.UseVisualStyleBackColor = true;
            this.button_dodaj.Click += new System.EventHandler(this.button_dodaj_Click);
            // 
            // combobox_typ
            // 
            this.combobox_typ.FormattingEnabled = true;
            this.combobox_typ.Location = new System.Drawing.Point(29, 125);
            this.combobox_typ.Name = "combobox_typ";
            this.combobox_typ.Size = new System.Drawing.Size(163, 21);
            this.combobox_typ.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Cena";
            // 
            // textbox_nazwa
            // 
            this.textbox_nazwa.Location = new System.Drawing.Point(29, 87);
            this.textbox_nazwa.MaxLength = 128;
            this.textbox_nazwa.Name = "textbox_nazwa";
            this.textbox_nazwa.Size = new System.Drawing.Size(163, 20);
            this.textbox_nazwa.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Nazwa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Typ";
            // 
            // textbox_id
            // 
            this.textbox_id.Location = new System.Drawing.Point(29, 48);
            this.textbox_id.Name = "textbox_id";
            this.textbox_id.ReadOnly = true;
            this.textbox_id.Size = new System.Drawing.Size(163, 20);
            this.textbox_id.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "ID";
            // 
            // combobox_producent
            // 
            this.combobox_producent.FormattingEnabled = true;
            this.combobox_producent.Location = new System.Drawing.Point(29, 169);
            this.combobox_producent.Name = "combobox_producent";
            this.combobox_producent.Size = new System.Drawing.Size(163, 21);
            this.combobox_producent.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Producent";
            // 
            // textbox_cena
            // 
            this.textbox_cena.DecimalPlaces = 2;
            this.textbox_cena.Location = new System.Drawing.Point(29, 212);
            this.textbox_cena.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.textbox_cena.Name = "textbox_cena";
            this.textbox_cena.Size = new System.Drawing.Size(163, 20);
            this.textbox_cena.TabIndex = 29;
            // 
            // DodajProdukt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 325);
            this.Controls.Add(this.textbox_cena);
            this.Controls.Add(this.combobox_producent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textbox_id);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button_dodaj);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textbox_nazwa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.combobox_typ);
            this.Controls.Add(this.label3);
            this.Name = "DodajProdukt";
            this.Text = "Dodawanie nowego produktu";
            ((System.ComponentModel.ISupportInitialize)(this.textbox_cena)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_dodaj;
        private System.Windows.Forms.ComboBox combobox_typ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textbox_nazwa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textbox_id;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox combobox_producent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown textbox_cena;
    }
}