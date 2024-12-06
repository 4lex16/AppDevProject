using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AirlineTicketsSystemGui.controller;
using AirlineTicketsSystemGui.model;

namespace AirlineTicketsSystemGui
{
    public partial class PassengerPage : Form
    {
        AirlineTicketSystem airlineTicketSystem = AirlineTicketSystem.GetInstance();
        private Passenger Passenger { get; set; }
        private List<Ticket> Tickets {  get; set; }
        private List<Flight> Flights { get; set; }
        public PassengerPage(Passenger passenger, List<Ticket> tickets)
        {
            Passenger = passenger;
            InitializeComponent();
            Tickets = tickets;
        }

        public PassengerPage(Passenger passenger, List<Ticket> tickets, List<Flight> flights)
        {
            Passenger = passenger;
            InitializeComponent();
            Tickets = tickets;
            Flights = flights;
        }

        private void PassengerPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void PassengerPage_Load(object sender, EventArgs e)
        {
            FlightListBox.Items.AddRange(airlineTicketSystem.Flights.ToArray());
            TicketListBox.Items.AddRange(Passenger.Tickets.ToArray());
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
                new PassengerBuyTicketPage((Flight)FlightListBox.SelectedItem, Passenger);
            }
        }

        private void TicketRefundButton_Click(object sender, EventArgs e)
        {
            //TODO: Implement Refund Ticket Button
            if (TicketListBox.SelectedItem != null)
            {
                Ticket ticket = (Ticket)TicketListBox.SelectedItem;

                for (int i = 0; i < Passenger.Tickets.Count; i++)
                {
                    if (Passenger.Tickets[i].TicketId == ticket.TicketId)
                    {
                        Passenger.Tickets.RemoveAt(i);
                        MessageBox.Show("Ticket refunded, the funds will arrive in 7-10 business days");
                        break;
                    }

                    new PassengerPage(Passenger, Passenger.Tickets);
                    this.Hide();
                }
            }
            
        }

        private void TicketPrintButton_Click(object sender, EventArgs e)
        {
            if (TicketListBox.SelectedItem != null)
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {

                    saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                    saveFileDialog.DefaultExt = "txt";
                    saveFileDialog.Title = "Save Text File";


                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Get the file path from the SaveFileDialog
                        string filePath = saveFileDialog.FileName;

                        try
                        {
                            Ticket ticket = (Ticket)TicketListBox.SelectedItem;
                            // Step 3: Create and write to the file
                            using (StreamWriter writer = new StreamWriter(filePath))
                            {
                                // Writing some text to the file
                                writer.WriteLine(ticket.ToString());

                                // You can add more lines or data here as needed
                            }

                            MessageBox.Show("File saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }

            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Select A flight from the list and click buy to buy it. Select a ticket from the list to either refund or print it");
        }

        private void TicketIdButton_Click(object sender, EventArgs e)
        {
            var orderTickets = Tickets.OrderBy(ticket => ticket.TicketId).ToList();

            new PassengerPage(Passenger, orderTickets);
            this.Hide();
        }

        private void FlightIdButton_Click(object sender, EventArgs e)
        {
            var orderFlights = airlineTicketSystem.Flights.OrderBy(flight => flight.FlightId).ToList();

            new PassengerPage(Passenger, Tickets, orderFlights);
            this.Hide();
        }

        private void FlightDestinationButton_Click(object sender, EventArgs e)
        {
            var orderFlights = airlineTicketSystem.Flights.OrderBy(flight => flight.Destination).ToList();

            new PassengerPage(Passenger, Tickets, orderFlights);
            this.Hide();
        }

        private void FilghtDateButton_Click(object sender, EventArgs e)
        {
            var orderFlights = airlineTicketSystem.Flights.OrderBy(flight => flight.DepartureDate).ToList();

            new PassengerPage(Passenger, Tickets, orderFlights);
            this.Hide();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
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
    }
}
