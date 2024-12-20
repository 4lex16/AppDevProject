﻿ using System;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace AirlineTicketsSystemGui
{
    public partial class StaffPage : Form
    {
        AirlineTicketSystem airlineTicketSystem = AirlineTicketSystem.GetInstance();
        private List<Flight> flights;
        private List<Passenger> passengers;
        public static Staff Staff { get; set; }
        public StaffPage(Staff staff)
        {
            Staff = staff;
            InitializeComponent();
        }

        public StaffPage(Staff staff, List<Flight> flight, List<Passenger> passenger)
        {
            Staff = staff;
            InitializeComponent();
            flights = flight;
            passengers = passenger;
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
            flights = airlineTicketSystem.Flights;
            passengers = airlineTicketSystem.Passengers;
            FlightListBox.Items.AddRange(flights.ToArray());
            PassengerListBox.Items.AddRange(passengers.ToArray());
        }

        private void PassengerDetailsButton_Click(object sender, EventArgs e)
        {
            if (PassengerListBox.SelectedItem != null)
            {
                new DetailsPage("passenger", PassengerListBox.SelectedItem).Show();
            }
            else if (FlightListBox.SelectedItems != null)
            {
                new DetailsPage("flight", FlightListBox.SelectedItem).Show();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This page is to view all the flights and passengers");
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new LoginPage().Show();
            this.Hide();
        }

        private void PassengerIdTB_TextChanged(object sender, EventArgs e)
        {
            if (!PassengerIdTB.Text.Equals(""))
            {
                int passengerId = int.Parse(PassengerIdTB.Text);
                PassengerListBox.Items.Clear();

                for (int i = 0; i < airlineTicketSystem.Passengers.Count; i++)
                {
                    if (airlineTicketSystem.Passengers[i].UserId.ToString().StartsWith(passengerId.ToString()))
                    {
                        PassengerListBox.Items.Add(airlineTicketSystem.Passengers[i].ToString());
                        break;
                    }
                }
            }
            else
            {
                PassengerListBox.Items.AddRange(passengers.ToArray());
            }
        }

        private void PassengerIdButton_Click(object sender, EventArgs e)
        {
            var orderPassenger = passengers.OrderBy(passenger => passenger.UserId).ToList();
            PassengerListBox.Items.Clear();
            PassengerListBox.Items.AddRange(orderPassenger.ToArray());
        }

        private void PassengerUsernameButton_Click(object sender, EventArgs e)
        {
            var orderPassenger = passengers.OrderBy(passenger => passenger.Name).ToList();
            PassengerListBox.Items.Clear();
            PassengerListBox.Items.AddRange(orderPassenger.ToArray());
        }

        private void PassengerUsernameTB_TextChanged(object sender, EventArgs e)
        {
            if (!PassengerUsernameTB.Text.Equals(""))
            {
                string passengerName = PassengerUsernameTB.Text;
                PassengerListBox.Items.Clear();

                for (int i = 0; i < airlineTicketSystem.Passengers.Count; i++)
                {
                    if (airlineTicketSystem.Passengers[i].Name.ToLower().StartsWith(passengerName.ToLower()))
                    {
                        PassengerListBox.Items.Add(airlineTicketSystem.Passengers[i].ToString());
                        break;
                    }
                }
            }
            else
            {
                PassengerListBox.Items.AddRange(passengers.ToArray());
            }
        }

        private void FlightIdButton_Click(object sender, EventArgs e)
        {
            var orderFlight = flights.OrderBy(flight => flight.FlightId).ToList();

            new StaffPage(Staff, orderFlight, passengers).Show();
            this.Hide();
        }

        private void FlightDestinationButton_Click(object sender, EventArgs e)
        {
            var orderFlight = flights.OrderBy(flight => flight.Destination).ToList();

            new StaffPage(Staff, orderFlight, passengers).Show();
            this.Hide();
        }

        private void FlightIdTB_TextChanged(object sender, EventArgs e)
        {
            if (!FlightIdTB.Text.Equals(""))
            {
                int flightId = int.Parse(FlightIdTB.Text);
                FlightListBox.Items.Clear();

                for (int i = 0; i < airlineTicketSystem.Flights.Count; i++)
                {
                    if (airlineTicketSystem.Flights[i].FlightId.ToString().StartsWith(flightId.ToString()))
                    {
                        FlightListBox.Items.Add(airlineTicketSystem.Flights[i]);
                        break;
                    }
                }
            } 
            else
            {
                FlightListBox.Items.AddRange(flights.ToArray());
            }
            
        }

        private void FlightDestinationTB_TextChanged(object sender, EventArgs e)
        {
            if (!FlightDestinationTB.Text.Equals(""))
            {
                string flightDestination = FlightDestinationButton.Text;
                FlightListBox.Items.Clear();

                for (int i = 0; i < airlineTicketSystem.Flights.Count; i++)
                {
                    if (airlineTicketSystem.Flights[i].Destination.ToLower().StartsWith(flightDestination.ToLower()))
                    {
                        FlightListBox.Items.Add(airlineTicketSystem.Flights[i].ToString());
                        break;
                    }
                }
            } 
            else
            {
                FlightListBox.Items.AddRange(flights.ToArray());
            }
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
