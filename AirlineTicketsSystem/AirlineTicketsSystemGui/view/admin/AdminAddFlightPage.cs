using AirlineTicketsSystemGui.controller;
using System;
using System.Windows.Forms;

namespace AirlineTicketsSystemGui
{
    public partial class AdminAddFlightPage : Form
    {
        public AdminAddFlightPage()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void DestinationLabel_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string time = HourNup.TabIndex.ToString() + ":" + MinuteNup.TabIndex.ToString() + ":" + AmPmCb.Text;
            //int firstClassSeats, int businessClassSeats, int coachClassSeats, string destination, string departureDate, string departureTime
            AirlineTicketSystemController.InsertFlight(int.Parse(FirstCTb.Text), int.Parse(BusinessCTb.Text), int.Parse(CoachCTb.Text), DestinationTb.Text, DateDp.Text, time);
        }
    }
}