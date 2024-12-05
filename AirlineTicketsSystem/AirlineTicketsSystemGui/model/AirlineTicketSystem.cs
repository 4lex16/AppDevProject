using System.Collections.Generic;
using AirlineTicketsSystemGui.controller;

namespace AirlineTicketsSystemGui.model
{
    public class AirlineTicketSystem
    {
        private static AirlineTicketSystem _airlineTicketSystem;
        public List<Passenger> Passengers { get; set; }
        public List<Staff> Staff { get; set; }
        public List<Flight> Flights { get; set; }
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