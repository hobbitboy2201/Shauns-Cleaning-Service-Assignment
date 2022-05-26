using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Shauns_Cleaning_Service_Assignment.Enums;

namespace Shauns_Cleaning_Service_Assignment
{
    //Defining a new public class Service
    public class Service
    {
        //Declaring the varibales that are needed for this class
        public Guid Id { get; }
        public string ServiceName { get; set; }
        public Customer Customer { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Complete { get; set; }
        public Building Building { get; set; }
        List<Purchase> PurchaseList { get; set; }

        //Creating the constructor for this class
        public Service(string serviceName, bool complete, Customer customer, Building building) //The constructr requres an input of a string serviceName, bool complete, Customer customer and Building building
        {
            Id = Guid.NewGuid(); //Creating a new Guid
            ServiceName = serviceName;
            CreatedOn = DateTime.Now; //Storing the current time
            Complete = complete;
            Customer = customer;
            Building = building;
            PurchaseList = new List<Purchase>();
        }

        //Overriding the ToString() method ,allowing me to print out the information that I want instead of the base information for this class
        public override string ToString()
        {
            return $"ServiceName: {ServiceName}   Created On {CreatedOn}";
        }
    }
}
