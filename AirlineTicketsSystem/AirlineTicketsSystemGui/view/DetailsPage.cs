using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AirlineTicketsSystemGui.model;

namespace AirlineTicketsSystemGui
{
    public partial class DetailsPage : Form
    {
        private string Type { get; set; }
        private Object Data { get; set; }
        public DetailsPage(string type, Object data)
        {
            Type = type;
            Data = data;
            InitializeComponent();
        }

        private void LoadData()
        {
            switch (Type) {
                case "flight":
                {
                    Flight flight = (Flight) Data;
                    AddRow("Flight Id", $"{10}");
                    AddRow("Flight ", $"{10}");
                    AddRow("Flight Id", $"{10}");
                    AddRow("Flight Id", $"{10}");
                    AddRow("Flight Id", $"{10}");
                    AddRow("Flight Id", $"{10}");
                    AddRow("Flight Id", $"{10}");
                    break;
                }
                case "passenger":
                {
                    Passenger passenger = (Passenger) Data;
                    break;
                }
                case "tickets":
                {
                    Ticket ticket = (Ticket) Data;
                    break;
                }
                case "staff":
                {
                    Staff staff = (Staff) Data;
                    break;
                }
                default:
                {
                    throw new Exception($"Cannot resolve {Type} in DetailsPage LoadData() switch case");
                }
            }
        }

        private void AddRow(string header, string content)
        {
            DetailsTb.Text += $"{(header + ":"),-40}  {content}";
        }

        private void DetailsPage_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
