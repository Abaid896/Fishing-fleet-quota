using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FishingFleet
{
    public partial class Catches : Form
    {
        public Catches()
        {
            InitializeComponent();
        }
        public bool NotNullFields()
        {
            if (cmbBoatId.Text == "" || cmbBoatId.Text == "   select boat")
            {
                MessageBox.Show("Please Select a Boat Id!!!");
                return false;
            }

            else if (cmbSpecies.Text == "" || cmbSpecies.Text == "   select species")
            {
                MessageBox.Show("Please Select Species!!!");
                return false;
            }
            else if (txtWeight.Text == "")
            {
                MessageBox.Show("Please Enter the Weight!!!");
                return false;
            }
            else if (dateCatch.Text == "")
            {
                MessageBox.Show("Please Select Date and Time!!!");
                return false;
            }
            return true;
        }

        private bool ValidateWeight()
        {
            try
            {
                double maxWeight = double.Parse(txtWeight.Text);
                return true;
            }
            catch
            {
                MessageBox.Show("Weight Accepts Only Digits!!!", "Invalid Input");
                return false;
            }
        }
        private void Catches_Load(object sender, EventArgs e)
        {
            string viewBoatQuery = "SELECT * FROM Boats";
            SqlConnection connection = DAL.ConnectToDatabase();
            SqlCommand command = new SqlCommand(viewBoatQuery, connection);
            command.ExecuteNonQuery();
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dataTable);
            foreach (DataRow dr in dataTable.Rows)
            {
                cmbBoatId.Items.Add(dr["Boat_Id"].ToString());
            }
            
        }

        private void btnSearchBoats_Click(object sender, EventArgs e)
        {
            if (txtSearchBoats.Text != "")
            {
                DataSet dataSet = DAL.SearchBoatInCatches(txtSearchBoats.Text);
                dgvSearchEmployee.DataSource = dataSet.Tables["Catches"];
            }
            else
            {
                MessageBox.Show("Please Enter Boat Id to Search!!!");
            }
        }

        private void btnSearchSpecies_Click(object sender, EventArgs e)
        {
            if (txtSpeciesS.Text != "")
            {
                DataSet dataSet = DAL.SearchSpeciesInCatches(txtSpeciesS.Text);
                dgvSearchEmployee.DataSource = dataSet.Tables["Catches"];
            }
            else
            {
                MessageBox.Show("Please Enter Species to Search!!!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (NotNullFields())
            {
                DAL.UpdateCatches(cmbBoatId.Text, cmbSpecies.Text, txtWeight.Text, dateCatch.Value.ToString("dd-MM-yyyy HH:mm:ss"));
                this.Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (NotNullFields())
            {
                if (ValidateWeight())
                {
                    DAL.AddCatches(cmbBoatId.Text, cmbSpecies.Text, txtWeight.Text, dateCatch.Value.ToString("dd-MM-yyyy HH:mm:ss"));
                    this.Close();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbSpecies_SelectedIndexChanged(object sender, EventArgs e)
        {
                        
        }

        private void cmbBoatId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBoatId.SelectedItem != null)
            {
                cmbSpecies.Items.Clear();
                string boatId = cmbBoatId.SelectedItem.ToString();
                string viewSpeciesQuery = "SELECT * FROM Boats Where Boat_Id = @boatId";
                SqlConnection connection1 = DAL.ConnectToDatabase();
                SqlCommand command1 = new SqlCommand(viewSpeciesQuery, connection1);
                command1.Parameters.AddWithValue("@boatId", boatId);
                command1.ExecuteNonQuery();
                DataTable dataTable1 = new DataTable();
                SqlDataAdapter adapter1 = new SqlDataAdapter(command1);
                adapter1.Fill(dataTable1);
                foreach (DataRow dr in dataTable1.Rows)
                {
                    cmbSpecies.Items.Add(dr["Species1"].ToString());
                    cmbSpecies.Items.Add(dr["Species2"].ToString());
                    cmbSpecies.Items.Add(dr["Species3"].ToString());
                    cmbSpecies.Items.Add(dr["Species4"].ToString());
                }
            }
            else
            {
                MessageBox.Show("First Select a Boat Id!!!");
            }

        }
    }
}
