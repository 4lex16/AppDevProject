﻿using System.Windows.Forms;
using AirlineTicketsSystemGui.model;

namespace AirlineTicketsSystemGui
{
    public partial class AdminEditFlightPage : Form
    {
        private Flight Flight { get; set; }

        public AdminEditFlightPage(Flight flight)
        {
            Flight = flight;
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
    }
}