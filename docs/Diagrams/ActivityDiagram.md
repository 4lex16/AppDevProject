
# This is the Activity Diagram for our AppDev Airline Ticket System Project

```mermaid
---
title: Airline Ticker System Activity Diragram
---
flowchart LR
    %% START AND END
    START@{ shape: circle, label: "Start" }
    END@{ shape: circle, label: "End" }
    STARTA@{ shape: circle, label: "Start" }
    ENDA@{ shape: circle, label: "End" }

    %% admin page subgraph
    admin-login@{ shape: hex, label: "Admin Login Correct?" }
    admin-option@{ shape: manual-input, label: "Option Pressed" }
    asl-option@{ shape: manual-input, label: "Option Pressed" }
    afl-option@{ shape: manual-input, label: "Option Pressed" }

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
        %% flight list subgraph
        sfl-display@{ shape: event, label: "Display flights" }
        %% passenger list subgraph
        spl-display@{ shape: event, label: "Display passengers"}
    %% passenger page subgraph
    passenger-option@{ shape: manual-input, label: "Option Pressed"}
        %% flight list subgraph
        pfl-display@{ shape: event, label: "Display Flights" }
        pfl-select@{ shape: hex, label: "Flight Selected?" }
        pfl-option@{ shape: manual-input, label: "Option Pressed"}
        pfl-buy@{ shape: process, label: "Buy"}
        pfl-buy-select@{ shape: manual-input, label: "Select Options"}
        pfl-buy-event@{ shape: event, label: "Flight Added To Ticket List"}
        pfl-details@{ shape: process, label: "Details"}
        pfl-details-event@{ shape: event, label: "Display details of the flight"}

        
        %% ticket list subgraph
        ptl-display@{ shape: event, label: "Display Tickets" }
        ptl-select@{ shape: hex, label: "Ticket Selected?" }
        ptl-option@{ shape: manual-input, label: "Option Pressed"}
        ptl-refund@{ shape: process, label: "Refund"}
        ptl-refund-event@{ shape: event, label: "Flight Removed from Ticket List"}
        ptl-detail@{ shape: process, label: "Details"}
        ptl-detail-event@{ shape: event, label: "Display details of the flight"}
        ptl-print@{ shape: process, label: "Print" }
        ptl-print-event@{ shape: event, label: "Create file via StreamWriter" }

    STARTA --> admin
    subgraph admin[Admin Page]
        admin-login --> admin-option
        admin-option --> asl
        admin-option --> afl
        subgraph asl[Staff List]
            asl-option --> asl-add
            asl-option --> asl-remove
            asl-option --> asl-edit
        end
        subgraph afl[Flight List]
            afl-option --> afl-add
            afl-option --> afl-remove
            afl-option --> afl-edit
        end
    end
    admin --> ENDA
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
            staff-option --> spl
            staff-option --> sfl
            subgraph spl[Passenger List]
                spl-display
            end
            subgraph sfl[Passenger List]
                sfl-display
            end
        end

        subgraph passenger[Passenger Page]
            direction TB
                passenger-option --> pfl
                passenger-option --> ptl

                subgraph pfl[Flight List]
                    direction TB
                    pfl-display --> pfl-select
                    pfl-select --> pfl-option
                    pfl-option --> pfl-buy
                    pfl-buy --> pfl-buy-select
                    pfl-buy-select --> pfl-buy-event

                    pfl-option --> pfl-details
                    pfl-details --> pfl-details-event
                    pfl-details-event --> pfl-buy
                end

                subgraph ptl[Ticklet List]
                    direction TB
                    ptl-display --> ptl-select
                    ptl-select --> ptl-option
                    ptl-option --> ptl-refund
                    ptl-refund --> ptl-refund-event

                    ptl-option --> ptl-print
                    ptl-print --> ptl-print-event

                    ptl-option --> ptl-detail
                    ptl-detail --> ptl-detail-event
                    ptl-detail-event --> ptl-refund
                    ptl-detail-event --> ptl-print
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