using System.Collections.Generic;
using AirlineTicketsSystemGui.model;

namespace AirlineTicketsSystemGui.controller
{
    public class DatabaseController
    {
        public static void InsertFlightRecord(int flightId, SeatType seatQuality, string seatAvailability) 
        {
            //todo: implement the method
        }

        public static void InsertFlightRecord(Flight flight) 
        {
            InsertFlightRecord(flight.FlightId, flight.SeatQuality, flight.SeatAvailability);
        }

        public static void InsertPassengerRecord(int userId, string email, string password, string phone, string address, List<Ticket> tickets)
        {
            //todo: implement the method
        }
        
        public static void InsertPassengerRecord(Passenger passenger)
        {
            InsertPassengerRecord(passenger.UserId, passenger.Email, passenger.Password, passenger.Phone, passenger.Address, passenger.Tickets);
        }
    }
}