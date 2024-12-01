using System.Collections.Generic;

namespace AirlineTicketsSystemGui.model
{
    public class Passenger : User
    {
        public string Phone { get; set; }
        public string Address { get; set; }
        public List<Ticket> Tickets { get; set; }
    }
}