using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shauns_Cleaning_Service_Assignment
{
    public class MajorProblem
    {
        public Guid Id { get; }
        public Service ServiceName { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Open { get; set; }
        public List <Purchase> PurchaseList { get; set; }
        public Enums.IssueSeverity IssueSeverity { get; set; }

        public MajorProblem(Service serviceName, bool open)
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
