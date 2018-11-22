using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVCDemo1.Models
{
    public class MovieDBContext:DbContext
    {
        //上下文
        public DbSet<Movie> Movies { get; set; }
    }
}