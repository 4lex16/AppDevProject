namespace AirlineTicketsSystemGui.model
{
    public class Flight
    {
        public int FlightId { get; set; }
        public int FirstClassSeats { get; set; }
        public int BusinessClassSeats { get; set; }
        public int CoachClassSeats { get; set; }
        public string Destination { get; set; }
        public string DepartureDate { get; set; }
        public string DepartureTime { get; set; }
        
    }
}