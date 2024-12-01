using System;
using System.Collections.Generic;
using System.Data;
using AirlineTicketsSystemGui.model;
using Microsoft.Data.Sqlite;

namespace AirlineTicketsSystemGui.controller
{
    public class DatabaseController
    {
        private const string DatabaseFileName = "Data Source=path/to/your/database.db"; // Update the path

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
                    CREATE TABLE IF NOT EXISTS Flights (
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
                    CREATE TABLE IF NOT EXISTS Tickets (
                        ticket_id INTEGER PRIMARY KEY,
                        seatType_id INTEGER,
                        passenger_id INTEGER,
                        flight_id INTEGER,
                        FOREIGN KEY (passenger_id) REFERENCES Passengers(passenger_id),
                        FOREIGN KEY (flight_id) REFERENCES Flights(flight_id),
                        FOREIGN KEY (seatType_id) REFERENCES SeatType(seatType_id)
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
                    CREATE TABLE IF NOT EXISTS Staff (
                        staff_id INTEGER PRIMARY KEY,
                        email TEXT,
                        password TEXT
                    );
                ";
                command.ExecuteNonQuery();
            }
        }

        public static void CreateSeatTypeTable()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = @"
                    CREATE TABLE IF NOT EXISTS SeatTypes (
                        seatType_id INTEGER PRIMARY KEY,
                        seat_type TEXT,
                        seat_type_num INTEGER
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
                    CREATE TABLE IF NOT EXISTS Passengers (
                        passenger_id INTEGER PRIMARY KEY,
                        passenger_name TEXT,
                        passenger_email TEXT,
                        passenger_password TEXT,
                        passenger_phoneNumber TEXT,
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
                    INSERT INTO Flights (flight_id, first_class_seats, business_class_seats, coach_class_seats, destination, departure_time, departure_date)
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
        

        public static void InsertPassengerRecord(int passengerId, string fullName, string email, string password, string phone, string address)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = @"
                    INSERT INTO Passengers (passenger_id, passenger_name, passenger_email, passenger_password, passenger_phoneNumber, passenger_address)
                    VALUES (@passenger_id, @passenger_name, @passenger_email, @passenger_password, @passenger_phoneNumber, @passenger_address);
                ";
                command.Parameters.AddWithValue("@passenger_id", passengerId);
                command.Parameters.AddWithValue("@passenger_name", fullName);
                command.Parameters.AddWithValue("@passenger_email", email);
                command.Parameters.AddWithValue("@passenger_password", password);
                command.Parameters.AddWithValue("@passenger_phoneNumber", phone);
                command.Parameters.AddWithValue("@passenger_address", address);
                command.ExecuteNonQuery();
            }
        }

        public static void InsertPassengerRecord(Passenger passenger)
        {
            InsertPassengerRecord(passenger.UserId, passenger.Name, passenger.Email, passenger.Password, passenger.Phone, passenger.Address);
        }

        public static void InsertStaffRecord(int staffId, string email, string password)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = @"
                    INSERT INTO Staff (StaffId, Email, Password)
                    VALUES (@staffId, @Email, @Password);
                ";
                command.Parameters.AddWithValue("@staffId", staffId);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);
                command.ExecuteNonQuery();
            }
        }

        public static void InserStaffRecord(Staff staff)
        {
            InsertStaffRecord(staff.UserId, staff.Email, staff.Password);
        }

        public static void InsertTicketRecord(int ticketId, int seatTypeId, int passengerId, int flightId)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = @"
                    INSERT INTO Tickets (TicketId, SeatTypeId, PassengerId, FlightId)
                    VALUES (@ticketId, @seatTypeId, @passengerId, @flightId);
                ";
                command.Parameters.AddWithValue("@ticketId", ticketId);
                command.Parameters.AddWithValue("@seatTypeId", seatTypeId);
                command.Parameters.AddWithValue("@passengerId", passengerId);
                command.Parameters.AddWithValue("@flightId", flightId);
                command.ExecuteNonQuery();
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
                command.CommandText = "SELECT * FROM Flights;";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        flights.Add(new Flight
                        {
                            FlightId = reader.GetInt32(0),
                            FirstClassSeats = reader.GetInt32(1),
                            BusinessClassSeats = reader.GetInt32(2),
                            CoachClassSeats = reader.GetInt32(3),
                            Destination = reader.GetString(4),
                            DepartureDate = reader.GetString(5),
                            DepartureTime = reader.GetString(6)
                        });
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
                command.CommandText = "SELECT * FROM Passengers;";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        passengers.Add(new Passenger
                        {
                            UserId = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Email = reader.GetString(2),
                            Password = reader.GetString(3),
                            Phone = reader.GetString(4),
                            Address = reader.GetString(5)
                        });
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
                    SELECT TicketId, seat_type_num, PassengerId, FlightId FROM Tickets JOIN SeatType 
                    ON Tickets.SeatTypeId = SeatType.Id;
";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        tickets.Add(new Ticket
                        {
                            TicketId = reader.GetInt32(0),
                            SeatType = (SeatType)reader.GetInt32(1),
                            Passenger = new Passenger { UserId = reader.GetInt32(2) },
                            Flight = new Flight { FlightId = reader.GetInt32(3) }
                        });
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
                command.CommandText = "SELECT * FROM Staff;";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        staffList.Add(new Staff
                        {
                            UserId = reader.GetInt32(0),
                            Email = reader.GetString(1),
                            Password = reader.GetString(2)
                        });
                    }
                }
            }
            return staffList;
        }
    }
}
