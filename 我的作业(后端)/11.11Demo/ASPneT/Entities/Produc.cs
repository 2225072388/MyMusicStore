﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Produc
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string SN { get; set; }
        public string DSCN{ get; set; }
        public virtual Category Categoty { get; set; }
        public Produc()
        {
            this.ID = Guid.NewGuid();
        }

       
    }
}
