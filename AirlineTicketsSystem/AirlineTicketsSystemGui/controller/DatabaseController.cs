using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;
using AirlineTicketsSystemGui.model;
using Microsoft.Data.Sqlite;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace AirlineTicketsSystemGui.controller
{
    public class DatabaseController
    {
        private static readonly string DatabaseFileName = @"Data Source=..\..\Files\AirlineTicketsSystemDatabase.db;Version=3;";
        private static string dbFilePath = @"..\..\Files\AirlineTicketsSystemDatabase.db";

        public static void InitializeDatabase()
        {
            string dbFilePath = @"..\..\Files\AirlineTicketsSystemDatabase.db";
            string directoryPath = Path.GetDirectoryName(dbFilePath);

            // Ensure the directory exists
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            // Check if the database file exists, and create it if it doesn't
            if (!File.Exists(dbFilePath))
            {
                SQLiteConnection.CreateFile(dbFilePath);
            }
        }

        // Table Creation Methods
        public static void CreateFlightTable()
        {
            if (!File.Exists(dbFilePath))
            {
                SQLiteConnection.CreateFile(dbFilePath);
            }

            using (var connection = new SQLiteConnection(DatabaseFileName))
            {
                connection.Open();
                string createTable =
                @"
                    CREATE TABLE IF NOT EXISTS flights (
                        flight_id INTEGER PRIMARY KEY AUTOINCREMENT,
                        first_class_seats INTEGER NOT NULL,
                        business_class_seats INTEGER NOT NULL,
                        coach_class_seats INTEGER NOT NULL,
                        destination TEXT,
                        departure_time TEXT,
                        departure_date TEXT
                    );
                ";
                using (var command = new SQLiteCommand(connection))
                {
                    command.CommandText = createTable;
                    command.ExecuteNonQuery();
                }

            }

        }

        // Create Table Methods
        public static void CreateTicketTable()
        {
            if (!File.Exists(dbFilePath))
            {
                SQLiteConnection.CreateFile(dbFilePath);
            }

            using (var connection = new SQLiteConnection(DatabaseFileName))
            {
                connection.Open();
                string createTable =
                @"
                        CREATE TABLE IF NOT EXISTS tickets (
                        ticket_id INTEGER PRIMARY KEY AUTOINCREMENT,
                        passenger_id INTEGER,
                        flight_id INTEGER,
                        seat_type INTEGER,
                        FOREIGN KEY (seat_type) REFERENCES seatTypes(seat_type),
                        FOREIGN KEY (passenger_id) REFERENCES passengers(passenger_id),
                        FOREIGN KEY (flight_id) REFERENCES flights(flight_id)
                        );
                    ";

                using (var command = new SQLiteCommand(createTable, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void CreateStaffTable()
        {
            if (!File.Exists(dbFilePath))
            {
                SQLiteConnection.CreateFile(dbFilePath);
            }

            using (var connection = new SQLiteConnection(DatabaseFileName))
            {
                connection.Open();
                string createTable =
                @"
                        CREATE TABLE IF NOT EXISTS staff (
                        staff_id INTEGER PRIMARY KEY AUTOINCREMENT,
                        email TEXT,
                        password TEXT
                        );
                    ";

                using (var command = new SQLiteCommand(createTable, connection))
                {
                    command.ExecuteNonQuery();
                }
            }

        }

        public static void CreatePassengerTable()
        {
            if (!File.Exists(dbFilePath))
            {
                SQLiteConnection.CreateFile(dbFilePath);
            }


            using (var connection = new SQLiteConnection(DatabaseFileName))
            {
                connection.Open();
                string createTable =
                @"
                        CREATE TABLE IF NOT EXISTS passengers (
                        passenger_id INTEGER PRIMARY KEY AUTOINCREMENT,
                        passenger_name TEXT,
                        passenger_email TEXT,
                        passenger_password TEXT,
                        passenger_phone_number TEXT,
                        passenger_address TEXT
                        );
                    ";

                using (var command = new SQLiteCommand(createTable, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        // Insert Methods
        public static void InsertFlightRecord(int firstClass, int businessClass, int coachClass, string destination, string departureTime, string departureDate)
        {
            if (!File.Exists(dbFilePath))
            {
                SQLiteConnection.CreateFile(dbFilePath);
            }

            using (var connection = new SQLiteConnection(DatabaseFileName))
            {
                connection.Open();
                string insertQuery =
                @"
                        INSERT INTO flights ( first_class_seats, business_class_seats, coach_class_seats, destination, departure_time, departure_date)
                        VALUES (@firstClass, @businessClass, @coachClass, @destination, @departureTime, @departureDate);
                ";

                using (var command = new SQLiteCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@firstClass", firstClass);
                    command.Parameters.AddWithValue("@businessClass", businessClass);
                    command.Parameters.AddWithValue("@coachClass", coachClass);
                    command.Parameters.AddWithValue("@destination", destination);
                    command.Parameters.AddWithValue("@departureTime", departureTime);
                    command.Parameters.AddWithValue("@departureDate", departureDate);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void InsertFlightRecord(Flight flight)
        {
            InsertFlightRecord(flight.FirstClassSeats, flight.BusinessClassSeats, flight.CoachClassSeats,
                flight.Destination, flight.DepartureTime, flight.DepartureDate);
        }

        public static void InsertPassengerRecord(string fullName, string email, string password, string phone, string address)
        {
            if (!File.Exists(dbFilePath))
            {
                SQLiteConnection.CreateFile(dbFilePath);
            }

            using (var connection = new SQLiteConnection(DatabaseFileName))
            {
                connection.Open();
                string insertQuery =
                @"
                        INSERT INTO passengers (passenger_name, passenger_email, passenger_password, passenger_phone_number, passenger_address)
                        VALUES (@name, @email, @password, @phone, @address);
                    ";

                using (var command = new SQLiteCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@name", fullName);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@phone", phone);
                    command.Parameters.AddWithValue("@address", address);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void InsertPassengerRecord(Passenger passenger)
        {
            InsertPassengerRecord(passenger.Name, passenger.Email, passenger.Password, passenger.Phone, passenger.Address);
        }

        public static void InsertStaffRecord(string email, string password)
        {
            if (!File.Exists(dbFilePath))
            {
                SQLiteConnection.CreateFile(dbFilePath);
            }

            using (var connection = new SQLiteConnection(DatabaseFileName))
            {
                connection.Open();
                string insertQuery =
                @"
                    INSERT INTO staff (email, password)
                    VALUES (@email, @password);
                ";

                using (var command = new SQLiteCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@password", password);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void UpdateStaffRecord(int staffId, string email, string password)
        {
            if (!File.Exists(dbFilePath))
            {
                SQLiteConnection.CreateFile(dbFilePath);
            }

            using (var connection = new SQLiteConnection(DatabaseFileName))
            {
                connection.Open();

                // Check if the record exists
                string checkQuery = "SELECT COUNT(1) FROM staff WHERE staff_id = @staffId";
                using (var checkCommand = new SQLiteCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@staffId", staffId);
                    long recordExists = (long)checkCommand.ExecuteScalar();

                    if (recordExists == 0)
                    {
                        MessageBox.Show($"No staff record found with StaffID {staffId}");
                        return;
                    }
                }

                // Update the record if it exists
                string updateQuery =
                @"
                    UPDATE staff
                    SET email = @newEmail, password = @newPassword
                    WHERE staff_id = @staffId;
                ";

                using (var command = new SQLiteCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@staffId", staffId);
                    command.Parameters.AddWithValue("@newEmail", email);
                    command.Parameters.AddWithValue("@newPassword", password);
                    command.ExecuteNonQuery();
                }
                MessageBox.Show("Staff Information Successfuly Changed");
            }
        }

        public static void InsertStaffRecord(Staff staff)
        {
            InsertStaffRecord(staff.Email, staff.Password);
        }

        public static void InsertTicketRecord(int passengerId, int flightId, SeatType seatType)
        {
            if (!File.Exists(dbFilePath))
            {
                SQLiteConnection.CreateFile(dbFilePath);
            }

            using (var connection = new SQLiteConnection(DatabaseFileName))
            {
                connection.Open();
                string insertQuery =
                @"
                        INSERT INTO tickets (passenger_id, flight_id, seat_type)
                        VALUES (@passengerId, @flightId, @seatType);
                    ";

                using (var command = new SQLiteCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@passengerId", passengerId);
                    command.Parameters.AddWithValue("@flightId", flightId);
                    command.Parameters.AddWithValue("@seatType", seatType);
                    command.ExecuteReader();
                }
            }
        }

        // Query Methods
        public static List<Flight> QueryAllFlights()
        {
            var flights = new List<Flight>();

            // Check if the database file exists, and create it if it doesn't
            if (!File.Exists(dbFilePath))
            {
                SQLiteConnection.CreateFile(dbFilePath);
            }

            using (var connection = new SQLiteConnection(DatabaseFileName))
            {
                connection.Open();
                string query = "SELECT * FROM flights;";

                using (var command = new SQLiteCommand(query, connection))
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

            // Check if the database file exists, and create it if it doesn't
            if (!File.Exists(dbFilePath))
            {
                try
                {
                    SQLiteConnection.CreateFile(dbFilePath);

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            using (var connection = new SQLiteConnection(DatabaseFileName))
            {
                connection.Open();
                string query = "SELECT * FROM passengers";

                using (var command = new SQLiteCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int userId = reader.GetInt32(0);
                        passengers.Add(new Passenger
                        (
                            userId,
                            reader.GetString(2),
                            reader.GetString(3),
                            reader.GetString(1),
                            reader.GetString(4),
                            reader.GetString(5),
                            QueryTicketsByUserId(userId)
                        ));
                    }
                }
            }

            return passengers;
        }

        public static List<Ticket> QueryAllTickets()
        {
            var tickets = new List<Ticket>();

            // Check if the database file exists, and create it if it doesn't
            if (!File.Exists(dbFilePath))
            {
                SQLiteConnection.CreateFile(dbFilePath);
            }

            using (var connection = new SQLiteConnection(DatabaseFileName))
            {
                connection.Open();
                string query =
                @"
                    SELECT t.ticket_id, t.seat_type, p.passenger_id, f.flight_id,
                    f.first_class_seats, f.business_class_seats, f.coach_class_seats, 
                    f.destination, f.departure_time, f.departure_date 
                    FROM tickets t
                    JOIN passengers p ON t.passenger_id = p.passenger_id
                    JOIN flights f ON t.flight_id = f.flight_id;
                ";

                using (var command = new SQLiteCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        tickets.Add(new Ticket(
                            reader.GetInt32(0),
                            new Flight(
                                reader.GetInt32(3),
                                reader.GetInt32(4),
                                reader.GetInt32(5),
                                reader.GetInt32(6),
                                reader.GetString(7),
                                reader.GetString(9),
                                reader.GetString(8)
                            ),
                            reader.GetInt32(2),
                            (SeatType)reader.GetInt32(1)
                        ));
                    }
                }
            }
            return tickets;
        }

        public static List<Staff> QueryAllStaff()
        {
            var staffList = new List<Staff>();

            // Check if the database file exists, and create it if it doesn't
            if (!File.Exists(dbFilePath))
            {
                SQLiteConnection.CreateFile(dbFilePath);
            }

            using (var connection = new SQLiteConnection(DatabaseFileName))
            {
                connection.Open();
                string query = "SELECT * FROM staff;";

                using (var command = new SQLiteCommand(query, connection))
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

        public static int GetTicketId()
        {
            int ticketId = 0;

            // Check if the database exists
            if (!File.Exists(dbFilePath))
            {
                SQLiteConnection.CreateFile(dbFilePath);
            }

            using (var connection = new SQLiteConnection(DatabaseFileName))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM tickets;";

                using (var command = new SQLiteCommand(query, connection))
                {
                    // ExecuteScalar will return the count of rows in the tickets table
                    ticketId = Convert.ToInt32(command.ExecuteScalar()) + 1;
                }
            }
            return ticketId;
        }

        public static void RemoveStaff(int staffId)
        {
            // Check if the database exists
            if (!File.Exists(dbFilePath))
            {
                SQLiteConnection.CreateFile(dbFilePath);
            }

            using (var connection = new SQLiteConnection(DatabaseFileName))
            {
                connection.Open();
                string sql = @"DELETE FROM staff WHERE staff_id = @staffId";

                using (var command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@staffId", staffId);
                    command.ExecuteReader();
                }
            }
        }

        public static void RemoveFlight(int flightId)
        {
            // Check if the database exists
            if (!File.Exists(dbFilePath))
            {
                SQLiteConnection.CreateFile(dbFilePath);
            }

            using (var connection = new SQLiteConnection(DatabaseFileName))
            {
                connection.Open();
                string sql = @"DELETE FROM flights WHERE flight_id = @flightId";

                using (var command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@flightId", flightId);
                    command.ExecuteReader();
                }
            }
        }

        public static List<Ticket> QueryTicketsByUserId(int userId)
        {
            var tickets = new List<Ticket>();

            if (!File.Exists(dbFilePath))
            {
                SQLiteConnection.CreateFile(dbFilePath);
            }

            using (var connection = new SQLiteConnection(DatabaseFileName))
            {
                connection.Open();
                string query =
                @"
                    SELECT t.ticket_id, t.seat_type, p.passenger_id, f.flight_id,
                    f.first_class_seats, f.business_class_seats, f.coach_class_seats, 
                    f.destination, f.departure_time, f.departure_date 
                    FROM tickets t
                    JOIN passengers p ON t.passenger_id = p.passenger_id
                    JOIN flights f ON t.flight_id = f.flight_id
                    WHERE t.passenger_id = @userId";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userId", userId);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            tickets.Add(new Ticket(
                                reader.GetInt32(0),
                                new Flight(
                                    reader.GetInt32(3),
                                    reader.GetInt32(4),
                                    reader.GetInt32(5),
                                    reader.GetInt32(6),
                                    reader.GetString(7),
                                    reader.GetString(9),
                                    reader.GetString(8)
                                ),
                                reader.GetInt32(2),
                                (SeatType)reader.GetInt32(1)
                            ));
                        }
                    }
                }
            }
            return tickets;

        }




        public static Flight ReturnLastFlight()
        {
            Flight flight;

            if (!File.Exists(dbFilePath))
            {
                SQLiteConnection.CreateFile(dbFilePath);
            }

            using (var connection = new SQLiteConnection(DatabaseFileName))
            {
                string query =
                @"
                    SELECT * FROM flights
                ";

                using (var command = new SQLiteCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    ;
                    //int flightId, int firstClassSeats, int businessClassSeats, int coachClassSeats, string destination, string departureDate, string departureTime
                    flight = new Flight(
                        reader.GetInt32(0),
                        reader.GetInt32(1),
                        reader.GetInt32(2),
                        reader.GetInt32(3),
                        reader.GetString(4),
                        reader.GetString(5),
                        reader.GetString(6)
                        );
                }

            }
            return flight;

        }
        public static Ticket ReturnLastTicket()
        {
            Ticket ticket;

            if (!File.Exists(dbFilePath))
            {
                SQLiteConnection.CreateFile(dbFilePath);
            }

            using (var connection = new SQLiteConnection(DatabaseFileName))
            {
                string query =
                @"
                    SELECT tickets.ticket_id, tickets.passenger_id, tickets.flight_id, tickets.seat_type, flights.first_class_seats
                    flights.business_class_seats, flights.coach_class_seats, flights.destination, flights.departure_time, flights.departure_dat 
                    FROM tickets
                    JOIN flights ON tickets.flight_id = flights.flight_id
                    WHERE ticket_id = (SELECT MAX(ticket_id) FROM tickets)
                ";

                using (var command = new SQLiteCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    //int ticketId, Flight flight, int passengerId, SeatType seatTyp
                    ticket = new Ticket(
                        reader.GetInt32(0),
                        //int flightId, int firstClassSeats, int businessClassSeats, int coachClassSeats, string destination, string departureDate, string departureTime
                        new Flight(
                            reader.GetInt32(2),
                            reader.GetInt32(4),
                            reader.GetInt32(5),
                            reader.GetInt32(6),
                            reader.GetString(7),
                            reader.GetString(8),
                            reader.GetString(9)
                            ),
                        reader.GetInt32(1),
                        (SeatType)reader.GetInt32(3)
                        );
                }
            }
            return ticket;
        }

        public static Staff ReturnLastStaff()
        {
            Staff staff;
            if (!File.Exists(dbFilePath))
            {
                SQLiteConnection.CreateFile(dbFilePath);
            }

            using (var connection = new SQLiteConnection(DatabaseFileName))
            {
                string query =
                @"
                    SELECT * FROM staff WHERE staff_id = (SELECT MAX(staff_id) FROM staff)
                ";

                using (var command = new SQLiteCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    staff = new Staff(
                        reader.GetInt32(0),
                        reader.GetString(1),
                        reader.GetString(2)
                        );
                }
            }

            return staff;
        }
        public static Passenger ReturnLastPassenger()
        {
            Passenger passenger;
            if (!File.Exists(dbFilePath))
            {
                SQLiteConnection.CreateFile(dbFilePath);
            }

            using (var connection = new SQLiteConnection(DatabaseFileName))
            {
                string query =
                @"
                    SELECT * FROM passengers WHERE passenger_id = (SELECT MAX(passenger_id) FROM passengers)
                ";

                using (var command = new SQLiteCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    passenger = new Passenger(
                        reader.GetInt32(0),
                        reader.GetString(2),
                        reader.GetString(3),
                        reader.GetString(1),
                        reader.GetString(4),
                        reader.GetString(5)
                        );
                }
            }

            return passenger;
        }
        public static void AddFcTicket(int flightId)
        {
            connection.Open();
            string query = @"UPDATE flight 
                                 SET first_class_seats = first_class_seats - 1 
                                 WHERE flight_id = @flightId";
            using (var command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@flightId", flightId);
                command.ExecuteReader();
            }
        }

        public static void AddBcTicket(int flightId)
        {
            connection.Open();
            string query = @"UPDATE flight 
                                 SET business_class_seats = business_class_seats - 1 
                                 WHERE flight_id = @flightId";
            using (var command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@flightId", flightId);
                command.ExecuteReader();
            }
        }
        public static void AddCcTicket(int flightId)
        {
            connection.Open();
            string query = @"UPDATE flight 
                                 SET coach_class_seats = coach_class_seats - 1 
                                 WHERE flight_id = @flightId";
            using (var command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@flightId", flightId);
                command.ExecuteReader();
            }
        }
    }
}
