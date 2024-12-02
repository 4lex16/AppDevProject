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
        public LoginPage()
        {
            InitializeComponent();
        }

        private void StaffLoginButton_Click(object sender, EventArgs e)
        {
            new StaffPage().Show();
            this.Hide();
        }

        private void PassengerLoginButton_Click(object sender, EventArgs e)
        {
            new PassengerPage().Show();
            this.Hide();
        }

        private void LoginPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
