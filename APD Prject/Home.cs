using System;
using System.Windows.Forms;

namespace APD_Prject
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            MgStaff mgStaff = new MgStaff();
            mgStaff.Show();

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Close();
            MgCustomer mgCustomer = new MgCustomer();
            mgCustomer.Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
            MgStore mgStore = new MgStore();
            mgStore.Show();
        }
    }
}
