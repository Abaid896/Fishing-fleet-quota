using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FishingFleet
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnManageFish_Click(object sender, EventArgs e)
        {
            //FishDetails fishDetails = new FishDetails();
            //fishDetails.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BoatDetails boatDetails = new BoatDetails();
            boatDetails.Show();
        }

        private void btnQuota_Click(object sender, EventArgs e)
        {
            Quota quota = new Quota();
            quota.Show();
        }

        private void btnCatches_Click(object sender, EventArgs e)
        {
            CatchesDetails catchesDetails = new CatchesDetails();
            catchesDetails.Show();
        }

        private void btnQuotaReport_Click(object sender, EventArgs e)
        {
            QuotaReport quotaReport = new QuotaReport();
            quotaReport.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString();
            lblUserName.Text = frmLogin.Username;

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            UserMenu userMenu = new UserMenu();
            userMenu.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(OpenLoginForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            this.Close();
        }
        private void OpenLoginForm()
        {
            Application.Run(new frmLogin());
        }

    }
}
