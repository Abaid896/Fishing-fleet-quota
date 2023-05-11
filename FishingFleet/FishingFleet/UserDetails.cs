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
    public partial class UserDetails : Form
    {
        public UserDetails()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserDetails_Load(object sender, EventArgs e)
        {
            if (frmLogin.Username == "")
            {
                MessageBox.Show("User Details Not Found!!!");
            }
            else
            {
                DataSet dataSet = DAL.SearchUser(frmLogin.Username);
                dgvUser.DataSource = dataSet.Tables["tblUSER"];
            }
        }
    }
}
