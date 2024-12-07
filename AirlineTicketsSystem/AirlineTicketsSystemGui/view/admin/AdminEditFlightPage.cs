using System;
using System.Windows.Forms;
using AirlineTicketsSystemGui.controller;
using AirlineTicketsSystemGui.model;

namespace AirlineTicketsSystemGui
{
    public partial class AdminEditFlightPage : Form
    {
        private Flight Flight { get; set; }

        public AdminEditFlightPage(Flight flight)
        {
            Flight = flight;
            InitializeComponent();
        }

        // Admin Edit Flight Page Controls
        private void AdminEditFlightPage_Load(object sender, System.EventArgs e)
        {
            FlightIdTb.Text = Flight.FlightId.ToString();
            DestinationTb.Text = Flight.Destination;
            DateDp.Text = Flight.DepartureDate;
            FirstCTb.Text = Flight.FirstClassSeats.ToString();
            BusinessCTb.Text = Flight.BusinessClassSeats.ToString();
            CoachCTb.Text = Flight.CoachClassSeats.ToString();
        }

        private void EditButton_Click(object sender, System.EventArgs e)
        {
            string time = $"{HourNup.Text}:{MinuteNup.Text}";
            if (FlightIdTb.Text != null && FirstCTb.Text != null && BusinessCTb.Text != null && CoachCTb.Text != null && DestinationTb.Text != null && DateDp.Text != null)
            {
                AirlineTicketSystemController.UpdateFlight(int.Parse(FlightIdTb.Text), int.Parse(FirstCTb.Text), int.Parse(BusinessCTb.Text), int.Parse(CoachCTb.Text), DestinationTb.Text, DateDp.Text, time);
            }
            else
            {
                MessageBox.Show("No Field Can be Empty!");
            }
            this.Close();
        }

        private void CancelButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        // Tools Menu Controls
        private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AirlineTicketSystemController.AboutMb("About Edit Flight Page", 
                "This page is used to edit flights");
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("This will log you out " +
                                             "and restart the application",
                "Are you sure?",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (r == DialogResult.OK)
            {
                new LanguageController().UpdateConfig("language", "en");
                Application.Restart();
            }
        }

        private void frenchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("This will log you out " +
                                             "and restart the application",
                "Are you sure?",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (r == DialogResult.OK)
            {
                new LanguageController().UpdateConfig("language", "fr-CA");
                Application.Restart();
            }
        }
    }
}