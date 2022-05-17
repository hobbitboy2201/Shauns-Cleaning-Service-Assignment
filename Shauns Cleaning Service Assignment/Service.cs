using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Shauns_Cleaning_Service_Assignment.Enums;

namespace Shauns_Cleaning_Service_Assignment
{
    public interface Service
    {
        public Guid Id { get; }
        public string ServiceName { get; set; }
        public DateTime Timestamp { get; set; }
        public bool Open { get; set; }
    }
}
