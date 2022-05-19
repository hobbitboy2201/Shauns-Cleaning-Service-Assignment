using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shauns_Cleaning_Service_Assignment
{
    public class Purchase
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public double Cost { get; set; }
        public DateTime CreatedOn { get; set; }
        public Cleaning CreatedBy { get; set; }

        public Purchase(string description, double cost, Cleaning createdBy)
        {
            Id = Guid.NewGuid();
            Description = description;
            Cost = cost;
            CreatedOn = DateTime.Now;
            CreatedBy = createdBy;
        }

        public override string ToString()
        {
            return $"{Description}  Created By: {CreatedBy} at {CreatedOn}  Cost: {Cost}";
        }
    }
}