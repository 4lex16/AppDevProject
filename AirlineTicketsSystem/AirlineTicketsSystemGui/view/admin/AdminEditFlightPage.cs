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
            DestinationTb.Text = Flight.Destination;
            DateDp.Text = Flight.DepartureDate;
            HourNup.Text = Flight.DepartureTime.Split(':')[0];
            MinuteNup.Text = Flight.DepartureTime.Split(':')[1];
            FirstCTb.Text = Flight.FirstClassSeats.ToString();
            BusinessCTb.Text = Flight.BusinessClassSeats.ToString();
            CoachCTb.Text = Flight.CoachClassSeats.ToString();
        }

        private void EditButton_Click(object sender, System.EventArgs e)
        {
            string destination = DestinationTb.Text;
            string date = DateDp.Text;
            string time = $"{HourNup.Text}:{MinuteNup.Text}";
            int fc = int.Parse(FirstCTb.Text);
            int bc = int.Parse(BusinessCTb.Text);
            int cc = int.Parse(CoachCTb.Text);
            //TODO: Implement this function in the controller
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