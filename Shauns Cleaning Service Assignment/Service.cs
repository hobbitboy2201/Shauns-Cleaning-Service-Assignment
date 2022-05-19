using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Shauns_Cleaning_Service_Assignment.Enums;

namespace Shauns_Cleaning_Service_Assignment
{
    public class Service
    {
        public Guid Id { get; }
        public string ServiceName { get; set; }
        public Customer Customer { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Complete { get; set; }
        List<Purchase> PurchaseList { get; set; }

        public Service(string serviceName, DateTime createdOn, bool complete, Customer customer)
        {
            Id = Guid.NewGuid();
            ServiceName = serviceName;
            CreatedOn = DateTime.Now;
            Complete = complete;
            Customer = customer;
            PurchaseList = new List<Purchase>();
        }
    }
}
