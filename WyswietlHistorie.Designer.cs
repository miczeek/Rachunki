namespace Rachunki
{
    partial class WyswietlHistorie
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
            this.textbox_klient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.data_historia = new System.Windows.Forms.DataGridView();
            this.id_rachunku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sprzedawca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produktow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.data_historia)).BeginInit();
            this.SuspendLayout();
            // 
            // textbox_klient
            // 
            this.textbox_klient.Location = new System.Drawing.Point(112, 31);
            this.textbox_klient.Name = "textbox_klient";
            this.textbox_klient.ReadOnly = true;
            this.textbox_klient.Size = new System.Drawing.Size(333, 20);
            this.textbox_klient.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Klient";
            // 
            // data_historia
            // 
            this.data_historia.AllowUserToAddRows = false;
            this.data_historia.AllowUserToDeleteRows = false;
            this.data_historia.AllowUserToOrderColumns = true;
            this.data_historia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_historia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_rachunku,
            this.sprzedawca,
            this.produktow,
            this.cena,
            this.data});
            this.data_historia.Location = new System.Drawing.Point(12, 79);
            this.data_historia.Name = "data_historia";
            this.data_historia.ReadOnly = true;
            this.data_historia.Size = new System.Drawing.Size(555, 410);
            this.data_historia.TabIndex = 8;
            // 
            // id_rachunku
            // 
            this.id_rachunku.HeaderText = "ID rachunku";
            this.id_rachunku.Name = "id_rachunku";
            this.id_rachunku.ReadOnly = true;
            // 
            // sprzedawca
            // 
            this.sprzedawca.HeaderText = "Sprzedawca";
            this.sprzedawca.Name = "sprzedawca";
            this.sprzedawca.ReadOnly = true;
            // 
            // produktow
            // 
            this.produktow.HeaderText = "Produktow";
            this.produktow.Name = "produktow";
            this.produktow.ReadOnly = true;
            // 
            // cena
            // 
            this.cena.HeaderText = "Łączna cena";
            this.cena.Name = "cena";
            this.cena.ReadOnly = true;
            // 
            // data
            // 
            this.data.HeaderText = "Data";
            this.data.Name = "data";
            this.data.ReadOnly = true;
            // 
            // WyswietlHistorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 504);
            this.Controls.Add(this.data_historia);
            this.Controls.Add(this.textbox_klient);
            this.Controls.Add(this.label1);
            this.Name = "WyswietlHistorie";
            this.Text = "Wyswietlanie historii";
            ((System.ComponentModel.ISupportInitialize)(this.data_historia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textbox_klient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView data_historia;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_rachunku;
        private System.Windows.Forms.DataGridViewTextBoxColumn sprzedawca;
        private System.Windows.Forms.DataGridViewTextBoxColumn produktow;
        private System.Windows.Forms.DataGridViewTextBoxColumn cena;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
    }
}