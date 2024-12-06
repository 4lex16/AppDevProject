using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AirlineTicketsSystemGui.controller;
using AirlineTicketsSystemGui.model;

namespace AirlineTicketsSystemGui
{
    public partial class DetailsPage : Form
    {
        private string Type { get; set; }
        private Object Data { get; set; }
        public DetailsPage(string type, Object data)
        {
            Type = type;
            Data = data;
            InitializeComponent();
        }

        private void LoadData()
        {
            switch (Type) {
                case "flight":
                {
                    Flight flight = (Flight) Data;
                    AddRow("Flight :");
                    AddRow("Id", $"{flight.FlightId}");
                    AddRow("Destination", $"{flight.Destination}");
                    AddRow("Departure Date", $"{flight.DepartureDate}");
                    AddRow("Departure Time", $"{flight.DepartureTime}");
                    AddRow("Available Seats :");
                    AddRow("First Class", $"{flight.FirstClassSeats}");
                    AddRow("Business Class", $"{flight.BusinessClassSeats}");
                    AddRow("Coach Class", $"{flight.CoachClassSeats}");
                    break;
                }
                case "passenger":
                {
                    Passenger passenger = (Passenger) Data;
                    AddRow("Passenger");
                    AddRow("Id", $"{passenger.UserId}");
                    AddRow("Name", $"{passenger.Name}");
                    AddRow("Email", $"{passenger.Email}");
                    AddRow("Phone", $"{passenger.Phone}");
                    AddRow("Address", $"{passenger.Address}");
                    AddRow("Password", $"{passenger.Password}");
                    AddRow("Tickets");
                    foreach (Ticket ticket in passenger.Tickets)
                    {
                        AddRow("Ticket");
                        AddRow("Id", $"");
                    }

                    break;
                }
                case "tickets":
                {
                    Ticket ticket = (Ticket) Data;
                    AddRow("Ticket");
                    AddRow("Id", $"{ticket.TicketId}");
                    AddRow("Destination", $"{ticket.Flight.Destination}");
                    AddRow("Departure Date", $"{ticket.Flight.DepartureDate}");
                    AddRow("Departure Time", $"{ticket.Flight.DepartureTime}");
                    AddRow("Seat Type", $"{ticket.SeatType.ToString()}");
                    break;
                }
                case "staff":
                {
                    Staff staff = (Staff) Data;
                    AddRow("Staff");
                    AddRow("Id", $"{staff.UserId}");
                    AddRow("Email", $"{staff.Email}");
                    AddRow("Password", $"{staff.Password}");
                    break;
                }
                default:
                {
                    throw new Exception($"Cannot resolve {Type} in DetailsPage LoadData() switch case");
                }
            }
        }

        private void AddRow(string header, string content)
        {
            DetailsTb.Text += $"{(header + " : "), -40}  {content}\r\n";
        }
        private void AddRow(string header)
        {
            DetailsTb.Text += $"{header}\r\n";
        }

        private void DetailsPage_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AirlineTicketSystemController.AboutMb("About Display Details", "This is the page that displays the details of the specified");
        }
    }
}
