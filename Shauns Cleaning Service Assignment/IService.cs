using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shauns_Cleaning_Service_Assignment
{
    public interface IService
    {
        public string ServiceName { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
