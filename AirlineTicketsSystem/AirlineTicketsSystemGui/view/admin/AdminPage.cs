﻿using System;
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
    public partial class AdminPage : Form
    {
        private BindingSource FlightBs { get; } = new BindingSource();
        private BindingSource StaffBs { get; } = new BindingSource();

        public AdminPage()
        {
            InitializeComponent();
        }
        
        // Admin Page Custom Functions
        private void LoadData()
        {
            FlightListBox.DataSource = FlightBs;
            StaffListBox.DataSource = StaffBs;
            FlightBs.ResetBindings(false);
            StaffBs.ResetBindings(false);
        }

        private void ResetDataSource()
        {
            FlightBs.DataSource = AirlineTicketSystem.GetInstance().Flights;
            StaffBs.DataSource = AirlineTicketSystem.GetInstance().Staff;
        }

        // Admin Page Form Controls
        private void AdminPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        
        private void AdminPage_Load(object sender, EventArgs e)
        {
            FlightBs.DataSource = AirlineTicketSystem.GetInstance().Flights;
            StaffBs.DataSource = AirlineTicketSystem.GetInstance().Staff;
            LoadData();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        // Staff Tab Controls
        private void StaffDetailsButton_Click(object sender, EventArgs e)
        {
            if (StaffListBox.SelectedItem != null)
            {
                new DetailsPage("staff", StaffListBox.SelectedItem).Show();
            }
        }
        
        private void StaffAddButton_Click(object sender, EventArgs e)
        {
            new AdminAddStaffPage().Show();
        }

        private void StaffEditButton_Click(object sender, EventArgs e)
        {
            if (StaffListBox.SelectedItem != null)
            {
                new AdminEditStaffPage((Staff)StaffListBox.SelectedItem).Show();
            }
        }

        private void StaffRemoveButton_Click(object sender, EventArgs e)
        {
            if (StaffListBox.SelectedItem != null)
            {
                AirlineTicketSystemController.RemoveStaff((Staff)StaffListBox.SelectedItem);
                LoadData();
            }
        }
        
        private void StaffIdTb_TextChanged(object sender, EventArgs e)
        {
            if (StaffIdTb.Text.Equals(""))
            {
                ResetDataSource();
            }
            else
            {
                    int staffId = int.Parse(StaffIdTb.Text);
                List<Staff> staffs = new List<Staff>();
                foreach (Staff staff in AirlineTicketSystem.GetInstance().Staff)
                {
                    if (staff.UserId.ToString().StartsWith(staffId.ToString()))
                    {
                        staffs.Add(staff);
                    }
                }
                StaffBs.DataSource = staffs;
            }
            LoadData();
        }

        // Flight Tab Controls
        private void FlightDetailsButton_Click(object sender, EventArgs e)
        {
            if (FlightListBox.SelectedItem != null)
            {
                new DetailsPage("flight", FlightListBox.SelectedItem).Show();
            }
        }

        private void FlightAddButton_Click(object sender, EventArgs e)
        {
            new AdminAddFlightPage().Show();
        }
        
        private void FlightEditButton_Click(object sender, EventArgs e)
        {
            if (FlightListBox.SelectedItem != null)
            {
                new AdminEditFlightPage((Flight)FlightListBox.SelectedItem).Show();
            }
        }

        private void FlightIdButton_Click(object sender, EventArgs e)
        {
            List<Flight> flights = AirlineTicketSystem.GetInstance().Flights.OrderBy(flight => flight.FlightId).ToList();
            FlightBs.DataSource = flights;
            LoadData();
        }
        
        private void FlightDestinationButton_Click(object sender, EventArgs e)
        {
            List<Flight> flights = AirlineTicketSystem.GetInstance().Flights.OrderBy(flight => flight.Destination).ToList();
            FlightBs.DataSource = flights;
            LoadData();
        }
        
        private void FlightIdTb_TextChanged(object sender, EventArgs e)
        {
            if (FlightIdTb.Text.Equals(""))
            {
                ResetDataSource();
            }
            else
            {
                int flightId = int.Parse(FlightIdTb.Text);
                List<Flight> flights = new List<Flight>();
                foreach (Flight flight in AirlineTicketSystem.GetInstance().Flights)
                {
                    if (flight.FlightId.ToString().StartsWith(flightId.ToString()))
                    {
                        flights.Add(flight);
                    }
                }
                FlightBs.DataSource = flights;
            }
            LoadData();
        }

        private void FlightDestinationTb_TextChanged(object sender, EventArgs e)
        {
            if (FlightDestinationTb.Text.Equals(""))
            {
                ResetDataSource();
            }
            else
            {
                string destination = FlightDestinationTb.Text;
                List<Flight> flights = new List<Flight>();
                foreach (Flight flight in AirlineTicketSystem.GetInstance().Flights)
                {
                    if (flight.Destination.ToLower().StartsWith(destination.ToLower()))
                    {
                        flights.Add(flight);
                    }
                }
                FlightBs.DataSource = flights;
            }
            LoadData();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            if (FlightListBox.SelectedItem != null)
            {
                AirlineTicketSystemController.RemoveFlight((Flight)FlightListBox.SelectedItem);
                LoadData();
            }
        }

        // Tool Strip Menu Controls
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AirlineTicketSystemController.AboutMb(
                "About Admin Page", 
                "This page will be used to manage the staff and the flights."
            );
        }
        
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AdminLoginPage().Show();
            this.Hide();
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
