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
    public partial class StaffPage : Form
    {
        public StaffPage()
        {
            InitializeComponent();
        }

        private void StaffPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void FlightDetailsButton_Click(object sender, EventArgs e)
        {
            if (FlightListBox.SelectedItem != null)
            {
                new DetailsPage("flight", FlightListBox.SelectedItem).Show();
            }
        }

        private void StaffPage_Load(object sender, EventArgs e)
        {
            //TODO: Load StaffPage ListBoxes
        }

        private void PassengerDetailsButton_Click(object sender, EventArgs e)
        {
            if (PassengerListBox.SelectedItem != null)
            {
                new DetailsPage("passenger", FlightListBox.SelectedItem).Show();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
