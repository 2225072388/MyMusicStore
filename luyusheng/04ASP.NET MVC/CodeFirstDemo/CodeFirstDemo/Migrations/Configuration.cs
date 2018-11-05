namespace CodeFirstDemo.Migrations
{
    using CodeFirstModels;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CodeFirstDemo.CodeFirstModels.CourseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }
        //���ӷ���
        protected override void Seed(CodeFirstDemo.CodeFirstModels.CourseContext context)
        {
            //��ʼ��ѧԺ����
            var d1 = new Dopartment()
            {
                Name = "������Ϣ����ѧԺ",
                SortCode = "001",
                Description = "��һ��ѧԺ"
            };
            var d2 = new Dopartment()
            {
                Name = "���繤��ѧԺ",
                SortCode = "002",
                Description = "�ڶ���ѧԺ"
            };
            var d3 = new Dopartment()
            {
                Name = "��������ѧԺ",
                SortCode = "003",
                Description = "������ѧԺ"
            };
            var d4 = new Dopartment()
            {
                Name = "�ƾ���������ѧԺ",
                SortCode = "004",
                Description = "���Ĵ�ѧԺ"
            };
            
            context.Dopartments.Add(d1);
            context.Dopartments.Add(d2);
            context.Dopartments.Add(d3);
            context.Dopartments.Add(d4);
            context.SaveChanges();

            var c1 = new Course()
            {
                Title = "C#�������",
                Credit = 7,
                Dopartment = context.Dopartments.SingleOrDefault(x => x.Name == "������Ϣ����ѧԺ")
            };
            var c2= new Course()
            {
                Title = "MIS����ʵս",
                Credit = 17,
                Dopartment = context.Dopartments.SingleOrDefault(x => x.Name == "������Ϣ����ѧԺ")
            };
            var c3 = new Course()
            {
                Title = "WEBӦ���뿪��",
                Credit = 17,
                Dopartment = context.Dopartments.SingleOrDefault(x => x.Name == "������Ϣ����ѧԺ")
            };
            var c4 = new Course()
            {
                Title = "��ҵ��ͼ",
                Credit = 4,
                Dopartment = context.Dopartments.SingleOrDefault(x => x.Name == "���繤��ѧԺ")
            };
            var c5 = new Course()
            {
                Title = "���������",
                Credit = 6,
                Dopartment = context.Dopartments.SingleOrDefault(x => x.Name == "��������ѧԺ")
            };
            var c6 = new Course()
            {
                Title = "����Ӫ��",
                Credit = 6,
                Dopartment = context.Dopartments.SingleOrDefault(x => x.Name == "�ƾ�����������ѧԺ")
            };
            context.Courses.Add(cl);
            context.Courses.Add(c2);
            context.Courses.Add(c3);
            context.Courses.Add(c4);
            context.Courses.Add(c5);
            context.Courses.Add(c6);
            context.SaveChanges();
        }
    }
}
