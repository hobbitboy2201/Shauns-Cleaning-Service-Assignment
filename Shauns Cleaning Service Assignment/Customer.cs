using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shauns_Cleaning_Service_Assignment
{
    //Defining a new public class Customer
    public class Customer
    {
        //Declaring the variabels that will needed for this class
        public Guid Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }

        //Creating the constructor for this class
        public Customer(string fname, string lname) //The constuctor requires an input of a string fname, string lname
        {
            Id = Guid.NewGuid(); //Creating a new Guid
            Fname = fname;
            Lname = lname;
        }

        //Overriding the ToString() method ,allowing me to print out the information that I want instead of the base information for this class
        public override string? ToString()
        {
            return $"{Fname} {Lname}";
        }
    }
}
