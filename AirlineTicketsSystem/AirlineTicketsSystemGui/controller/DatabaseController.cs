using System;
using System.Collections.Generic;
using System.Data;
using AirlineTicketsSystemGui.model;
using Microsoft.Data.Sqlite;

namespace AirlineTicketsSystemGui.controller
{
    public class DatabaseController
    {
        private const string DatabaseFileName = "Data Source=AirlineTicketsSystemDatabase/AirlineTicketsSystemDatabase.db";

        public static SqliteConnection GetConnection()
        {
            return new SqliteConnection(DatabaseFileName);
        }

        // Table Creation Methods
        public static void CreateFlightTable()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = @"
                    CREATE TABLE IF NOT EXISTS flights (
                        flight_id INTEGER PRIMARY KEY,
                        first_class_seats INTEGER NOT NULL,
                        business_class_seats INTEGER NOT NULL,
                        coach_class_seats INTEGER NOT NULL,
                        destination TEXT,
                        departure_time TEXT,
                        departure_date TEXT
                    );
                ";
                command.ExecuteNonQuery();
            }
        }

        public static void CreateTicketTable()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = @"
                    CREATE TABLE IF NOT EXISTS tickets (
                        ticket_id INTEGER PRIMARY KEY,
                        passenger_id INTEGER,
                        flight_id INTEGER,
                        seat_type INTEGER,
                        FOREIGN KEY (seat_type_id) REFERENCES seatTypes(seat_type_id),
                        FOREIGN KEY (passenger_id) REFERENCES passengers(passenger_id),
                        FOREIGN KEY (flight_id) REFERENCES flights(flight_id)
                    );
                ";
                command.ExecuteNonQuery();
            }
        }

        public static void CreateStaffTable()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = @"
                    CREATE TABLE IF NOT EXISTS staff (
                        staff_id INTEGER PRIMARY KEY,
                        email TEXT,
                        password TEXT
                    );
                ";
                command.ExecuteNonQuery();
            }
        }

        public static void CreatePassengerTable()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = @"
                    CREATE TABLE IF NOT EXISTS passengers (
                        passenger_id INTEGER PRIMARY KEY,
                        passenger_name TEXT,
                        passenger_email TEXT,
                        passenger_password TEXT,
                        passenger_phone_number TEXT,
                        passenger_address TEXT
                    );
                ";
                command.ExecuteNonQuery();
            }
        }

        // Insert Methods
        public static void InsertFlightRecord(int flightId, int firstClass, int businessClass, int coachClass, string destination, string departureTime, string departureDate)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = @"
                    INSERT INTO flights (flight_id, first_class_seats, business_class_seats, coach_class_seats, destination, departure_time, departure_date)
                    VALUES (@flightId, @firstClass, @businessClass, @coachClass, @destination, @departureTime, @departureDate);
                ";
                command.Parameters.AddWithValue("@flightId", flightId);
                command.Parameters.AddWithValue("@firstClass", firstClass);
                command.Parameters.AddWithValue("@businessClass", businessClass);
                command.Parameters.AddWithValue("@coachClass", coachClass);
                command.Parameters.AddWithValue("@destination", destination);
                command.Parameters.AddWithValue("@departureTime", departureTime);
                command.Parameters.AddWithValue("@departureDate", departureDate);
                command.ExecuteNonQuery();
            }
        }

        public static void InsertFlightRecord(Flight flight)
        {
            InsertFlightRecord(flight.FlightId, flight.FirstClassSeats, flight.BusinessClassSeats, flight.CoachClassSeats,
                flight.Destination, flight.DepartureTime, flight.DepartureDate);
        }
