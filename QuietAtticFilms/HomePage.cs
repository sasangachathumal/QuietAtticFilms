using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuietAtticFilms
{
    public partial class HomePage : Form
    {
        public Form? loginPage { get; set; }
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void lblClient_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.homePage = this;
            client.Show();
            this.Hide();
        }

        private void lblProduction_Click(object sender, EventArgs e)
        {
            Production production = new Production();
            production.homePage = this;
            production.Show();
            this.Hide();
        }

        private void lblStaff_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff();
            staff.homePage = this;
            staff.Show();
            this.Hide();
        }

        private void lblLocation_Click(object sender, EventArgs e)
        {
            Location location = new Location();
            location.homePage = this;
            location.Show();
            this.Hide();
        }

        private void lblProperty_Click(object sender, EventArgs e)
        {
            Property property = new Property();
            property.homePage = this;
            property.Show();
            this.Hide();
        }

        private void lblPayment_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment();
            payment.homePage = this;
            payment.Show();
            this.Hide();
        }

        private void lblUser_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.homePage = this;
            user.Show();
            this.Hide();
        }

        private void lblSettings_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.homePage = this;
            settings.Show();
            this.Hide();
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            DialogResult resEx = MessageBox.Show("Are you sure, You want to Logout?",
                "Confirm to Logout!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resEx == DialogResult.Yes)
            {
                this.Close();
                loginPage?.Show();
            }
        }
    }
}
