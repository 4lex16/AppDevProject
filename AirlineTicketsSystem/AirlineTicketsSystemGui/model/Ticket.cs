namespace AirlineTicketsSystemGui.model
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public Flight Flight { get; set; }
        
        public int PassengerId { get; set; }
        public SeatType SeatType { get; set; }
    }
}