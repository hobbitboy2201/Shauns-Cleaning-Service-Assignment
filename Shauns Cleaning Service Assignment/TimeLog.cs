using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shauns_Cleaning_Service_Assignment
{
    public class TimeLog
    {
        public Guid Id { get; set; }
        public DateTime LoggedOn { get; set; }
        public Cleaning StaffMember { get; set; }

        public TimeLog(Cleaning staffMember)
        {
            Id = Guid.NewGuid();
            LoggedOn = DateTime.Now;
            StaffMember = staffMember;
        }

        public override string? ToString()
        {
            return $"Staff Member: {StaffMember} Logged On at: {LoggedOn}";
        }

    }
}
