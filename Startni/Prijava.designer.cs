namespace Don
{
    partial class Prijava
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
            this.korisnicko = new System.Windows.Forms.Label();
            this.sifra = new System.Windows.Forms.Label();
            this.korisnickoText = new System.Windows.Forms.TextBox();
            this.potvrdi = new System.Windows.Forms.Button();
            this.sifraTekst = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // korisnicko
            // 
            this.korisnicko.AutoSize = true;
            this.korisnicko.Location = new System.Drawing.Point(12, 9);
            this.korisnicko.Name = "korisnicko";
            this.korisnicko.Size = new System.Drawing.Size(75, 13);
            this.korisnicko.TabIndex = 0;
            this.korisnicko.Text = "Korisničko ime";
            // 
            // sifra
            // 
            this.sifra.AutoSize = true;
            this.sifra.Location = new System.Drawing.Point(12, 35);
            this.sifra.Name = "sifra";
            this.sifra.Size = new System.Drawing.Size(28, 13);
            this.sifra.TabIndex = 1;
            this.sifra.Text = "Šifra";
            // 
            // korisnickoText
            // 
            this.korisnickoText.Location = new System.Drawing.Point(93, 6);
            this.korisnickoText.Name = "korisnickoText";
            this.korisnickoText.Size = new System.Drawing.Size(179, 20);
            this.korisnickoText.TabIndex = 0;
            this.korisnickoText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterClicked);
            // 
            // potvrdi
            // 
            this.potvrdi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.potvrdi.Location = new System.Drawing.Point(0, 66);
            this.potvrdi.Name = "potvrdi";
            this.potvrdi.Size = new System.Drawing.Size(284, 48);
            this.potvrdi.TabIndex = 2;
            this.potvrdi.Text = "Potvrdi";
            this.potvrdi.UseVisualStyleBackColor = true;
            this.potvrdi.Click += new System.EventHandler(this.potvrdi_Click);
            // 
            // sifraTekst
            // 
            this.sifraTekst.Location = new System.Drawing.Point(93, 32);
            this.sifraTekst.Name = "sifraTekst";
            this.sifraTekst.PasswordChar = '*';
            this.sifraTekst.Size = new System.Drawing.Size(179, 20);
            this.sifraTekst.TabIndex = 1;
            this.sifraTekst.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterClicked);
            // 
            // Prijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 114);
            this.Controls.Add(this.sifraTekst);
            this.Controls.Add(this.potvrdi);
            this.Controls.Add(this.korisnickoText);
            this.Controls.Add(this.sifra);
            this.Controls.Add(this.korisnicko);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Prijava";
            this.ShowInTaskbar = false;
            this.Text = "Prijava";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label korisnicko;
        private System.Windows.Forms.Label sifra;
        private System.Windows.Forms.TextBox korisnickoText;
        private System.Windows.Forms.Button potvrdi;
        private System.Windows.Forms.MaskedTextBox sifraTekst;
    }
}