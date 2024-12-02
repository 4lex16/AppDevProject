using System;
using System.Windows.Forms;
using AirlineTicketsSystemGui.model;

namespace AirlineTicketsSystemGui
{
    public partial class AdminEditStaffPage : Form
    {
        private Staff Staff { get; set; }
        public AdminEditStaffPage(Staff staff)
        {
            Staff = staff;
            InitializeComponent();
        }

        private void AdminEditStaffPage_Load(object sender, EventArgs e)
        {
            //TODO: Load staff information
        }


        private void EditButton_Click(object sender, EventArgs e)
        {
            //TODO: Change Staff Information
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}