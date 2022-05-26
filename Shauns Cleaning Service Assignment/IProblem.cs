using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Shauns_Cleaning_Service_Assignment.Enums;

namespace Shauns_Cleaning_Service_Assignment
{
    //Defining a new public interface IProblem
    public interface IProblem
    {
        //Declaring the varibales needed for this interface
        public Guid Id { get; set; }
        public IssueSeverity IssueSeverity { get; set; }

    }
}
