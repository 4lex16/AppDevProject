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
                    break;
                }
                case "passenger":
                {
                    break;
                }
                case "tickets":
                {
                    break;
                }
                case "staff":
                {
                    break;
                }
                case "":
                {
                    break;
                }
                default:
                {
                    throw new Exception($"Cannot resolve {Type} in DetailsPage LoadData() switch case");
                }
            }
        }
    }
}
