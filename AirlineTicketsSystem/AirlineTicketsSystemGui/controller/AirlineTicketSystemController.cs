using System.Configuration;
using System.Threading;
using System.Windows.Forms;
using AirlineTicketsSystemGui.model;

namespace AirlineTicketsSystemGui.controller
{
    public class AirlineTicketSystemController
    {
        private static AirlineTicketSystem airlineTicketSystem = AirlineTicketSystem.GetInstance();

        public AirlineTicketSystemController()
        {
            // Initializes Globalization
            string language = ConfigurationManager.AppSettings["language"];
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(language);
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(language);
            // Initializes airlineTicketSystem
            airlineTicketSystem = AirlineTicketSystem.GetInstance();
            DatabaseController.InitializeDatabase();
            DatabaseController.CreateFlightTable();
            DatabaseController.CreateTicketTable();
            DatabaseController.CreatePassengerTable();
            DatabaseController.CreateStaffTable();
        }

        public static int InsertPassenger(string fullName, string email, string password, string phone, string address)
        {
            DatabaseController.InsertPassengerRecord(fullName, email, password, phone, address);
            Passenger passenger = DatabaseController.ReturnLastPassenger();
            airlineTicketSystem.Passengers.Add(passenger);
            return passenger.UserId;
        }

        public static int InsertFlight(int firstClassSeats, int businessClassSeats, int coachClassSeats, string destination, string departureDate, string departureTime)
        {
            DatabaseController.InsertFlightRecord(firstClassSeats, businessClassSeats, coachClassSeats, destination, departureTime, departureDate);
            Flight flight = DatabaseController.ReturnLastFlight();
            airlineTicketSystem.Flights.Add(flight);
            return flight.FlightId;
        }

        public static int InsertStaff(string email, string password)
        {
            DatabaseController.InsertStaffRecord(email, password);
            Staff staff = DatabaseController.ReturnLastStaff();
            airlineTicketSystem.Staff.Add(staff);
            return staff.UserId;
        }

        public static int inserTicket(Flight flight, int passengerId, SeatType seatType)
        {
            DatabaseController.InsertTicketRecord(passengerId, flight.FlightId, seatType);
            Ticket ticket = DatabaseController.ReturnLastTicket();
            return ticket.TicketId;
        }

        public static void RemoveStaff(Staff staff)
        {
            DatabaseController.RemoveStaff(staff.UserId);
            airlineTicketSystem.Staff.Remove(staff);
        }

        public static void RemoveFlight(Flight flight)
        {
            DatabaseController.RemoveFlight(flight.FlightId);
            airlineTicketSystem.Flights.Remove(flight);
        }


        public static void AboutMb(string header, string message)
        {
            MessageBox.Show(message, header, MessageBoxButtons.OK ,MessageBoxIcon.Information);
        }

        public static void NotImplementedMb()
        {
            MessageBox.Show(
                "This Feature will be Implemented at a Later Date",
                "Sorry Feature Not Implemented", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Error
            );
        }
    }
}