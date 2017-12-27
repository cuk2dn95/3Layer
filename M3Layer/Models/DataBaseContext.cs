using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace M3Layer.Models
{
    public class DataBaseContext : DbContext
    {
       public DbSet<Student> Students { set; get; }
        public DbSet<Lop> Lops { get; set; }
    }
}