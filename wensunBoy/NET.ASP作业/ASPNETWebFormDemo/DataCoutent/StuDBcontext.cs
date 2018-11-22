using ASPNETWebFormDemo.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuContext
{
     public class StuDBcontext:DbContext
    {
        public DbSet<DepartMent> DepartMents { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
