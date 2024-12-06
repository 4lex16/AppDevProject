using System;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using AirlineTicketsSystemGui.controller;
using AirlineTicketsSystemGui.model;

namespace AirlineTicketsSystemGui
{
    public partial class PassengerBuyTicketPage : Form
    {
        private Flight Flight { get; set; }
        private Passenger Passenger { get; set; }

        public PassengerBuyTicketPage(Flight flight, Passenger passenger)
        {
            Flight = flight;
            InitializeComponent();
            Passenger = passenger;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            //All it do is get information and create ticket assign it to passenger
            Ticket ticket = new Ticket(Passenger.Tickets.Count + 100, Flight, Passenger.UserId, (SeatType)SeatTypeCb.SelectedIndex);

            Passenger.Tickets.Add(ticket);
        }

        private void PassengerBuyTicketPage_Load(object sender, EventArgs e)
        {
           
            DestinationTb.Text = Flight.Destination;
            DateTb.Text = Flight.DepartureDate;
            TimeTb.Text = Flight.DepartureTime;
            FirstClassTb.Text = Flight.FirstClassSeats.ToString();
            BusinessClassTb.Text = Flight.BusinessClassSeats.ToString();
            CoachClassTb.Text = Flight.CoachClassSeats.ToString();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Make sure to input all the correct data please");
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