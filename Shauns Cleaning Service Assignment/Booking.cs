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
        public IStaff Staff { get; set; }
        public StaffType Type { get; set; }

        public Booking(string fname, string lname, IStaff staff)
        {
            Id = Guid.NewGuid();
            Fname = fname;
            Lname = lname;
            Staff = staff;
            Type = StaffType.BOOKING;
        }
    }
}