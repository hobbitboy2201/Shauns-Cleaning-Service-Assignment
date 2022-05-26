using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shauns_Cleaning_Service_Assignment
{
    //Defining a new public class TimeLog
    public class TimeLog
    {
        //Declaring the variables that are needed for this class
        public Guid Id { get; set; }
        public DateTime LoggedOn { get; set; }
        public Cleaning StaffMember { get; set; }

        //Creating the constructor for this class
        public TimeLog(Cleaning staffMember) //The constructor requires an input of a Cleaning staffMember
        {
            Id = Guid.NewGuid(); //Creating a new Guid
            LoggedOn = DateTime.Now; //Storing the current time
            StaffMember = staffMember;
        }

        //Overriding the ToString() method ,allowing me to print out the information that I want instead of the base information for this class
        public override string? ToString()
        {
            return $"Staff Member: {StaffMember} Logged On at: {LoggedOn}";
        }

    }
}
