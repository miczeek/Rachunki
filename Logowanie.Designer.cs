namespace Rachunki
{
    partial class Logowanie
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
            this.button_login = new System.Windows.Forms.Button();
            this.textbox_login = new System.Windows.Forms.TextBox();
            this.textbox_haslo = new System.Windows.Forms.TextBox();
            this.label_login = new System.Windows.Forms.Label();
            this.label_haslo = new System.Windows.Forms.Label();
            this.label_wynik = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(158, 134);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(129, 23);
            this.button_login.TabIndex = 0;
            this.button_login.Text = "Zaloguj";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // textbox_login
            // 
            this.textbox_login.Location = new System.Drawing.Point(23, 33);
            this.textbox_login.Name = "textbox_login";
            this.textbox_login.Size = new System.Drawing.Size(264, 20);
            this.textbox_login.TabIndex = 1;
            this.textbox_login.Text = "admin";
            // 
            // textbox_haslo
            // 
            this.textbox_haslo.Location = new System.Drawing.Point(23, 85);
            this.textbox_haslo.Name = "textbox_haslo";
            this.textbox_haslo.PasswordChar = '*';
            this.textbox_haslo.Size = new System.Drawing.Size(264, 20);
            this.textbox_haslo.TabIndex = 2;
            this.textbox_haslo.Text = "admin";
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Location = new System.Drawing.Point(20, 17);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(33, 13);
            this.label_login.TabIndex = 3;
            this.label_login.Text = "Login";
            // 
            // label_haslo
            // 
            this.label_haslo.AutoSize = true;
            this.label_haslo.Location = new System.Drawing.Point(20, 69);
            this.label_haslo.Name = "label_haslo";
            this.label_haslo.Size = new System.Drawing.Size(36, 13);
            this.label_haslo.TabIndex = 4;
            this.label_haslo.Text = "Hasło";
            // 
            // label_wynik
            // 
            this.label_wynik.AutoSize = true;
            this.label_wynik.Location = new System.Drawing.Point(20, 174);
            this.label_wynik.Name = "label_wynik";
            this.label_wynik.Size = new System.Drawing.Size(267, 13);
            this.label_wynik.TabIndex = 5;
            this.label_wynik.Text = "Jeżeli nie posiadasz konta - zgłoś się do administratora.";
            // 
            // Logowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 234);
            this.Controls.Add(this.label_wynik);
            this.Controls.Add(this.label_haslo);
            this.Controls.Add(this.label_login);
            this.Controls.Add(this.textbox_haslo);
            this.Controls.Add(this.textbox_login);
            this.Controls.Add(this.button_login);
            this.Name = "Logowanie";
            this.Text = "Logowanie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.TextBox textbox_login;
        private System.Windows.Forms.TextBox textbox_haslo;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Label label_haslo;
        private System.Windows.Forms.Label label_wynik;
    }
}