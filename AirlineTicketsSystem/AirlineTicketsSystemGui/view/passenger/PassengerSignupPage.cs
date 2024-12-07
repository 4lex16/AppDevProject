
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
    public partial class PassengerSignupPage : Form
    {
        public static int passengerId = -1;

        AirlineTicketSystem airlineTicketSystem = AirlineTicketSystem.GetInstance();
        public PassengerSignupPage()
        {
            InitializeComponent();
        }

        private void PassengerSignupPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            new LoginPage().Show();
            this.Hide();
        }

        private void SignupButton_Click(object sender, EventArgs e)
        {
            AirlineTicketSystemController.InsertPassenger(FullnameTb.Text, EmailTb.Text, PasswordTb.Text, PhoneTb.Text, AddressTb.Text);

            

            for (int i = 0; i < airlineTicketSystem.Passengers.Count; i++)
            {
                //because phoneNumbers are unique
                string phoneNumber = airlineTicketSystem.Passengers[i].Phone;

                if (phoneNumber.Equals(PhoneTb.Text))
                {
                    passengerId = airlineTicketSystem.Passengers[i].UserId;
                    break;
                }
            }

            MessageBox.Show("Signup successful! Here is you UserId, Do Not Loose It: " + passengerId);

            new LoginPage().Show();
            this.Hide();

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new LoginPage().Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a sign up page for a new passenger, after successfully signing up, an id will appear keep it safe and do not share it with anyone");
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
