using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shauns_Cleaning_Service_Assignment
{
    public interface IProperty
    {
        public Guid Id { get; set; }
        public string Address { get; set; }
        public Customer CurrentCustomer { get; set; }
        public List<Service> Services { get; set; }
    }
}
