using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace M3Layer.Models
{
    public class Student
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int LopId { get; set; }
        public virtual Lop lop { get; set; }
    }
}