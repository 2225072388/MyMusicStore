using CodeFirstDemo.CodeFirstModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo.Migrations
{
   public class StudentsSeed
    {
        public static void Seed(CourseContext context)
        {
            var stu1 = new Students()
            {
                StudentCode = "0001",
                Name = "钟某",
                Address = "柳州铁道职业技术学院",
                Bithday = DateTime.Parse("2000-01-01"),
                Phone = "0772-3698666",
                Department = context.Departments.SingleOrDefault(x => x.Name == "电子信息工程学院")
            };
            var stu2 = new Students()
            {
                StudentCode = "0002",
                Name = "猪头陈",
                Address = "柳州铁道职业技术学院",
                Bithday = DateTime.Parse("1999-01-01"),
                Phone = "0771-12306",
                Department = context.Departments.SingleOrDefault(x => x.Name == "汽车工程学院")
            };
            var stu3 = new Students()
            {
                StudentCode = "0003",
                Name = "DF4D-0577",
                Address = "柳州铁道职业技术学院",
                Bithday = DateTime.Parse("2001-01-01"),
                Phone = "0771-12306",
                Department = context.Departments.SingleOrDefault(x => x.Name == "汽车工程学院")
            };
            var stu4 = new Students()
            {
                StudentCode = "0004",
                Name = "黄奇鑫",
                Address = "广西科技大学鹿山学院",
                Bithday = DateTime.Parse("2000-01-01"),
                Phone = "0772-966366",
                Department = context.Departments.SingleOrDefault(x => x.Name == "汽车工程学院")
            };
            var stu5 = new Students()
            {
                StudentCode = "0005",
                Name = "地下党2",
                Address = "广西民族大学相思湖学院",
                Bithday = DateTime.Parse("2000-01-01"),
                Phone = "0771-3262025",
                Department = context.Departments.SingleOrDefault(x => x.Name == "电子信息工程学院")
            };
            context.Students.Add(stu1);
            context.Students.Add(stu2);
            context.Students.Add(stu3);
            context.Students.Add(stu4);
            context.Students.Add(stu5);
            context.SaveChanges();
        }
    }
}
