using System.Collections.Generic;
using System.Data.SqlClient;
using AirlineTicketsSystemGui.model;
using Microsoft.Data.Sqlite;

namespace AirlineTicketsSystemGui.controller
{
    public class DatabaseController
    {
        private static int seatTypeId = 1;
        private const string DatabaseFileName = "Data Source=PATH"; //todo: specify the path later
        public static SqliteConnection GetConnection()
        {
            return new SqliteConnection(DatabaseFileName);
        }

        public static void CreateFlightTable()
        {
            
        }

        public static void CreateTicketTable()
        {
            
        }

        public static void CreateStaffTable()
        {
            
        }

        public static void CreateSeatTypeTable()
        {
            
        }
        public static void InsertFlightRecord(int flightId, string seatAvailability) 
        {
            //todo: implement the method
        }

        public static void InsertFlightRecord(Flight flight) 
        {
            InsertFlightRecord(flight.FlightId, flight.SeatAvailability);
        }

        public static void InsertPassengerRecord(int userId, string email, string password, string phone, string address)
        {
            //todo: implement the method
        }

        public static void InsertPassengerRecord(Passenger passenger)
        {
            InsertPassengerRecord(passenger.UserId, passenger.Email, passenger.Password, passenger.Phone, passenger.Address);
        }

        public static void InsertStaffRecord(int staffId, string email, string password)
        {
            //todo: implement the method
        }
        
        public static void InsertStaffRecord(Staff staff)
        {
            InsertStaffRecord(staff.UserId, staff.Email, staff.Password);
        }

        public static void InsertTicketRecord(int ticketId, int seatTypeId, int passengerId, int flightId)
        {
            //todo: implement the method
        }
        
        public static void InsertTicketRecord(Ticket ticket)
        {
            InsertTicketRecord(ticket.TicketId, seatTypeId++, ticket.Passenger.UserId, ticket.Flight.FlightId);
        }

        public static List<Flight> quryAllFlights()
        {
            //todo: implement the method
            return null;
        }

        public static List<Passenger> quryAllPassengers()
        {
            //todo: implement the method
            return null;
        }

        public static List<Ticket> quryAllTickets()
        {
            //todo: implement the method
            return null;
        }

        public static List<Staff> quryAllStaff()
        {
            //todo: implement the method
            return null;
        }
    }
}