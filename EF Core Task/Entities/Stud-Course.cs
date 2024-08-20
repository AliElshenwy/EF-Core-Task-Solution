using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Task.Entities
{
    internal class Stud_Course
    {
        public int stud_Id { get; set; }
        public int Course_Id { get; set; }
        public double Grade { get; set; }
    }
}
