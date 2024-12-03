using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineTicketsSystemGui
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void StaffLoginButton_Click(object sender, EventArgs e)
        {
            //TODO: Authenticate the user
            new StaffPage().Show();
            this.Hide();
        }

        private void PassengerLoginButton_Click(object sender, EventArgs e)
        {
            //TODO: Authenticate the user
            new PassengerPage().Show();
            this.Hide();
        }

        private void LoginPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void StaffAdminLabel_Click(object sender, EventArgs e)
        {
            new AdminLoginPage().Show();
            this.Hide();
        }

        private void PassengerSignupLabel_Click(object sender, EventArgs e)
        {
            new PassengerSignupPage().Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
