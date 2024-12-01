using System.Collections.Generic;

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
            //todo: instantiate all the lists using the queries in the database controller
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