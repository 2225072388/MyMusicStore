namespace MVCDemo1.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MVCDemo1.Models.MovieDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(MVCDemo1.Models.MovieDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            var m1 = new Movie()
            {
                Titile = "毒液：致命守护者",
                ReleaseDate = DateTime.Parse("2019-2-2"),
                Genre = "3D 动作 好莱坞",
                Price = 50.00M
            };
            var m2 = new Movie()
            {
                Titile = "名侦探柯南：零的执行人",
                ReleaseDate = DateTime.Parse("2019-1-2"),
                Genre = "3D 动作 动漫",
                Price = 30.00M
            };
            var m3 = new Movie()
            {
                Titile = "憨豆特工3",
                ReleaseDate = DateTime.Parse("2018-11-23"),
                Genre = "2D 动作 喜剧",
                Price = 20.00M
            };
            var m4 = new Movie()
            {
                Titile = "喜羊羊与灰太狼之虎虎生威",
                ReleaseDate = DateTime.Parse("2011-2-19"),
                Genre = "2D 动作 动漫",
                Price = 25.00M
            };
            var m5 = new Movie()
            {
                Titile = "喜羊羊与灰太狼之兔年顶呱呱",
                ReleaseDate = DateTime.Parse("2012-1-1"),
                Genre = "2D 搞笑 动漫",
                Price = 20.00M
            };
            context.Movies.Add(m1);
            context.Movies.Add(m2);
            context.Movies.Add(m3);
            context.Movies.Add(m4);
            context.Movies.Add(m5);

        }
    }
}
