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

        // Tool Strip Menu Controls
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "This page is used to Login as an Admin using" +
                    " the key that will be known by the Managers",
                "About Admin Login Page", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information
            );
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

        private void frenchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO: Implement french Internalization -> AdminLoginPage.cs
            MessageBox.Show(
                "This Feature will be Implemented at a Later Date",
                "Sorry Feature Not Implemented", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information
            );
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO: Implement english Internalization -> AdminLoginPage.cs
            MessageBox.Show(
                "This Feature will be Implemented at a Later Date",
                "Sorry Feature Not Implemented", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information
            );
        }

        private void spanishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO: Implement spanish Internalization -> AdminLoginPage.cs
            MessageBox.Show(
                "This Feature will be Implemented at a Later Date",
                "Sorry Feature Not Implemented", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information
            );
        }
    }
}