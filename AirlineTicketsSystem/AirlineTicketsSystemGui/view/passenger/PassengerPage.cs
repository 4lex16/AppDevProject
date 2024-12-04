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
    public partial class PassengerPage : Form
    {
        public PassengerPage()
        {
            InitializeComponent();
        }

        private void PassengerPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void PassengerPage_Load(object sender, EventArgs e)
        {
            //TODO: Fill passenger flight List Box
            //TODO: Fill passenger ticket List Box
        }

        private void TicketDetailsButton_Click(object sender, EventArgs e)
        {
            if (TicketListBox.SelectedItem != null)
            {
                new DetailsPage("ticket", TicketListBox.SelectedItem).Show();
            }
        }

        private void FlightDetailsButton_Click(object sender, EventArgs e)
        {
            if (FlightListBox.SelectedItem != null)
            {
                new DetailsPage("flight", FlightListBox.SelectedItem).Show();
            }
        }

        private void FlightBuyButton_Click(object sender, EventArgs e)
        {
            if (FlightListBox.SelectedItem != null)
            {
                new PassengerBuyTicketPage((Flight)FlightListBox.SelectedItem);
            }
        }

        private void TicketRefundButton_Click(object sender, EventArgs e)
        {
            //TODO: Implement Refund Ticket Button
        }

        private void TicketPrintButton_Click(object sender, EventArgs e)
        {
            //TODO: Implement Print Ticket Button
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
