﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Task.Entities
{
    
    internal class Course_Inst
    {
        public int ins_ID { get; set; }
        public int Course_ID { get; set; }
        public string evaluation { get; set; }
    }
}
