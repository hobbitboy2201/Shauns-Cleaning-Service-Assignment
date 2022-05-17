using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shauns_Cleaning_Service_Assignment
{
    public class MajorProblem: Service
    {
        public Guid Id { get; }
        public string ServiceName { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Open { get; set; }
        public List <Purchase> PurchaseList { get; set; }
        public Enums.IssueSeverity IssueSeverity { get; set; }

        public MajorProblem(string serviceName, bool open)
        {
            Id = Guid.NewGuid();
            ServiceName = serviceName;
            CreatedOn = DateTime.Now;
            Open = open;
            PurchaseList = new List<Purchase>();
            IssueSeverity = Enums.IssueSeverity.HIGH;
        }

        public override string? ToString()
        {
            return $"Service: {ServiceName} Created On: {CreatedOn}";
        }
    }
}
