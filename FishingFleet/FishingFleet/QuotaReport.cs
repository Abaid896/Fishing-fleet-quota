using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FishingFleet
{
    public partial class QuotaReport : Form
    {
        public QuotaReport()
        {
            InitializeComponent();
            dgvEmployee.RowPrePaint += dgvEmployee_RowPrePaint;
        }

        private void QuotaReport_Load(object sender, EventArgs e)
        {
            DAL dal = new DAL();
            DataSet dataSet = new DataSet();
            dataSet.Tables.Add(dal.ViewQuotaReport());
            dgvEmployee.DataSource = dataSet.Tables[0];
            rbtnkg.Checked = true;
        }

        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dgvEmployee_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (dgvEmployee.Rows[e.RowIndex].Cells["Status"].Value != null)
            {
                string status = dgvEmployee.Rows[e.RowIndex].Cells["Status"].Value.ToString();
                if (status == "Normal")
                {
                    dgvEmployee.Rows[e.RowIndex].Cells["Status"].Style.ForeColor = Color.Green;
                }
                else
                {
                    dgvEmployee.Rows[e.RowIndex].Cells["Status"].Style.ForeColor = Color.Red;
                }
            }
        }


        private void btnSearchSpecies_Click(object sender, EventArgs e)
        {
            string searchSpecies = txtSearchSpecies.Text.Trim();
            if (string.IsNullOrEmpty(searchSpecies))
            {
                MessageBox.Show("Please enter a species to search for.", "Search Error");
                return;
            }

            DAL dal = new DAL();
            DataTable table = dal.ViewQuotaReport();
            DataView dv = new DataView(table);
            dv.RowFilter = "Species = '" + searchSpecies + "'";
            if (dv.Count == 0)
            {
                MessageBox.Show("No results found for species '" + searchSpecies + "'.", "Search Results");
                return;
            }

            dgvEmployee.DataSource = dv.ToTable();
        }

        private void btnViewAllBoats_Click(object sender, EventArgs e)
        {
            DAL dal = new DAL();
            DataSet dataSet = new DataSet();
            dataSet.Tables.Add(dal.ViewQuotaReport());
            dgvEmployee.DataSource = dataSet.Tables[0];
        }

        private void rbtnTones_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnTones.Checked)
            {
                DAL dal = new DAL();
                DataSet dataSet = new DataSet();
                dataSet.Tables.Add(dal.ViewQuotaReportInTons());
                dgvEmployee.DataSource = dataSet.Tables[0];
                //// Loop through each row in the DataGridView
                //foreach (DataGridViewRow row in dgvEmployee.Rows)
                //{
                //    // Convert the catch_weight value from kg to tons
                //    double weightInKg = Convert.ToDouble(row.Cells["Total_Weight"].Value);
                //    double weightInTons = weightInKg / 1000;

                //    // Update the catch_weight value to tons
                //    row.Cells["Total_Weight"].Value = weightInTons;
                //}
            }
        }

        private void rbtnkg_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnkg.Checked)
            {
                DAL dal = new DAL();
                DataSet dataSet = new DataSet();
                dataSet.Tables.Add(dal.ViewQuotaReport());
                dgvEmployee.DataSource = dataSet.Tables[0];
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnManageBoat_Click(object sender, EventArgs e)
        {

        }
    }
}
