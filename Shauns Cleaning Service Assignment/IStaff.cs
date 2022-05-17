using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Shauns_Cleaning_Service_Assignment.Enums;

namespace Shauns_Cleaning_Service_Assignment
{
    public interface IStaff
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public StaffType Type { get; set; }
    }
}
