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
    public partial class Quota : Form
    {
        public Quota()
        {
            InitializeComponent();
        }

        private void Quota_Load(object sender, EventArgs e)
        {
            DataSet dataSet = DAL.ViewQuota();
            dgvProduct.DataSource = dataSet.Tables["Quotas"];

        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            DataSet dataSet = DAL.ViewQuota();
            dgvProduct.DataSource = dataSet.Tables["Quotas"];
        }

        private void btnSearchFish_Click(object sender, EventArgs e)
        {
            if (txtSearchSpecies.Text != "")
            {
                DataSet dataSet = DAL.SearchQuota(txtSearchSpecies.Text);
                dgvProduct.DataSource = dataSet.Tables["Quotas"];
            }
            else
            {
                MessageBox.Show("Please Enter Species to Search!!!");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnManageSpecies_Click(object sender, EventArgs e)
        {

        }
    }
}
