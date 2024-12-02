using AirlineTicketsSystemGui.model;

namespace AirlineTicketsSystemGui.controller
{
    public class AirlineTicketSystemController
    {
        private AirlineTicketSystem airlineTicketSystem;

        public AirlineTicketSystemController()
        {
            DatabaseController.CreateFlightTable();
            DatabaseController.CreateTicketTable();
            DatabaseController.CreatePassengerTable();
            DatabaseController.CreateStaffTable();
            this.airlineTicketSystem = AirlineTicketSystem.GetInstance();
        }

        public int InsertPassenger(string fullName, string email, string password, string phone, string address)
        {
            Passenger passenger = new Passenger(airlineTicketSystem.Passengers.Count + 10000, fullName, email, password, phone, address);
            DatabaseController.InsertPassengerRecord(passenger);
            airlineTicketSystem.Passengers.Add(passenger);
            return passenger.UserId;
        }

        public int InsertFlight(int firstClassSeats, int businessClassSeats, int coachClassSeats, string destination, string departureDate, string departureTime)
        {
            Flight flight = new Flight(airlineTicketSystem.Flights.Count + 1000, firstClassSeats, businessClassSeats, coachClassSeats, destination, departureDate, departureTime);
            DatabaseController.InsertFlightRecord(flight);
            airlineTicketSystem.Flights.Add(flight);
            return flight.FlightId;
        }

        public int InsertStaff(int userId, string email, string password)
        {
            Staff staff = new Staff(airlineTicketSystem.Staff.Count + 100, email, password);
            DatabaseController.InsertStaffRecord(staff);
            airlineTicketSystem.Staff.Add(staff);
            return staff.UserId;
        }

        public int inserTicket(Flight flight, int passengerId, SeatType seatType)
        {
            Ticket ticket = new Ticket(DatabaseController.GetTicketId(), flight, passengerId, seatType);
            DatabaseController.InsertTicketRecord(DatabaseController.GetTicketId(), passengerId, flight.FlightId, seatType);
            return ticket.TicketId;
        }
        
    }
}