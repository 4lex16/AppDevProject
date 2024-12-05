using System;
using System.Windows.Forms;
using AirlineTicketsSystemGui.controller;

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
            if (AdminController.IsKey(AdminKeyTb.Text))
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
            AirlineTicketSystemController.AboutMb(
                "About Admin Login Page", 
                "This page is used to login as an admin using the key that will be known by the managers."
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
            AirlineTicketSystemController.NotImplementedMb();
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AirlineTicketSystemController.NotImplementedMb();
        }

        private void spanishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AirlineTicketSystemController.NotImplementedMb();
        }
    }
}