using System;
using System.Windows.Forms;

namespace AirlineTicketsSystemGui
{
    public partial class AdminLoginPage : Form
    {
        public AdminLoginPage()
        {
            InitializeComponent();
        }

        private void AdminLoginPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void AdminLoginButton_Click(object sender, EventArgs e)
        {
            //TODO: Authenticate the key
            new AdminPage().Show();
            this.Hide();
        }

        private void loginPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new LoginPage().Show();
            this.Hide();
        }
    }
}