using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shauns_Cleaning_Service_Assignment
{
    //Defining a new public interface IPerson
    public interface IPerson
    {
        //Delaring the variables needed for this interface
        public Guid Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
    }
}
