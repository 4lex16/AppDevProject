using System;
using System.Windows.Forms;
using AirlineTicketsSystemGui.controller;
using AirlineTicketsSystemGui.model;

namespace AirlineTicketsSystemGui
{
    public partial class AdminEditStaffPage : Form
    {
        private Staff Staff { get; set; }
        public AdminEditStaffPage(Staff staff)
        {
            Staff = staff;
            InitializeComponent();
        }

        private void AdminEditStaffPage_Load(object sender, EventArgs e)
        {
            StaffIDTb.Text = Staff.Email;
            NewStaffEmailTb.Text = Staff.Password;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (StaffIDTb.Text != null && NewStaffPasswordTb.Text != null && NewStaffEmailTb.Text != null) 
            {
                DatabaseController.UpdateStaffRecord(int.Parse(StaffIDTb.Text), NewStaffEmailTb.Text, NewStaffPasswordTb.Text);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Menu Tool Bar Controls
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AirlineTicketSystemController.AboutMb("About Staff Edit Page", 
                "This page is where the admin can edit a staff member's information.");
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AirlineTicketSystemController.NotImplementedMb();
        }

        private void frenchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AirlineTicketSystemController.NotImplementedMb();
        }

        private void spanishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AirlineTicketSystemController.NotImplementedMb();
        }
    }
}