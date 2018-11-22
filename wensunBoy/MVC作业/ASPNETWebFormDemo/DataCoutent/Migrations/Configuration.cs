namespace StuContext.Migrations
{
    using StuContext.Migrations;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<StuContext.StuDBcontext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

       protected override void Seed(StuContext.StuDBcontext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            DepartmentSeed.Seed(context);
            StudentSeed.Seed(context);

        }
    }
}
