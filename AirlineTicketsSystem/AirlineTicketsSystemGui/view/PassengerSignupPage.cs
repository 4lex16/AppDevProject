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
            //TODO: Implement the creation of the passenger and return their
            new LoginPage().Show();
            this.Hide();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new LoginPage().Show();
            this.Hide();
        }
    }
}
