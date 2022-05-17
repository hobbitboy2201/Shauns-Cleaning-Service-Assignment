using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shauns_Cleaning_Service_Assignment
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }

        public Customer(string fname, string lname)
        {
            Id = Guid.NewGuid();
            Fname = fname;
            Lname = lname;
        }
    }
}
