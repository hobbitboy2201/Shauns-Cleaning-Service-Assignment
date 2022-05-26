using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shauns_Cleaning_Service_Assignment
{
    //Defining a new public class MajorProblem
    public class MajorProblem
    {
        //Declaring the variables that will be needed for this class
        public Guid Id { get; }
        public Service ServiceName { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Open { get; set; }
        public List <Purchase> PurchaseList { get; set; }
        public Enums.IssueSeverity IssueSeverity { get; set; }

        //Creating the constructor for this class
        public MajorProblem(Service serviceName, bool open) //The constructor requires an input of Service serviceName, bool open
        {
            Id = Guid.NewGuid(); //Creating a new Guid
            ServiceName = serviceName;
            CreatedOn = DateTime.Now; //Storing the current time
            Open = open;
            PurchaseList = new List<Purchase>(); //Creating a new List<Purchase>
            IssueSeverity = Enums.IssueSeverity.HIGH; //Assinging an enum
        }

        //Overriding the ToString() method ,allowing me to print out the information that I want instead of the base information for this class
        public override string? ToString()
        {
            return $"Service: {ServiceName} Created On: {CreatedOn}";
        }
    }
}
