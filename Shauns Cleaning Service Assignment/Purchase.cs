using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shauns_Cleaning_Service_Assignment
{
    //Defining a new public class Purchase
    public class Purchase
    {
        //Declaring the variabels that are needed for this class
        public Guid Id { get; set; }
        public string Description { get; set; }
        public double Cost { get; set; }
        public DateTime CreatedOn { get; set; }
        public Cleaning CreatedBy { get; set; }

        //Creating the constructor for this class
        public Purchase(string description, double cost, Cleaning createdBy) //The constructor requires an input of a string description, double cost and Cleaning createdBy
        {
            Id = Guid.NewGuid(); //Creating a new Guid
            Description = description;
            Cost = cost;
            CreatedOn = DateTime.Now; //Storing teh current time
            CreatedBy = createdBy;
        }

        //Overriding the ToString() method ,allowing me to print out the information that I want instead of the base information for this class
        public override string ToString()
        {
            return $"{Description}  Created By: {CreatedBy} at {CreatedOn}  Cost: {Cost}";
        }
    }
}