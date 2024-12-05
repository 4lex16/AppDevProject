using AirlineTicketsSystemGui.controller;
using System.Windows.Forms;

namespace AirlineTicketsSystemGui
{
    public partial class AdminAddStaffPage : Form
    {
        public AdminAddStaffPage()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, System.EventArgs e)
        {
            string email = EmailTb.Text;
            string password = PasswordTb.Text;
            AirlineTicketSystemController.InsertStaff(EmailTb.Text, PasswordTb.Text);
            this.Close();
        }
        
        // Menu Tools Controls
        private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            AirlineTicketSystemController.AboutMb("About Add Staff Page", 
                "This page allows admins to add staff to the system.");
        }

        private void englishToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            AirlineTicketSystemController.NotImplementedMb();
        }

        private void frenchToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            AirlineTicketSystemController.NotImplementedMb();
        }

        private void spanishToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            AirlineTicketSystemController.NotImplementedMb();
        }
    }
}