using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shauns_Cleaning_Service_Assignment
{
    //Defining a new public interface IProperty
    public interface IProperty
    {
        //Declaring the variables needed for ths interface
        public Guid Id { get; set; }
        public string Address { get; set; }
        public Customer CurrentCustomer { get; set; }
        public List<Service> Services { get; set; }
    }
}
