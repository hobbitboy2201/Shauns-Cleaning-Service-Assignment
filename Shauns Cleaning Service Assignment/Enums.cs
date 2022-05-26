using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shauns_Cleaning_Service_Assignment
{
    //Defining a new public class Enums
    public class Enums
    {
        //Declaring the 3 public enum variables that will be used by the other classes within this program
        public enum Nature
        {
            DOMESTIC,
            COMMERCIAL
        }

        public enum IssueSeverity
        {
            LOW,
            MEDIUM,
            HIGH
        }

        public enum StaffType
        {
            MAINTENANCE,
            CLEANING,
            BOOKING,
            ADMIN
        }
    }
}
