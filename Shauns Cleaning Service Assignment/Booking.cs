using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Shauns_Cleaning_Service_Assignment.Enums;

namespace Shauns_Cleaning_Service_Assignment
{
    public class Booking : IPerson
    {
        public Guid Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public StaffType Type { get; set; }

        public Booking(string fname, string lname, string username, string password)
        {
            Id = Guid.NewGuid();
            Fname = fname;
            Lname = lname;
            Username = username;
            Password = password;
            Type = StaffType.BOOKING;
        }

        public override string ToString()
        {
            return $"{Fname} {Lname}";
        }
    }
}