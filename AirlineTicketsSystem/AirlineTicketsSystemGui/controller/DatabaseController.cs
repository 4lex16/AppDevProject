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
                        FlightId INTEGER PRIMARY KEY,
                        SeatAvailability TEXT
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
                        TicketId INTEGER PRIMARY KEY,
                        SeatTypeId INTEGER,
                        PassengerId INTEGER,
                        FlightId INTEGER,
                        FOREIGN KEY (PassengerId) REFERENCES Passengers(UserId),
                        FOREIGN KEY (FlightId) REFERENCES Flights(FlightId)
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
                        StaffId INTEGER PRIMARY KEY,
                        Email TEXT,
                        Password TEXT
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
                        SeatTypeId INTEGER PRIMARY KEY,
                        Description TEXT
                    );
                ";
                command.ExecuteNonQuery();
            }
        }

        // Insert Methods
        public static void InsertFlightRecord(int flightId, string seatAvailability)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = @"
                    INSERT INTO Flights (FlightId, SeatAvailability)
                    VALUES (@flightId, @seatAvailability);
                ";
                command.Parameters.AddWithValue("@flightId", flightId);
                command.Parameters.AddWithValue("@seatAvailability", seatAvailability);
                command.ExecuteNonQuery();
            }
        }

        public static void InsertPassengerRecord(int userId, string email, string password, string phone, string address)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = @"
                    INSERT INTO Passengers (UserId, Email, Password, Phone, Address)
                    VALUES (@userId, @Email, @Password, @Phone, @Address);
                ";
                command.Parameters.AddWithValue("@userId", userId);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);
                command.Parameters.AddWithValue("@Phone", phone);
                command.Parameters.AddWithValue("@Address", address);
                command.ExecuteNonQuery();
            }
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
                command.CommandText = "SELECT FlightId, SeatAvailability FROM Flights;";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        flights.Add(new Flight
                        {
                            FlightId = reader.GetInt32(0),
                            SeatAvailability = reader.GetString(1)
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
                command.CommandText = "SELECT UserId, Email, Password, Phone, Address FROM Passengers;";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        passengers.Add(new Passenger
                        {
                            UserId = reader.GetInt32(0),
                            Email = reader.GetString(1),
                            Password = reader.GetString(2),
                            Phone = reader.GetString(3),
                            Address = reader.GetString(4)
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
