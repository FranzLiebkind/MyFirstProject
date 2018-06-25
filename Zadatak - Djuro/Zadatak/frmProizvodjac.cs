using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Zadatak
{
    public partial class frmProizvodjac : Form
    {
        public frmProizvodjac()
        {
            InitializeComponent();
        }

        SqlConnection konekcija = new SqlConnection();
        SqlCommand cmdPrikazi = new SqlCommand();
        SqlDataAdapter daPrikazi = new SqlDataAdapter();
        DataTable dtPrikazi = new DataTable();

        private void OtvoriKonekciju()
        {
            konekcija.ConnectionString = "Data Source = DESKTOP-UNGHEEV; Database = BazaZnanja; Integrated Security = true";
            konekcija.Open();
        }

        private void PopuniMrezu()
        {
            OtvoriKonekciju();
            
            cmdPrikazi.Connection = konekcija;
            cmdPrikazi.CommandType = CommandType.Text;
            cmdPrikazi.CommandText = "select * from Proizvodjac";

            daPrikazi.SelectCommand = cmdPrikazi;
            daPrikazi.Fill(dtPrikazi);
            Mreza.DataSource = dtPrikazi;

            konekcija.Close();
        }

        private void OcistiMrezu()
        {
            dtPrikazi.Clear();
            Mreza.Refresh();
        }

        private void cmdPrikaziPodatke_Click(object sender, EventArgs e)
        {
            OtvoriKonekciju();

            OcistiMrezu();
            
            cmdPrikazi.Connection = konekcija;
            cmdPrikazi.CommandType = CommandType.Text;
            cmdPrikazi.CommandText = "select ProizvodjacID as 'Redni broj', Naziv, Adresa, MaticniBroj, BrojRadnika, Budzet, NazivNaselja from Proizvodjac left join Naselje on Proizvodjac.NaseljeID = Naselje.NaseljeID";

            daPrikazi.SelectCommand = cmdPrikazi;
            daPrikazi.Fill(dtPrikazi);
            Mreza.DataSource = dtPrikazi;

            konekcija.Close();
        }

        private void cmdDodaj_Click(object sender, EventArgs e)
        {
            SqlCommand cmdDodaj = new SqlCommand();
            
            OtvoriKonekciju();

            OcistiMrezu();
           
            cmdDodaj.Connection = konekcija;
            cmdDodaj.CommandType = CommandType.Text;
            cmdDodaj.CommandText = "declare @id int set @id = (select max(ProizvodjacID) + 1 from Proizvodjac) insert into Proizvodjac values(@id, '" + txtNaziv.Text + "', '" + txtAdresa.Text + "', " + txtMaticniBroj.Text + ", " + txtBrojRadnika.Text + ", " + txtBudzet.Text + ", " + txtNaseljeID.Text + ")";

            cmdDodaj.ExecuteNonQuery();
            
            konekcija.Close();
            

            PopuniMrezu();
        }

        private void cmdBrisi_Click(object sender, EventArgs e)
        {
            SqlCommand cmdBrisi = new SqlCommand();

            OtvoriKonekciju();

            OcistiMrezu();
            
            cmdBrisi.Connection = konekcija;
            cmdBrisi.CommandText = "select * from Proizvodjac delete Proizvodjac where MaticniBroj = (" + txtBrisi.Text + ")";

            cmdBrisi.ExecuteNonQuery();
            konekcija.Close();

            PopuniMrezu();
        }

        private void cmdAzuriraj_Click(object sender, EventArgs e)
        {
            SqlCommand cmdAzuriraj = new SqlCommand();
          
            OtvoriKonekciju();

            OcistiMrezu();

            cmdAzuriraj.Connection = konekcija;
            cmdAzuriraj.CommandText = "update Proizvodjac set BrojRadnika = " + txtBrojRadnikaA.Text + ", Budzet = " + txtBudzetA.Text + " where Naziv like '" + txtNazivA.Text + "'";
            cmdAzuriraj.ExecuteNonQuery();

            konekcija.Close();

            PopuniMrezu();
        }

        private void cmdLista_Click(object sender, EventArgs e)
        {
            SqlCommand cmdLista = new SqlCommand();
            SqlDataAdapter daLista = new SqlDataAdapter();
            DataTable dtLista = new DataTable();
            OtvoriKonekciju();

            OcistiMrezu();

            cmdLista.Connection = konekcija;
            cmdLista.CommandType = CommandType.Text;
            cmdLista.CommandText = "select* from Proizvodjac where Budzet between " + txtBudzetDonji.Text + " and " + txtBudzetGornji.Text + "";
            // skratio sam kod u odnosu na uvezeni iz SQL-a jer radi i tako
            daLista.SelectCommand = cmdLista;
            daLista.Fill(dtLista);
            Mreza.DataSource = dtLista;

            konekcija.Close();
        }
    }
}
