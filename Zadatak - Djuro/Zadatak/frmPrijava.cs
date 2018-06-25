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
    public partial class frmPrijava : Form
    {
        public frmPrijava()
        {
            InitializeComponent();
        }

        SqlConnection konekcija = new SqlConnection();

        private void cmdPrijava_Click(object sender, EventArgs e)
        {
            try
            {
                konekcija.ConnectionString = "Data Source = DESKTOP-UNGHEEV; Database = " + lstBaza.SelectedItem + "; User ID = " + txtKorisnik.Text + "; Password = " + txtLozinka.Text + " ";
                konekcija.Open();

                MessageBox.Show("Dobrodosli");

                konekcija.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Pokusajte ponovo");
            }

            this.Close();
        }
    }
}
