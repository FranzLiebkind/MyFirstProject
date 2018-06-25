namespace Zadatak
{
    partial class frmPrijava
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
            this.cmdPrijava = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKorisnik = new System.Windows.Forms.TextBox();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.lstBaza = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cmdPrijava
            // 
            this.cmdPrijava.Location = new System.Drawing.Point(43, 181);
            this.cmdPrijava.Name = "cmdPrijava";
            this.cmdPrijava.Size = new System.Drawing.Size(75, 23);
            this.cmdPrijava.TabIndex = 0;
            this.cmdPrijava.Text = "PRIJAVA";
            this.cmdPrijava.UseVisualStyleBackColor = true;
            this.cmdPrijava.Click += new System.EventHandler(this.cmdPrijava_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Korisnik:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lozinka:";
            // 
            // txtKorisnik
            // 
            this.txtKorisnik.Location = new System.Drawing.Point(115, 41);
            this.txtKorisnik.Name = "txtKorisnik";
            this.txtKorisnik.Size = new System.Drawing.Size(100, 20);
            this.txtKorisnik.TabIndex = 3;
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(115, 99);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.PasswordChar = '*';
            this.txtLozinka.Size = new System.Drawing.Size(100, 20);
            this.txtLozinka.TabIndex = 4;
            // 
            // lstBaza
            // 
            this.lstBaza.FormattingEnabled = true;
            this.lstBaza.Items.AddRange(new object[] {
            "BazaZnanja",
            "Veverica ",
            "Preduzece",
            "LokalnaBaza",
            "Organizacija"});
            this.lstBaza.Location = new System.Drawing.Point(378, 44);
            this.lstBaza.Name = "lstBaza";
            this.lstBaza.Size = new System.Drawing.Size(126, 160);
            this.lstBaza.TabIndex = 5;
            // 
            // frmPrijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 523);
            this.Controls.Add(this.lstBaza);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.txtKorisnik);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdPrijava);
            this.Name = "frmPrijava";
            this.Text = "Prijava";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdPrijava;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKorisnik;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.ListBox lstBaza;
    }
}

