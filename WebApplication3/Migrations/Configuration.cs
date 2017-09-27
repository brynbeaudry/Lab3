namespace WebApplication3.Migrations
{
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using WebApplication3.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplication3.Data.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations";
        }

        protected override void Seed(WebApplication3.Data.ApplicationDbContext context)
        {
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
            // context.Cities.AddOrUpdate(c => c.CityName,
            // GetCities.ToArray()
            //);
        }

        private List<City> GetCities()
        {
            List<City> cities = new List<City>()
            {

                new City()
                {
                    ProvinceCode = "BC",
                    CityId = 1,
                    CityName = "Vancouver",
                    Population = 2313328
                },
                 new City()
                {
                    ProvinceCode = "ON",
                    CityId = 2,
                    CityName = "Toronto",
                    Population = 5583064
                },
                 new City()
                {
                    ProvinceCode = "QC",
                    CityId = 1,
                    CityName = "Montreal",
                    Population = 3824221
                },
                new City()
                {
                    ProvinceCode = "BC",
                    CityId = 1,
                    CityName = "Surrey",
                    Population = 45274
                },
                 new City()
                {
                    ProvinceCode = "ON",
                    CityId = 2,
                    CityName = "Ottowa",
                    Population = 5583064
                },
                 new City()
                {
                    ProvinceCode = "QC",
                    CityId = 1,
                    CityName = "Quebec",
                    Population = 545227
                },
                 new City()
                {
                    ProvinceCode = "BC",
                    CityId = 1,
                    CityName = "Burnaby",
                    Population = 453452545
                },
                 new City()
                {
                    ProvinceCode = "ON",
                    CityId = 2,
                    CityName = "Hamilton",
                    Population = 75452752
                },
                 new City()
                {
                    ProvinceCode = "QC",
                    CityId = 1,
                    CityName = "Saguenay",
                    Population = 157790
                },
            };
            return cities;
        }

        public List<Province> GetProvinces()
        {
            List<Province> provs = new List<Province>()
            {
               new Province()
               {
                   ProvinceCode = "BC",
                   ProvinceName = "British Columbia"
               },
               new Province()
               {
                   ProvinceCode = "ON",
                   ProvinceName = "Ontario",
               },
               new Province()
               {
                   ProvinceCode = "QC",
                   ProvinceName = "Quebec"
               }
            };
            return provs;
        }
    }
}
        

