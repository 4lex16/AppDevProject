﻿
using AirlineTicketsSystemGui.controller;
using AirlineTicketsSystemGui.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineTicketsSystemGui
{
    public partial class LoginPage : Form
    {
        AirlineTicketSystem airlineTicketSystem = AirlineTicketSystem.GetInstance();
        public LoginPage()
        {
            InitializeComponent();
            AirlineTicketSystemController airlineTicketSystemController = new AirlineTicketSystemController();
        }

        private void StaffLoginButton_Click(object sender, EventArgs e)
        {
            int enteredStaffId = int.Parse(StaffIdTb.Text);
            String enteredStaffPassword = StaffPasswordTb.Text;
            for (int i = 0; i < airlineTicketSystem.Staff.Count; i++)
            {
                int id = airlineTicketSystem.Staff[i].UserId;

                if (enteredStaffId == id)
                {
                    string password = airlineTicketSystem.Staff[i].Password;
                    if (password.Equals(enteredStaffPassword))
                    {
                        new StaffPage(airlineTicketSystem.Staff[i]).Show();
                        this.Hide();
                        return;
                    }
                }
            }
            MessageBox.Show("Id and Password Combination not Found Please Try Again!");
        }

        private void PassengerLoginButton_Click(object sender, EventArgs e)
        {

            int enteredPassengerId = int.Parse(PassengerIdTb.Text);
            String enteredPassengerPassword = PassengerPasswordTb.Text;


            for (int i = 0; i < airlineTicketSystem.Passengers.Count(); i++)
            {
                int id = airlineTicketSystem.Passengers[i].UserId;

                if (enteredPassengerId == id)
                {
                    string password = airlineTicketSystem.Passengers[i].Password;
                    if (password.Equals(enteredPassengerPassword))
                    {
                        new PassengerPage(airlineTicketSystem.Passengers[i], airlineTicketSystem.Passengers[i].Tickets).Show();
                        this.Hide();
                        return;
                    }
                }
            }
            MessageBox.Show("Id and Password Combination not Found Please Try Again!");
        }

        private void LoginPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void StaffAdminLabel_Click(object sender, EventArgs e)
        {
            new AdminLoginPage().Show();
            this.Hide();
        }

        private void PassengerSignupLabel_Click(object sender, EventArgs e)
        {
            new PassengerSignupPage().Show();
            this.Hide();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AirlineTicketSystemController.AboutMb("About Login Page", 
                "This page's purpose is to log in as staff or passenger," +
                " open the admin login page or register as a passenger");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
    }
}
