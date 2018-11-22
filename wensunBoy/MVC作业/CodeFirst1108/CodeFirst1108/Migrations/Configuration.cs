namespace CodeFirst1108.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CodeFirst1108.DataContext.StuDBcontext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(CodeFirst1108.DataContext.StuDBcontext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            //string name = "��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,��,֣,��,л,��,��,��,��,��,��,��,��,��,��,��,Ф,��,Ԭ,��,Ҷ,��,��,��,��,��,��,κ,��,��,��,¬,��,��,Ҧ,��,��,½,̷,��,ʯ,��,��,��,��,��,Τ,��,��,��,��,��,��,��,��,��,��,Ѧ,��,��,��,��,��,ʷ,��,ë,��,��,��,��,��,��,��,��,��,��,Ǯ,�� ��,��,��,��,��,��,��,ţ,Ī,��,��,��,��,��,��,ʩ,��,��";
            //Random sj = new Random();
            //sj.Next(name.Length);

            //context.Database.ExecuteSqlCommand("delete DepartMents");
            //DepartmentSeed.Seed(context);

            //DepartmentSeed.Seed(context);
            StudentSeed.Seed(context);


        }
    }
}
