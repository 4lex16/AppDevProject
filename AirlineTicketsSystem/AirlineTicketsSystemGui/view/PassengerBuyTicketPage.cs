using System;
using System.Windows.Forms;
using AirlineTicketsSystemGui.model;

namespace AirlineTicketsSystemGui
{
    public partial class PassengerBuyTicketPage : Form
    {
        private Flight Flight { get; set; }

        public PassengerBuyTicketPage(Flight flight)
        {
            Flight = flight;
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            //TODO: Implement Buy Ticket Button Click
            //All it do is get information and create ticket assign it to passenger
        }

        private void PassengerBuyTicketPage_Load(object sender, EventArgs e)
        {
            //TODO: Implement Showing Flight Details
        }
    }
}