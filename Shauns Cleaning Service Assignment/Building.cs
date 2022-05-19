using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Shauns_Cleaning_Service_Assignment.Enums;

namespace Shauns_Cleaning_Service_Assignment
{
    public class Building: IProperty
    {
        public Guid Id { get; set; }
        public string Address { get; set; }
        public Nature Type { get; set; }
        public List<Service> Services { get; set; }
        public Customer CurrentCustomer { get; set; }

        public Building(string address, Nature type, Customer currentCustomer)
        {
            Id = Guid.NewGuid();
            Address = address;
            Type = type;
            Services = new List<Service>();
            CurrentCustomer = currentCustomer;
        }

        public override string ToString()
        {
            return $"Building Type: {Type}  Address: {Address}  Customer: {CurrentCustomer.Fname} {CurrentCustomer.Lname}";
        }
    }
}
