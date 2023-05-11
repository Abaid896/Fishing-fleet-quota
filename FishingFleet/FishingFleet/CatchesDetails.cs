using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FishingFleet
{
    public partial class CatchesDetails : Form
    {
        public CatchesDetails()
        {
            InitializeComponent();
        }

        private void btnManageBoat_Click(object sender, EventArgs e)
        {
            this.Close();
            Catches catches = new Catches();
            catches.Show();
        }

        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearchBoats_Click(object sender, EventArgs e)
        {
            if (txtSearchBoats.Text != "")
            {
                DataSet dataSet = DAL.SearchBoatInCatches(txtSearchBoats.Text);
                dgvEmployee.DataSource = dataSet.Tables["Catches"];
            }
            else
            {
                MessageBox.Show("Please Enter Boat Id to Search!!!");
            }
        }

        private void CatchesDetails_Load(object sender, EventArgs e)
        {
            DataSet dataSet = DAL.ViewCatches();
            dgvEmployee.DataSource = dataSet.Tables["Catches"];
        }

        private void btnSearchSpecies_Click(object sender, EventArgs e)
        {
            if (txtSpeciesS.Text != "")
            {
                DataSet dataSet = DAL.SearchSpeciesInCatches(txtSpeciesS.Text);
                dgvEmployee.DataSource = dataSet.Tables["Catches"];
            }
            else
            {
                MessageBox.Show("Please Enter Species to Search!!!");
            }
        }

        private void btnViewAllBoats_Click(object sender, EventArgs e)
        {
            DataSet dataSet = DAL.ViewCatches();
            dgvEmployee.DataSource = dataSet.Tables["Catches"];
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
