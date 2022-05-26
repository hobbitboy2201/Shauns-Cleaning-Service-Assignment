using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Shauns_Cleaning_Service_Assignment.Enums;

namespace Shauns_Cleaning_Service_Assignment
{
    //Defining a new public interface IStaff
    public interface IStaff
    {
        //Declaring the variables needed for this interface
        public string Username { get; set; }
        public string Password { get; set; }

        public StaffType Type { get; set; }
    }
}
