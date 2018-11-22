using CodeFirstDemo.CodeFirstModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new CourseContext())
            {
                //Console.WriteLine("ef初始化");
                var students = new CourseContext().Students.OrderBy(x => x.StudentCode).ToList();
                foreach (var s in students)
                    Console.WriteLine(s.Name);
            }

                
        }
    }
}
