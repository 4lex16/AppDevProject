namespace AirlineTicketsSystemGui.model
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public Flight Flight { get; set; }
        public Passenger Passenger { get; set; }
    }
}