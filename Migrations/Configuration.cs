namespace WinterGardenMVC.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WinterGardenMVC.Models.WinterContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(WinterGardenMVC.Models.WinterContext context)
        {
            context.Admin.AddOrUpdate(s => s.ID, new Models.Admin() { ID = 1, Username = "admin", Password = "1234", Firstname = "Lorem", Surname = "Ipsum", Email = "lorem@ipsum.com", isAdmin = true, isEditor = false, isDeleted = false });
            context.Admin.AddOrUpdate(s => s.ID, new Models.Admin() { ID = 2, Username = "editor", Password = "1234", Firstname = "Ipsum", Surname = "Lorem", Email = "ipsum@lorem.com", isAdmin = false, isEditor = true, isDeleted = false });
        }
    }
}
