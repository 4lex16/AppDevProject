namespace AirlineTicketsSystemGui.model
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public Flight Flight { get; set; }
        public int PassengerId { get; set; }
        public SeatType SeatType { get; set; }

        public Ticket(int ticketId, Flight flight, int passengerId, SeatType seatType)
        {
            TicketId = ticketId;
            Flight = flight;
            PassengerId = passengerId;
            SeatType = seatType;
        }

        public override string ToString()
        {
            return $"Ticket ID: {TicketId}, Flight: {Flight.ToString()}, Passenger ID: {PassengerId}, Seat Type: {SeatType.ToString()}";
<<<<<<< HEAD
            
=======
>>>>>>> ATK-11
        }
    }
}