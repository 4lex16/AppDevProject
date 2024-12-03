using System.Collections.Generic;
using AirlineTicketsSystemGui.controller;

namespace AirlineTicketsSystemGui.model
{
    public class AirlineTicketSystem
    {
        private static AirlineTicketSystem _airlineTicketSystem;
        public List<Passenger> Passengers { get; }
        public List<Staff> Staff { get; }
        public List<Flight> Flights { get; }
        
        private AirlineTicketSystem()
        {
            Passengers = DatabaseController.QueryAllPassengers();
            Staff = DatabaseController.QueryAllStaff();
            Flights = DatabaseController.QueryAllFlights();
        }
        
        public static AirlineTicketSystem GetInstance()
        {
            if (_airlineTicketSystem == null)
            {
                _airlineTicketSystem = new AirlineTicketSystem();
            }
            
            return _airlineTicketSystem;
        }
    }
}