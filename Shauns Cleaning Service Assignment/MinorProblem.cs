using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shauns_Cleaning_Service_Assignment
{
    //Defining a new public class MinorProblem
    public class MinorProblem
    {
        //Declaring the variables that will be needed for this class
        public Guid Id { get; set; }
        public Service ServiceName { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Open { get; set; }
        public List <Purchase> PurchaseList { get; set;}
        public Enums.IssueSeverity IssueSeverity { get; set; }

        //Creating the costructor for this class
        public MinorProblem(Service serviceName, bool open) //The constructor requires an input of a Service sericeName, bool open
        {
            Id = Guid.NewGuid(); //Creating a new Guid
            ServiceName = serviceName;
            CreatedOn = DateTime.Now; //Storing the curren time
            Open = open;
            PurchaseList = new List<Purchase>(); //Creating a new List<Purchase>
            IssueSeverity = Enums.IssueSeverity.LOW; //Assigning an enum
        }

        //Overriding the ToString() method ,allowing me to print out the information that I want instead of the base information for this class
        public override string? ToString()
        {
            return $"Service: {ServiceName} Created On: {CreatedOn}";
        }
    }
}
