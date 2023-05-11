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
    public partial class BoatDetails : Form
    {
        public BoatDetails()
        {
            InitializeComponent();
        }

        private void btnAddBoat_Click(object sender, EventArgs e)
        {
            this.Close();
            BoatsModule boatModule = new BoatsModule();
            boatModule.Show();
        }

        private void btnViewAllBoats_Click(object sender, EventArgs e)
        {
            DataSet dataSet = DAL.ViewBoat();
            dgvEmployee.DataSource = dataSet.Tables["Boats"];
        }

        private void BoatDetails_Load(object sender, EventArgs e)
        {
            DataSet dataSet = DAL.ViewBoat();
            dgvEmployee.DataSource = dataSet.Tables["Boats"];
        }

        private void btnSearchBoat_Click(object sender, EventArgs e)
        {
            if (txtSearchBoat.Text != "")
            {
                DataSet dataSet = DAL.SearchBoat(txtSearchBoat.Text);
                dgvEmployee.DataSource = dataSet.Tables["Boats"];
            }
            else
            {
                MessageBox.Show("Please Enter Boat Id to Search!!!");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
