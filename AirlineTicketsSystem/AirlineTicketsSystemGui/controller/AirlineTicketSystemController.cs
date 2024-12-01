using AirlineTicketsSystemGui.model;

namespace AirlineTicketsSystemGui.controller
{
    public class AirlineTicketSystemController
    {
        private static AirlineTicketSystem airlineTicketSystem = AirlineTicketSystem.GetInstance();

        public void InsertPassenger(Passenger passenger)
        {
            DatabaseController.InsertPassengerRecord(passenger);
            airlineTicketSystem.Passengers.Add(passenger);
        }

        public void InsertFlight(Flight flight)
        {
            DatabaseController.InsertFlightRecord(flight);
            airlineTicketSystem.Flights.Add(flight);
        }

        public void InsertStaff(Staff staff)
        {
            DatabaseController.InsertStaffRecord(staff);
            airlineTicketSystem.Staff.Add(staff);
        }
    }
}