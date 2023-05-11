using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FishingFleet
{
    public partial class BoatsModule : Form
    {
        public BoatsModule()
        {
            InitializeComponent();
        }

        public bool NotNullFields()
        {
            if (txtBoatId.Text == "")
            {
                MessageBox.Show("Please Enter Boat Id!!!");
                return false;
            }

            else if (txtName.Text == "")
            {
                MessageBox.Show("Please Enter Boat Name!!!");
                return false;
            }
            else if (txtLicenseNo.Text == "")
            {
                MessageBox.Show("Please Enter License Number!!!");
                return false;
            }
            else if (txtMaxLoadSize.Text == "")
            {
                MessageBox.Show("Please Enter a Maximum Load Size!!!");
                return false;
            }
            else if (cmbSpecies1.Text == "" || cmbSpecies1.Text == "   select species")
            {
                MessageBox.Show("Please Select the Fish Species!!!");
                return false;
            }
            else if (cmbSpecies2.Text == "" || cmbSpecies2.Text == "   select species")
            {
                MessageBox.Show("Please Select the Fish Species!!!");
                return false;
            }
            return true;
        }
        private bool ValidateLicenseNumber()
        {
            string pattern = "^[A-Za-z]{1,2}\\s*[0-9]{1,3}$"; 

            if (!Regex.IsMatch(txtLicenseNo.Text, pattern))
            {
                MessageBox.Show("License No must follow the format: L XX, L XXX, LL XX or LL XXX \nHere, L is a letter and X is a number.", "Invalid license number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLicenseNo.Focus();
                return false;
            }

            return true;
        }
        private bool ValidateMaxLoadSize()
        {
            try
            {
                double maxWeight = double.Parse(txtMaxLoadSize.Text);
                return true;
            }
            catch 
            {
                MessageBox.Show("Maximum Weight Accepts Only Digits!!!", "Invalid Input");
                return false;
            }
        }

        private void lblEmployeeModule_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbSpecies3.Text == "   select species")
            {
                cmbSpecies3.Text = "";
            }
            if (cmbSpecies4.Text == "   select species")
            {
                cmbSpecies4.Text = "";
            }

            if (NotNullFields())
            {
                if (ValidateLicenseNumber())
                {
                    if (ValidateMaxLoadSize())
                    {
                        DAL.AddBoat(txtBoatId.Text, txtName.Text, txtLicenseNo.Text, txtMaxLoadSize.Text, cmbSpecies1.Text, cmbSpecies2.Text, cmbSpecies3.Text, cmbSpecies4.Text);
                        this.Close();
                    }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearchBoats_Click(object sender, EventArgs e)
        {
            if (txtSearchBoats.Text != "")
            {
                DataSet dataSet = DAL.SearchBoat(txtSearchBoats.Text);
                dgvSearchEmployee.DataSource = dataSet.Tables["Boats"];
            }
            else
            {
                MessageBox.Show("Please Enter Boat Id to Search!!!");
            }    
        }

        private void BoatsModule_Load(object sender, EventArgs e)
        {
            string viewSpeciesQuery = "SELECT * FROM Quotas";
            SqlConnection connection = DAL.ConnectToDatabase();
            SqlCommand command = new SqlCommand(viewSpeciesQuery, connection);
            command.ExecuteNonQuery();
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dataTable);
            foreach (DataRow dr in dataTable.Rows)
            {
                cmbSpecies1.Items.Add(dr["Species"].ToString());
                cmbSpecies2.Items.Add(dr["Species"].ToString());
                cmbSpecies3.Items.Add(dr["Species"].ToString());
                cmbSpecies4.Items.Add(dr["Species"].ToString());
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (NotNullFields())
            {
                DAL.UpdateBoat(txtBoatId.Text, txtName.Text, txtLicenseNo.Text, txtMaxLoadSize.Text, cmbSpecies1.Text, cmbSpecies2.Text, cmbSpecies3.Text, cmbSpecies4.Text);
                this.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(txtBoatId.Text != "")
            {
                DAL.DeleteBoat(txtBoatId.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("Please Enter Boat Id to Delete!!!");
            }
        }

        private void cmbSpecies1Id_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Removed
        }

        private void cmbSpecies2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = cmbSpecies2.Text;
            cmbSpecies1.Items.Remove(selectedValue);
            cmbSpecies3.Items.Remove(selectedValue);
            cmbSpecies4.Items.Remove(selectedValue);
        }

        private void cmbSpecies3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = cmbSpecies3.Text;
            cmbSpecies1.Items.Remove(selectedValue);
            cmbSpecies2.Items.Remove(selectedValue);
            cmbSpecies4.Items.Remove(selectedValue);
        }

        private void cmbSpecies4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = cmbSpecies4.Text;
            cmbSpecies1.Items.Remove(selectedValue);
            cmbSpecies2.Items.Remove(selectedValue);
            cmbSpecies3.Items.Remove(selectedValue);
        }

        private void cmbSpecies1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string selectedValue = cmbSpecies1.Text;
            cmbSpecies2.Items.Remove(selectedValue);
            cmbSpecies3.Items.Remove(selectedValue);
            cmbSpecies4.Items.Remove(selectedValue);
        }
    }
}
