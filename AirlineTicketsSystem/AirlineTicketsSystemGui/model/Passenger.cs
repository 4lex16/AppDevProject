﻿using System.Collections.Generic;

namespace AirlineTicketsSystemGui.model
{
    public class Passenger : User
    {

        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public List<Ticket> Tickets { get; set; }

        public Passenger(int userId, string email, string password, string name, string phone, string address) : base(userId, email, password)
        {
            this.UserId = userId;
            this.Email = email;
            this.Password = password;
            Name = name;
            Phone = phone;
            Address = address;
            Tickets = new List<Ticket>();
        }

        public Passenger(int userId, string email, string password, string name, string phone, string address, List<Ticket> tickets) : base(userId, email, password)
        {
            this.UserId = userId;
            this.Email = email;
            this.Password = password;
            Name = name;
            Phone = phone;
            Address = address;
            Tickets = tickets;
        }

        public override string ToString()
        {
            return $"ID:{UserId} | Name:{Name} | Ticket Count:{Tickets.Count}";
        }
    }


}