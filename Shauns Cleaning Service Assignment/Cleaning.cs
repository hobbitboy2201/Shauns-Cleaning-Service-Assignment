using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Shauns_Cleaning_Service_Assignment.Enums;

namespace Shauns_Cleaning_Service_Assignment
{
    //Defining a new public class Cleaning
    public class Cleaning : IPerson, IStaff //This class uses the interfaces IPerson, IStaff
    {
        //Declaring the variables that will be needed for this class
        public Guid Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public StaffType Type { get; set; }

        //Creating the constructor for this class
        public Cleaning(string fname, string lname, string username, string password)
        {
            Id = Guid.NewGuid();
            Fname = fname;
            Lname = lname;
            Username = username;
            Password = password;
            Type = StaffType.CLEANING;
        }

        //Overriding the ToString() method ,allowing me to print out the information that I want instead of the base information for this class
        public override string? ToString()
        {
            return $"{Fname} {Lname}";
        }
    }
}