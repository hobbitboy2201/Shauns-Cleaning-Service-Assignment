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
        public int AmountOfMins { get; set; }
        public DateTime LoggedOn { get; set; }
        public Cleaning StaffMember { get; set; }

        public TimeLog(int amountOfMins, Cleaning staffMember)
        {
            Id = Guid.NewGuid();
            AmountOfMins = amountOfMins;
            LoggedOn = DateTime.Now;
            StaffMember = staffMember;
        }

        public override string? ToString()
        {
            return $"Staff Member: {StaffMember} Logged On at: {LoggedOn}";
        }

    }
}
