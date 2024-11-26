
# This is the Class Diagram for our AppDev Airline Ticket System Project

```mermaid
classDiagram
    class AirlineTicketSystemController {
        %% IDK TIRED
    }

    class DatabaseController {
        %% ADD Later TIRED
    }

    %% Singleton
    class AirlineTicketSystem {
        -AirlineTicketSystem instance$
        +List~Passenger~ Passengers
        +List~Staff~ Staff
        +List~Flight~ Fligths

        -AirlineTicketSystem()
        +GetInstance()$ AirlineTicketSystem
    }

    class User {
        + int UserId
        + String Email
        + String Password
    }
    
    class Staff {
        %% IDK WHAT
    }

    class Passenger {
        +List~Ticket~ Tickets
    }

    class Flight {
        + int FlightId
        + String SeatQuality
        + String SeatAvailability
    }

    class Ticket {
        + int TicketId
        + Flight Flight
    }

    <<Abstract>> User
    User <-- Passenger
    User <-- Staff
```