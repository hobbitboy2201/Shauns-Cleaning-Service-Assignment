using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shauns_Cleaning_Service_Assignment
{
    //Defining a new private class CleaningSystem
    internal class CleaningSystem
    {
        //Declaring the variables that will be needed for this class
        public string Name { get; set; }
        public List<IProperty> Properties { get; set; }
        public List<IPerson> Person { get; set; }

        //Creating the construstor for this class
        public CleaningSystem(string name) //The constructor requires the input of a string name
        {
            Name = name;
            Properties = new List<IProperty>();
            Person = new List<IPerson>();
        }
    }
}
