using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shauns_Cleaning_Service_Assignment
{
    internal class CleaningSystem
    {
        public string Name { get; set; }
        public List<IProperty> Properties { get; set; }
        public List<IPerson> Person { get; set; }

        public CleaningSystem(string name)
        {
            Name = name;
            Properties = new List<IProperty>();
            Person = new List<IPerson>();
        }
    }
}