/*
 *                      seat_type_id INTEGER PRIMARY KEY,
                        seat_type TEXT,
                        seat_type_num INTEGER
 */
        //seatTypeNum should be enum
        public static void InsertPassengerRecord(int passengerId, string fullName, string email, string password, string phone, string address)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = @"
                    INSERT INTO passengers (passenger_id, passenger_name, passenger_email, passenger_password,
                                            passenger_phone_number, passenger_address)
                    VALUES (@passengerId, @name, @email, @password, @phone, @address);
                ";
                command.Parameters.AddWithValue("@passengerId", passengerId);
                command.Parameters.AddWithValue("@name", fullName);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@phone", phone);
                command.Parameters.AddWithValue("@address", address);
                command.ExecuteNonQuery();
            }
        }

        public static void InsertPassengerRecord(Passenger passenger)
        {
            InsertPassengerRecord(passenger.UserId, passenger.Name, passenger.Email, passenger.Password, passenger.Phone,
                passenger.Address);
        }

        public static void InsertStaffRecord(int staffId, string email, string password)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = @"
                    INSERT INTO staff (staff_id, email, password)
                    VALUES (@staffId, @email, @password);
                ";
                command.Parameters.AddWithValue("@staffId", staffId);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@password", password);
                command.ExecuteNonQuery();
            }
        }

        public static void InsertStaffRecord(Staff staff)
        {
            InsertStaffRecord(staff.UserId, staff.Email, staff.Password);
        }

        public static void InsertTicketRecord(int ticketId, int passengerId, int flightId, SeatType seatType)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = @"
                    INSERT INTO tickets (ticket_id, passenger_id, flight_id, seat_type)
                    VALUES (@ticketId, @passengerId, @flightId, @seatType);
                ";
                command.Parameters.AddWithValue("@ticketId", ticketId);
                command.Parameters.AddWithValue("@passengerId", passengerId);
                command.Parameters.AddWithValue("@flightId", flightId);
                command.Parameters.AddWithValue("@seat_type", seatType);
                command.ExecuteNonQuery();
            }
        }

        public static int GetTicketId()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = @"
                    select count(*) from tickets
                ";
                return command.ExecuteNonQuery() + 1;
            }
        }

        // Query Methods
        public static List<Flight> QueryAllFlights()
        {
            var flights = new List<Flight>();
            using (var connection = GetConnection())
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM flights;";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        flights.Add(new Flight
                        (
                            reader.GetInt32(0),
                            reader.GetInt32(1),
                            reader.GetInt32(2),
                            reader.GetInt32(3),
                            reader.GetString(4),
                            reader.GetString(5),
                            reader.GetString(6)
                        ));
                    }
                }
            }
            return flights;
        }

        public static List<Passenger> QueryAllPassengers()
        {
            var passengers = new List<Passenger>();
            using (var connection = GetConnection())
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM passengers;";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        passengers.Add(new Passenger
                        (
                            reader.GetInt32(0),
                            reader.GetString(1),
                            reader.GetString(2),
                            reader.GetString(3),
                            reader.GetString(4),
                            reader.GetString(5)
                        ));
                    }
                }
            }
            return passengers;
        }

        public static List<Ticket> QueryAllTickets()
        {
            var tickets = new List<Ticket>();
            using (var connection = GetConnection())
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = @"
                    SELECT t.ticket_id, s.seat_type_num, p.passenger_id, f.flight_id,
                           f.first_class_seats, f.business_class_seats, f.coach_class_seats, 
                           f.destination, f.departure_time, f.departure_date 
                    FROM tickets t
                    JOIN seatTypes s ON t.seat_type_id = s.seat_type_id
                    JOIN passengers p ON t.passenger_id = p.passenger_id
                    JOIN flights f ON t.flight_id = f.flight_id;
                ";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        tickets.Add(new Ticket (
                            reader.GetInt32(0),
                            new Flight(
                                reader.GetInt32(3),
                                reader.GetInt32(4),
                                reader.GetInt32(5),
                                reader.GetInt32(6),
                                reader.GetString(7),
                                reader.GetString(8),
                                reader.GetString(9)
                            ),
                            reader.GetInt32(2),
                            (SeatType) reader.GetInt32(1)
                        ));
                    }
                }
            }
            return tickets;
        }

        public static List<Staff> QueryAllStaff()
        {
            var staffList = new List<Staff>();
            using (var connection = GetConnection())
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM staff;";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        staffList.Add(new Staff
                        (
                            reader.GetInt32(0),
                            reader.GetString(1),
                            reader.GetString(2)
                        ));
                    }
                }
            }
            return staffList;
        }
    }
}
