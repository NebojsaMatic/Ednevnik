namespace ednevnik
{
    partial class Osoba
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
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_ime = new System.Windows.Forms.TextBox();
            this.txt_prezime = new System.Windows.Forms.TextBox();
            this.txt_adresa = new System.Windows.Forms.TextBox();
            this.txt_jmbg = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_uloga = new System.Windows.Forms.TextBox();
            this.label_id = new System.Windows.Forms.Label();
            this.label_ime = new System.Windows.Forms.Label();
            this.label_prezime = new System.Windows.Forms.Label();
            this.label_adresa = new System.Windows.Forms.Label();
            this.label_jmbg = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.label_pass = new System.Windows.Forms.Label();
            this.label_uloga = new System.Windows.Forms.Label();
            this.button_prvi = new System.Windows.Forms.Button();
            this.button_prethodni = new System.Windows.Forms.Button();
            this.button_dodaj = new System.Windows.Forms.Button();
            this.button_izmeni = new System.Windows.Forms.Button();
            this.button_brisi = new System.Windows.Forms.Button();
            this.button_sledeci = new System.Windows.Forms.Button();
            this.button_poslednji = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(352, 98);
            this.txt_id.Multiline = true;
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(240, 20);
            this.txt_id.TabIndex = 0;
            // 
            // txt_ime
            // 
            this.txt_ime.Location = new System.Drawing.Point(352, 134);
            this.txt_ime.Multiline = true;
            this.txt_ime.Name = "txt_ime";
            this.txt_ime.Size = new System.Drawing.Size(240, 20);
            this.txt_ime.TabIndex = 1;
            // 
            // txt_prezime
            // 
            this.txt_prezime.Location = new System.Drawing.Point(352, 170);
            this.txt_prezime.Multiline = true;
            this.txt_prezime.Name = "txt_prezime";
            this.txt_prezime.Size = new System.Drawing.Size(240, 20);
            this.txt_prezime.TabIndex = 2;
            // 
            // txt_adresa
            // 
            this.txt_adresa.Location = new System.Drawing.Point(352, 206);
            this.txt_adresa.Multiline = true;
            this.txt_adresa.Name = "txt_adresa";
            this.txt_adresa.Size = new System.Drawing.Size(240, 20);
            this.txt_adresa.TabIndex = 3;
            // 
            // txt_jmbg
            // 
            this.txt_jmbg.Location = new System.Drawing.Point(352, 242);
            this.txt_jmbg.Multiline = true;
            this.txt_jmbg.Name = "txt_jmbg";
            this.txt_jmbg.Size = new System.Drawing.Size(240, 20);
            this.txt_jmbg.TabIndex = 4;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(352, 278);
            this.txt_email.Multiline = true;
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(240, 20);
            this.txt_email.TabIndex = 5;
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(352, 314);
            this.txt_pass.Multiline = true;
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(240, 20);
            this.txt_pass.TabIndex = 6;
            // 
            // txt_uloga
            // 
            this.txt_uloga.Location = new System.Drawing.Point(352, 350);
            this.txt_uloga.Multiline = true;
            this.txt_uloga.Name = "txt_uloga";
            this.txt_uloga.Size = new System.Drawing.Size(240, 20);
            this.txt_uloga.TabIndex = 7;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(278, 105);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(18, 13);
            this.label_id.TabIndex = 8;
            this.label_id.Text = "ID";
            // 
            // label_ime
            // 
            this.label_ime.AutoSize = true;
            this.label_ime.Location = new System.Drawing.Point(278, 141);
            this.label_ime.Name = "label_ime";
            this.label_ime.Size = new System.Drawing.Size(24, 13);
            this.label_ime.TabIndex = 9;
            this.label_ime.Text = "Ime";
            this.label_ime.Click += new System.EventHandler(this.label2_Click);
            // 
            // label_prezime
            // 
            this.label_prezime.AutoSize = true;
            this.label_prezime.Location = new System.Drawing.Point(278, 177);
            this.label_prezime.Name = "label_prezime";
            this.label_prezime.Size = new System.Drawing.Size(44, 13);
            this.label_prezime.TabIndex = 10;
            this.label_prezime.Text = "Prezime";
            // 
            // label_adresa
            // 
            this.label_adresa.AutoSize = true;
            this.label_adresa.Location = new System.Drawing.Point(278, 213);
            this.label_adresa.Name = "label_adresa";
            this.label_adresa.Size = new System.Drawing.Size(40, 13);
            this.label_adresa.TabIndex = 11;
            this.label_adresa.Text = "Adresa";
            // 
            // label_jmbg
            // 
            this.label_jmbg.AutoSize = true;
            this.label_jmbg.Location = new System.Drawing.Point(278, 249);
            this.label_jmbg.Name = "label_jmbg";
            this.label_jmbg.Size = new System.Drawing.Size(36, 13);
            this.label_jmbg.TabIndex = 12;
            this.label_jmbg.Text = "JMBG";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Location = new System.Drawing.Point(278, 285);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(32, 13);
            this.label_email.TabIndex = 13;
            this.label_email.Text = "Email";
            // 
            // label_pass
            // 
            this.label_pass.AutoSize = true;
            this.label_pass.Location = new System.Drawing.Point(278, 321);
            this.label_pass.Name = "label_pass";
            this.label_pass.Size = new System.Drawing.Size(53, 13);
            this.label_pass.TabIndex = 14;
            this.label_pass.Text = "Password";
            // 
            // label_uloga
            // 
            this.label_uloga.AutoSize = true;
            this.label_uloga.Location = new System.Drawing.Point(278, 357);
            this.label_uloga.Name = "label_uloga";
            this.label_uloga.Size = new System.Drawing.Size(35, 13);
            this.label_uloga.TabIndex = 15;
            this.label_uloga.Text = "Uloga";
            // 
            // button_prvi
            // 
            this.button_prvi.Location = new System.Drawing.Point(57, 438);
            this.button_prvi.Name = "button_prvi";
            this.button_prvi.Size = new System.Drawing.Size(75, 23);
            this.button_prvi.TabIndex = 16;
            this.button_prvi.Text = "<<";
            this.button_prvi.UseVisualStyleBackColor = true;
            this.button_prvi.Click += new System.EventHandler(this.button_prvi_Click);
            // 
            // button_prethodni
            // 
            this.button_prethodni.Location = new System.Drawing.Point(156, 438);
            this.button_prethodni.Name = "button_prethodni";
            this.button_prethodni.Size = new System.Drawing.Size(75, 23);
            this.button_prethodni.TabIndex = 17;
            this.button_prethodni.Text = "<";
            this.button_prethodni.UseVisualStyleBackColor = true;
            this.button_prethodni.Click += new System.EventHandler(this.button_prethodni_Click);
            // 
            // button_dodaj
            // 
            this.button_dodaj.Location = new System.Drawing.Point(258, 437);
            this.button_dodaj.Name = "button_dodaj";
            this.button_dodaj.Size = new System.Drawing.Size(75, 23);
            this.button_dodaj.TabIndex = 18;
            this.button_dodaj.Text = "Dodaj";
            this.button_dodaj.UseVisualStyleBackColor = true;
            this.button_dodaj.Click += new System.EventHandler(this.button_dodaj_Click);
            // 
            // button_izmeni
            // 
            this.button_izmeni.Location = new System.Drawing.Point(352, 437);
            this.button_izmeni.Name = "button_izmeni";
            this.button_izmeni.Size = new System.Drawing.Size(75, 23);
            this.button_izmeni.TabIndex = 19;
            this.button_izmeni.Text = "Izmeni";
            this.button_izmeni.UseVisualStyleBackColor = true;
            this.button_izmeni.Click += new System.EventHandler(this.button_izmeni_Click);
            // 
            // button_brisi
            // 
            this.button_brisi.Location = new System.Drawing.Point(443, 438);
            this.button_brisi.Name = "button_brisi";
            this.button_brisi.Size = new System.Drawing.Size(75, 23);
            this.button_brisi.TabIndex = 20;
            this.button_brisi.Text = "Brisi";
            this.button_brisi.UseVisualStyleBackColor = true;
            this.button_brisi.Click += new System.EventHandler(this.button_brisi_Click);
            // 
            // button_sledeci
            // 
            this.button_sledeci.Location = new System.Drawing.Point(537, 437);
            this.button_sledeci.Name = "button_sledeci";
            this.button_sledeci.Size = new System.Drawing.Size(75, 23);
            this.button_sledeci.TabIndex = 21;
            this.button_sledeci.Text = ">";
            this.button_sledeci.UseVisualStyleBackColor = true;
            this.button_sledeci.Click += new System.EventHandler(this.button_sledeci_Click);
            // 
            // button_poslednji
            // 
            this.button_poslednji.Location = new System.Drawing.Point(638, 437);
            this.button_poslednji.Name = "button_poslednji";
            this.button_poslednji.Size = new System.Drawing.Size(75, 23);
            this.button_poslednji.TabIndex = 22;
            this.button_poslednji.Text = ">>";
            this.button_poslednji.UseVisualStyleBackColor = true;
            this.button_poslednji.Click += new System.EventHandler(this.button_poslednji_Click);
            // 
            // Osoba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(839, 545);
            this.Controls.Add(this.button_poslednji);
            this.Controls.Add(this.button_sledeci);
            this.Controls.Add(this.button_brisi);
            this.Controls.Add(this.button_izmeni);
            this.Controls.Add(this.button_dodaj);
            this.Controls.Add(this.button_prethodni);
            this.Controls.Add(this.button_prvi);
            this.Controls.Add(this.label_uloga);
            this.Controls.Add(this.label_pass);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.label_jmbg);
            this.Controls.Add(this.label_adresa);
            this.Controls.Add(this.label_prezime);
            this.Controls.Add(this.label_ime);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.txt_uloga);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_jmbg);
            this.Controls.Add(this.txt_adresa);
            this.Controls.Add(this.txt_prezime);
            this.Controls.Add(this.txt_ime);
            this.Controls.Add(this.txt_id);
            this.Name = "Osoba";
            this.Text = "Osoba";
            this.Load += new System.EventHandler(this.Osoba_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_ime;
        private System.Windows.Forms.TextBox txt_prezime;
        private System.Windows.Forms.TextBox txt_adresa;
        private System.Windows.Forms.TextBox txt_jmbg;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_uloga;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_ime;
        private System.Windows.Forms.Label label_prezime;
        private System.Windows.Forms.Label label_adresa;
        private System.Windows.Forms.Label label_jmbg;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_pass;
        private System.Windows.Forms.Label label_uloga;
        private System.Windows.Forms.Button button_prvi;
        private System.Windows.Forms.Button button_prethodni;
        private System.Windows.Forms.Button button_dodaj;
        private System.Windows.Forms.Button button_izmeni;
        private System.Windows.Forms.Button button_brisi;
        private System.Windows.Forms.Button button_sledeci;
        private System.Windows.Forms.Button button_poslednji;
    }
}

