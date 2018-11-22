namespace MVC5Demo.Migrations
{
    using MvcDemo.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MvcDemo.Models.MovieDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(MvcDemo.Models.MovieDBContext context)
        {
            // context.Database.ExecuteSqlCommand("delete movies"); //ɾ��ԭ�м�¼ ���ظ�
            var m1 = new Movie()
            {
                Titile = "�������׸�",
                ReleaseDate = DateTime.Parse("2018 - 11 - 01"),
                Genre = "��Ц  ����",
                Price = 380.00M
            };
            var m2 = new Movie()
            {
                Titile = "�Ҳ���ҩ��",
                ReleaseDate = DateTime.Parse("2018 - 11 - 10"),
                Genre = "��Ц  ����",
                Price = 400.00M
            };
            var m3 = new Movie()
            {
                Titile = "���������ɺ�",
                ReleaseDate = DateTime.Parse("2018 - 11 - 15"),
                Genre = " ����",
                Price = 460.00M
            };
            context.Movies.Add(m1);
            context.Movies.Add(m2);
            context.Movies.Add(m3);
            context.SaveChanges();
        }
    }
}
