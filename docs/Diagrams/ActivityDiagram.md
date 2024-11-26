
# This is the Activity Diagram for our AppDev Airline Ticket System Project

```mermaid
---
title: Airline Ticker System Activity Diragram
---
flowchart LR
    %% START AND END
    START@{ shape: circle, label: "Start" }
    END@{ shape: circle, label: "End" }

    %% main page subgraph
    main-choice@{ shape: diamond, label: "Login or Sign Up?" }

    %% settings page
    settings-option@{ shape: diamond, label: "English or French?"}
    settings-event@{ shape: event, label: "Changed settings.json"}

    %% login page subgraph
    enter-login@{ shape: manual-input, label: "Enter Information"}
    validate-login@{ shape: hex, label: "Validated?"}

    %% signup page subgraph
    enter-signup@{ shape: manual-input, label: "Enter Information"}
    validate-signup@{ shape: hex, label: "Validated?"}

    %% staff page subgraph
    staff-option@{ shape: manual-input, label: "Option Pressed"}
    staff-passenger-list@{ shape: process, label: "Passenger List"}
    staff-flight-list@{ shape: process, label: "Flight List"}

    %% passenger page subgraph
    passenger-option@{ shape: manual-input, label: "Option Pressed"}
        %% flight list subgraph
        passenger-flight-list-display@{ shape: event, label: "Display Flights" }
        passenger-flight-list-select@{ shape: hex, label: "Flight Selected?" }
        passenger-flight-list-option@{ shape: manual-input, label: "Option Pressed"}
        passenger-flight-list-buy@{ shape: process, label: "Buy"}
        passenger-flight-list-buy-select@{ shape: manual-input, label: "Select Options"}
        passenger-flight-list-buy-event@{ shape: event, label: "Flight Added To Ticket List"}
        passenger-flight-list-details@{ shape: process, label: "Details"}
        passenger-flight-list-details-event@{ shape: event, label: "Display details of the flight"}

        
        %% bought list subgraph
        passenger-ticket-list-display@{ shape: event, label: "Display Tickets" }
        passenger-ticket-list-select@{ shape: hex, label: "Ticket Selected?" }
        passenger-ticket-list-option@{ shape: manual-input, label: "Option Pressed"}
        passenger-ticket-list-refund@{ shape: process, label: "Refund"}
        passenger-ticket-list-refund-event@{ shape: event, label: "Flight Removed from Ticket List"}
        passenger-ticket-list-detail@{ shape: process, label: "Details"}
        passenger-ticket-list-detail-event@{ shape: event, label: "Display details of the flight"}


    START --> main
    subgraph main[Main Page]
        direction TB
        main-choice --> login
        main-choice --> signup

        subgraph login[Login Page]
            direction TB
            enter-login --> validate-login
        end
        login -- Staff Login --> staff
        login -- Passenger Login ---> passenger

        subgraph signup[Sign Up Page]
            direction TB
            enter-signup --> validate-signup
        end
        signup -- Successful Signup ---> passenger

        subgraph staff[Staff Page]
            direction LR
            staff-option --> staff-passenger-list
            staff-option --> staff-flight-list
        end

        subgraph passenger[Passenger Page]
            direction TB
                passenger-option --> passengerflightlist
                passenger-option --> passengerticketlist

                subgraph passengerflightlist[Flight List]
                    direction TB
                    passenger-flight-list-display --> passenger-flight-list-select
                    passenger-flight-list-select --> passenger-flight-list-option
                    passenger-flight-list-option --> passenger-flight-list-buy
                    passenger-flight-list-buy --> passenger-flight-list-buy-select
                    passenger-flight-list-buy-select --> passenger-flight-list-buy-event

                    passenger-flight-list-option --> passenger-flight-list-details
                    passenger-flight-list-details --> passenger-flight-list-details-event
                    passenger-flight-list-details-event --> passenger-flight-list-buy
                end

                subgraph passengerticketlist[Ticklet List]
                    direction TB
                    passenger-ticket-list-display --> passenger-ticket-list-select
                    passenger-ticket-list-select --> passenger-ticket-list-option
                    passenger-ticket-list-option --> passenger-ticket-list-refund
                    passenger-ticket-list-refund --> passenger-ticket-list-refund-event

                    passenger-ticket-list-option --> passenger-ticket-list-detail
                    passenger-ticket-list-detail --> passenger-ticket-list-detail-event
                    passenger-ticket-list-detail-event --> passenger-ticket-list-refund
                end
        end
    end
    main --> END
    main --> settings
    settings --> main
    subgraph settings[Settings Page]
            settings-option --> settings-event
    end
    
```