using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Task.Entities
{
    internal class Instructor
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public int Salary { get; set; }
        public string? Address { get; set; }
        public int? Bouns { get; set; }
        public DateTime HourRate { get; set; }
        public Department Dep_id { get; set; }
    }
}
