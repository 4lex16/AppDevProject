
# This is the ERD for our AppDev Airline Ticket System Project

```mermaid
---
title: Airline Ticket System Entity Relationship Diagram
---
erDiagram
    %% Staff will be created by "Admin" (outside of our program)
    Staff {
        Int32 staff_id PK
        String staff_email
        String staff_password
    }
    
    Passenger {
        Int32 passenger_id PK
        string passenger_first_name
        string passenger_last_name
        string passenger_email
        string passenger_password
        string passenger_phone
        string passenger_address
    }

    %% Flight will be created by "Admin" (outside of our program)
    Flight {
        Int32 flight_id
        Int32 first_class_seats
        Int32 buisness_class_seats
        Int32 coach_class_seats
        string destination
        string departure_date
        string departure_time
    }


    Ticket {
        Int32 ticket_id PK
        Int32 seattype_id FK
        Int32 passenger_id FK
        Int32 flight_id FK
    }

    SeatType {
        Int32 seattype_id PK
        string seat_type
        Int32 seat_type_num
    }

    Passenger ||--|{ Ticket : assignedTo
    Ticket }o--|| Flight: assignedTo
    Ticket ||--|| SeatType: contains
```