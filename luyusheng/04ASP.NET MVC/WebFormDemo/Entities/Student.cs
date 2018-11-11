﻿using StuEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuEntities
{
    
   public class Student
    {
        public Guid ID { get; set; }
        public string StudentNo { get; set; }
        public string FirstName { get; set; }//姓
        public string LastName { get; set; }//名
        public string FullName { get; set; }
        public string Sex { get; set; }
        public DateTime BirthDay { get; set; } = DateTime.Parse("1998-01-01");
        public string Address { get; set; }
        public string Phone { get; set; }
        public virtual DopartMent Dopartment { get; set; }

        public Student()
        {
            ID = Guid.NewGuid();
        }
        public string GetFullName()
        {
            this.FullName = this.FirstName + this.LastName;
            return this.FirstName;
        }
    }
}