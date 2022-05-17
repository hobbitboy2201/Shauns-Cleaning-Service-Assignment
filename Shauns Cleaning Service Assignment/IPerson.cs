using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shauns_Cleaning_Service_Assignment
{
    public interface IPerson
    {
        public Guid Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
    }
}
