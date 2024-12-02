namespace AirlineTicketsSystemGui.model
{
    public class Flight
    {
        public Flight(int flightId, int firstClassSeats, int businessClassSeats, int coachClassSeats, string destination, string departureDate, string departureTime)
        {
            FlightId = flightId;
            FirstClassSeats = firstClassSeats;
            BusinessClassSeats = businessClassSeats;
            CoachClassSeats = coachClassSeats;
            Destination = destination;
            DepartureDate = departureDate;
            DepartureTime = departureTime;
        }
        
        public Flight(Flight flight)
        {
            FlightId = flight.FlightId;
            FirstClassSeats = flight.FirstClassSeats;
            BusinessClassSeats = flight.BusinessClassSeats;
            CoachClassSeats = flight.CoachClassSeats;
            Destination = flight.Destination;
            DepartureDate = flight.DepartureDate;
            DepartureTime = flight.DepartureTime;
        }

        public int FlightId { get; set; }
        public int FirstClassSeats { get; set; }
        public int BusinessClassSeats { get; set; }
        public int CoachClassSeats { get; set; }
        public string Destination { get; set; }
        public string DepartureDate { get; set; }
        public string DepartureTime { get; set; }
        
    }
}