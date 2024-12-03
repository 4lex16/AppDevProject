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

        private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void AddButton_Click(object sender, System.EventArgs e)
        {

            // string email, string password
            AirlineTicketSystemController.InsertStaff(EmailTb.Text, PasswordTb.Text);
        }
    }
}