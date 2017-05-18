namespace ThinkTech.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using ThinkTech.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<ThinkTech.Models.ThinkTechContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ThinkTech.Models.ThinkTechContext context)
        {

            context.Categories.AddOrUpdate(x => x.Id,
               new Category() { Id = 1, TechnologyDevice = "Raspberry Pi" },
               new Category() { Id = 2, TechnologyDevice = "MOD 3-D Printer" },
               new Category() { Id = 3, TechnologyDevice = "Rocketbook " }
               );


            context.Reviews.AddOrUpdate(x => x.Id,
              new Review() { Id = 1, ConsumerRatingNumber = "8", FunctionalityImprovements = "Overclocking is easy, switch configuration and select overclock.",
                  CategoryId = 1, ConsumerReport = "Innovative" },

              new Review() { Id = 2, ConsumerRatingNumber = "5", FunctionalityImprovements = "Build a thermal enclosure.",
                  CategoryId = 1, ConsumerReport = "User Friendly" },
              new Review() { Id = 3, ConsumerRatingNumber = "9",
                  FunctionalityImprovements = "Place Rocketbook in the microwave to get rid of FriXion ink",
                  CategoryId = 2, ConsumerReport = "Convenient" }
                   );
                

           
            
           
            



















            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
