using System.Collections.Generic;
using AirlineTicketsSystemGui.controller;

namespace AirlineTicketsSystemGui.model
{
    public class AirlineTicketSystem
    {
        private AirlineTicketSystem _airlineTicketSystem;
        private List<Passenger> Passengers;
        private List<Staff> Staff;
        private List<Flight> Flights;


        private AirlineTicketSystem()
        {
            Passengers = DatabaseController.QueryAllPassengers();
            Staff = DatabaseController.QueryAllStaff();
            Flights = DatabaseController.QueryAllFlights();
        }
        
        public AirlineTicketSystem GetInstance()
        {
            if (_airlineTicketSystem == null)
            {
                _airlineTicketSystem = new AirlineTicketSystem();
            }
            
            return _airlineTicketSystem;
        }
    }
}