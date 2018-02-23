namespace SludinājumuWebApp.Migrations
{
    using SludinājumuWebApp.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SludinājumuWebApp.Models.AdvertDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SludinājumuWebApp.Models.AdvertDb context)
        {
            Sludinājums ad1 = new Sludinājums();
            ad1.AdvertId = 1;
            ad1.Name = "BMW";
            ad1.AdvertText = "Šis ir labs BMW";
            ad1.Price = 2500;
            ad1.CreationTime = DateTime.Now;

            Sludinājums homeAd = new Sludinājums();
            homeAd.AdvertId = 2;
            homeAd.Name = "Māja";
            homeAd.AdvertText = "Liela māja";
            homeAd.Price = 12000;
            homeAd.CreationTime = new DateTime(1999, 12, 31);

            context.Adverts.AddOrUpdate(ad1);
            context.Adverts.AddOrUpdate(homeAd);


            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
