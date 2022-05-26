using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shauns_Cleaning_Service_Assignment
{
    //Defining a new public interface IService
    public interface IService
    {
        //Declaring the variables needed for this interface
        public string ServiceName { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
