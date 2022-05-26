using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Shauns_Cleaning_Service_Assignment.Enums;

namespace Shauns_Cleaning_Service_Assignment
{
    //Defining a new public class Building
    public class Building: IProperty //This class uses the interface IProperty
    {
        //Declaring the variables that will be needed for this class
        public Guid Id { get; set; }
        public string Address { get; set; }
        public Nature Type { get; set; }
        public List<Service> Services { get; set; }
        public Customer CurrentCustomer { get; set; }

        //Creating the constructor for this class
        public Building(string address, Nature type, Customer currentCustomer) //The constructor requires an input of string address, Nature type, Customer currentCustomer
        {
            Id = Guid.NewGuid(); //Creatnng a new Guid
            Address = address;
            Type = type;
            Services = new List<Service>(); //Creatng a new List<Service>
            CurrentCustomer = currentCustomer;
        }

        //Overriding the ToString() method ,allowing me to print out the information that I want instead of the base information for this class
        public override string ToString()
        {
            return $"Building Type: {Type}  Address: {Address}  Customer: {CurrentCustomer.Fname} {CurrentCustomer.Lname}";
        }
    }
}
