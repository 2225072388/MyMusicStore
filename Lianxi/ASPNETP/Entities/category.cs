﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// hao 
/// </summary>

namespace Entities
{
    public class category
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string SortCode{get;set;}
            public category ()
        {
            this.ID = Guid.NewGuid();
        }
    }
}
