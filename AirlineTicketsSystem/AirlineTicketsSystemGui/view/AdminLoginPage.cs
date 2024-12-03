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
            if (AdminKeyTb.Text == "12345678")
            {
                new AdminPage().Show();
                this.Hide();
            } else
            {
                MessageBox.Show("Invalid Admin Key");
            }
            
        }

        private void loginPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new LoginPage().Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}