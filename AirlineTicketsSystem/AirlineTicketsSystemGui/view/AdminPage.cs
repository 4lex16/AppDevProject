using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AirlineTicketsSystemGui.model;

namespace AirlineTicketsSystemGui
{
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        private void AdminPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void StaffDetailsButton_Click(object sender, EventArgs e)
        {
            if (StaffListBox.SelectedItem != null)
            {
                new DetailsPage("staff", StaffListBox.SelectedItem).Show();
            }
        }

        private void FlightDetailsButton_Click(object sender, EventArgs e)
        {
            if (FlightListBox.SelectedItem != null)
            {
                new DetailsPage("flight", FlightListBox.SelectedItem).Show();
            }
        }

        private void FlightAddButton_Click(object sender, EventArgs e)
        {
            new AdminAddFlightPage().Show();
        }


        private void StaffAddButton_Click(object sender, EventArgs e)
        {
            new AdminAddStaffPage().Show();
        }

        private void StaffEditButton_Click(object sender, EventArgs e)
        {
            if (StaffListBox.SelectedItem != null)
            {
                new AdminAddStaffPage().Show();
            }
        }

        private void FlightEditButton_Click(object sender, EventArgs e)
        {
            if (StaffListBox.SelectedItem != null)
            {
                new AdminAddStaffPage().Show();
            }
        }
    }
}
