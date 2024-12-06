using AirlineTicketsSystemGui.controller;
using System;
using System.Windows.Forms;
using AirlineTicketsSystemGui.model;

namespace AirlineTicketsSystemGui
{
    public partial class AdminAddFlightPage : Form
    {
        public AdminAddFlightPage()
        {
            InitializeComponent();
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            string destination = DestinationTb.Text;
            string date = DateDp.Text;
            string time = $"{HourNup.Text}:{MinuteNup.Text}";
            int fc = int.Parse(FirstCTb.Text);
            int bc = int.Parse(BusinessCTb.Text);
            int cc = int.Parse(CoachCTb.Text);
            //TODO: Add Flight the the thing
            this.Close();
        }

        // Admin Add Flight Page Tools Menu
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AirlineTicketSystemController.AboutMb("About Add Flight Page",
                "This page is used to add flights to the system.");
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