namespace Zadatak
{
    partial class frmProizvodjac
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
            this.cmdPrikaziPodatke = new System.Windows.Forms.Button();
            this.Mreza = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.cmdDodaj = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtMaticniBroj = new System.Windows.Forms.TextBox();
            this.txtBrojRadnika = new System.Windows.Forms.TextBox();
            this.txtBudzet = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNaseljeID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProizvodjacID = new System.Windows.Forms.TextBox();
            this.txtBrisi = new System.Windows.Forms.TextBox();
            this.cmdBrisi = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cmdAzuriraj = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNazivA = new System.Windows.Forms.TextBox();
            this.txtBrojRadnikaA = new System.Windows.Forms.TextBox();
            this.txtBudzetA = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBudzetGornji = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBudzetDonji = new System.Windows.Forms.TextBox();
            this.cmdLista = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Mreza)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdPrikaziPodatke
            // 
            this.cmdPrikaziPodatke.BackColor = System.Drawing.Color.Red;
            this.cmdPrikaziPodatke.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPrikaziPodatke.Location = new System.Drawing.Point(12, 12);
            this.cmdPrikaziPodatke.Name = "cmdPrikaziPodatke";
            this.cmdPrikaziPodatke.Size = new System.Drawing.Size(94, 36);
            this.cmdPrikaziPodatke.TabIndex = 0;
            this.cmdPrikaziPodatke.Text = "PRIKAZI";
            this.cmdPrikaziPodatke.UseVisualStyleBackColor = false;
            this.cmdPrikaziPodatke.Click += new System.EventHandler(this.cmdPrikaziPodatke_Click);
            // 
            // Mreza
            // 
            this.Mreza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Mreza.Location = new System.Drawing.Point(12, 309);
            this.Mreza.Name = "Mreza";
            this.Mreza.Size = new System.Drawing.Size(824, 247);
            this.Mreza.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Redni broj:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(203, 36);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(100, 20);
            this.txtNaziv.TabIndex = 3;
            // 
            // cmdDodaj
            // 
            this.cmdDodaj.BackColor = System.Drawing.Color.Red;
            this.cmdDodaj.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDodaj.Location = new System.Drawing.Point(161, 241);
            this.cmdDodaj.Name = "cmdDodaj";
            this.cmdDodaj.Size = new System.Drawing.Size(86, 33);
            this.cmdDodaj.TabIndex = 4;
            this.cmdDodaj.Text = "DODAJ";
            this.cmdDodaj.UseVisualStyleBackColor = false;
            this.cmdDodaj.Click += new System.EventHandler(this.cmdDodaj_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Naziv:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Adresa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Maticni broj:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(129, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Broj radnika:";
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(203, 69);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(100, 20);
            this.txtAdresa.TabIndex = 9;
            // 
            // txtMaticniBroj
            // 
            this.txtMaticniBroj.Location = new System.Drawing.Point(203, 102);
            this.txtMaticniBroj.Name = "txtMaticniBroj";
            this.txtMaticniBroj.Size = new System.Drawing.Size(100, 20);
            this.txtMaticniBroj.TabIndex = 10;
            // 
            // txtBrojRadnika
            // 
            this.txtBrojRadnika.Location = new System.Drawing.Point(203, 135);
            this.txtBrojRadnika.Name = "txtBrojRadnika";
            this.txtBrojRadnika.Size = new System.Drawing.Size(100, 20);
            this.txtBrojRadnika.TabIndex = 11;
            // 
            // txtBudzet
            // 
            this.txtBudzet.Location = new System.Drawing.Point(203, 168);
            this.txtBudzet.Name = "txtBudzet";
            this.txtBudzet.Size = new System.Drawing.Size(100, 20);
            this.txtBudzet.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(152, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Budzet:";
            // 
            // txtNaseljeID
            // 
            this.txtNaseljeID.Location = new System.Drawing.Point(203, 202);
            this.txtNaseljeID.Name = "txtNaseljeID";
            this.txtNaseljeID.Size = new System.Drawing.Size(100, 20);
            this.txtNaseljeID.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(139, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "NaseljeID:";
            // 
            // txtProizvodjacID
            // 
            this.txtProizvodjacID.Location = new System.Drawing.Point(203, 6);
            this.txtProizvodjacID.Name = "txtProizvodjacID";
            this.txtProizvodjacID.Size = new System.Drawing.Size(100, 20);
            this.txtProizvodjacID.TabIndex = 16;
            // 
            // txtBrisi
            // 
            this.txtBrisi.Location = new System.Drawing.Point(358, 203);
            this.txtBrisi.Name = "txtBrisi";
            this.txtBrisi.Size = new System.Drawing.Size(100, 20);
            this.txtBrisi.TabIndex = 17;
            // 
            // cmdBrisi
            // 
            this.cmdBrisi.BackColor = System.Drawing.Color.Red;
            this.cmdBrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBrisi.Location = new System.Drawing.Point(358, 242);
            this.cmdBrisi.Name = "cmdBrisi";
            this.cmdBrisi.Size = new System.Drawing.Size(86, 30);
            this.cmdBrisi.TabIndex = 18;
            this.cmdBrisi.Text = "OBRISI";
            this.cmdBrisi.UseVisualStyleBackColor = false;
            this.cmdBrisi.Click += new System.EventHandler(this.cmdBrisi_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(355, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Maticni broj:";
            // 
            // cmdAzuriraj
            // 
            this.cmdAzuriraj.BackColor = System.Drawing.Color.Red;
            this.cmdAzuriraj.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAzuriraj.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmdAzuriraj.Location = new System.Drawing.Point(535, 237);
            this.cmdAzuriraj.Name = "cmdAzuriraj";
            this.cmdAzuriraj.Size = new System.Drawing.Size(115, 41);
            this.cmdAzuriraj.TabIndex = 20;
            this.cmdAzuriraj.Text = "AZURIRAJ";
            this.cmdAzuriraj.UseVisualStyleBackColor = false;
            this.cmdAzuriraj.Click += new System.EventHandler(this.cmdAzuriraj_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(532, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Naziv:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(532, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Broj radnika:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(532, 183);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Budzet:";
            // 
            // txtNazivA
            // 
            this.txtNazivA.Location = new System.Drawing.Point(535, 92);
            this.txtNazivA.Name = "txtNazivA";
            this.txtNazivA.Size = new System.Drawing.Size(100, 20);
            this.txtNazivA.TabIndex = 24;
            // 
            // txtBrojRadnikaA
            // 
            this.txtBrojRadnikaA.Location = new System.Drawing.Point(535, 142);
            this.txtBrojRadnikaA.Name = "txtBrojRadnikaA";
            this.txtBrojRadnikaA.Size = new System.Drawing.Size(100, 20);
            this.txtBrojRadnikaA.TabIndex = 25;
            // 
            // txtBudzetA
            // 
            this.txtBudzetA.Location = new System.Drawing.Point(535, 199);
            this.txtBudzetA.Name = "txtBudzetA";
            this.txtBudzetA.Size = new System.Drawing.Size(100, 20);
            this.txtBudzetA.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(714, 126);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Budzet - Gornji";
            // 
            // txtBudzetGornji
            // 
            this.txtBudzetGornji.Location = new System.Drawing.Point(717, 142);
            this.txtBudzetGornji.Name = "txtBudzetGornji";
            this.txtBudzetGornji.Size = new System.Drawing.Size(100, 20);
            this.txtBudzetGornji.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(714, 183);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Budzet - Donji";
            // 
            // txtBudzetDonji
            // 
            this.txtBudzetDonji.Location = new System.Drawing.Point(717, 199);
            this.txtBudzetDonji.Name = "txtBudzetDonji";
            this.txtBudzetDonji.Size = new System.Drawing.Size(100, 20);
            this.txtBudzetDonji.TabIndex = 30;
            // 
            // cmdLista
            // 
            this.cmdLista.BackColor = System.Drawing.Color.Red;
            this.cmdLista.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLista.Location = new System.Drawing.Point(720, 242);
            this.cmdLista.Name = "cmdLista";
            this.cmdLista.Size = new System.Drawing.Size(80, 30);
            this.cmdLista.TabIndex = 31;
            this.cmdLista.Text = "LISTA";
            this.cmdLista.UseVisualStyleBackColor = false;
            this.cmdLista.Click += new System.EventHandler(this.cmdLista_Click);
            // 
            // frmProizvodjac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 568);
            this.Controls.Add(this.cmdLista);
            this.Controls.Add(this.txtBudzetDonji);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtBudzetGornji);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtBudzetA);
            this.Controls.Add(this.txtBrojRadnikaA);
            this.Controls.Add(this.txtNazivA);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmdAzuriraj);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmdBrisi);
            this.Controls.Add(this.txtBrisi);
            this.Controls.Add(this.txtProizvodjacID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNaseljeID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBudzet);
            this.Controls.Add(this.txtBrojRadnika);
            this.Controls.Add(this.txtMaticniBroj);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmdDodaj);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Mreza);
            this.Controls.Add(this.cmdPrikaziPodatke);
            this.Name = "frmProizvodjac";
            this.Text = "Proizvodjac";
            ((System.ComponentModel.ISupportInitialize)(this.Mreza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdPrikaziPodatke;
        private System.Windows.Forms.DataGridView Mreza;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Button cmdDodaj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.TextBox txtMaticniBroj;
        private System.Windows.Forms.TextBox txtBrojRadnika;
        private System.Windows.Forms.TextBox txtBudzet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNaseljeID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProizvodjacID;
        private System.Windows.Forms.TextBox txtBrisi;
        private System.Windows.Forms.Button cmdBrisi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button cmdAzuriraj;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNazivA;
        private System.Windows.Forms.TextBox txtBrojRadnikaA;
        private System.Windows.Forms.TextBox txtBudzetA;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBudzetGornji;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtBudzetDonji;
        private System.Windows.Forms.Button cmdLista;
    }
}