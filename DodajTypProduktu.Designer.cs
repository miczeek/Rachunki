namespace Rachunki
{
    partial class DodajTypProduktu
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
            this.textbox_typ = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_dodaj
            // 
            this.button_dodaj.Location = new System.Drawing.Point(99, 74);
            this.button_dodaj.Name = "button_dodaj";
            this.button_dodaj.Size = new System.Drawing.Size(75, 23);
            this.button_dodaj.TabIndex = 0;
            this.button_dodaj.Text = "Dodaj";
            this.button_dodaj.UseVisualStyleBackColor = true;
            this.button_dodaj.Click += new System.EventHandler(this.button_dodaj_Click);
            // 
            // textbox_typ
            // 
            this.textbox_typ.Location = new System.Drawing.Point(35, 48);
            this.textbox_typ.Name = "textbox_typ";
            this.textbox_typ.Size = new System.Drawing.Size(207, 20);
            this.textbox_typ.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Typ produktu";
            // 
            // DodajTypProduktu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 131);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textbox_typ);
            this.Controls.Add(this.button_dodaj);
            this.Name = "DodajTypProduktu";
            this.Text = "Dodaj typ produktu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_dodaj;
        private System.Windows.Forms.TextBox textbox_typ;
        private System.Windows.Forms.Label label1;
    }
}