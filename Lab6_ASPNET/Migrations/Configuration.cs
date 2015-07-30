namespace Lab6_ASPNET.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Lab6_ASPNET.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Lab6_ASPNET.Models.MovieDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Lab6_ASPNET.Models.MovieDBContext context)
        {
            context.Movies.AddOrUpdate(i => i.Title,
                new Movie
                {
                    Title = "When Harry Met Sally",
                    ReleaseDate = DateTime.Parse("1989-1-11"),
                    Genre = "Romantic Comedy",
                    Price = 7.99M,
                    Rating = "PG"
                },

                 new Movie
                 {
                     Title = "Ghostbusters ",
                     ReleaseDate = DateTime.Parse("1984-3-13"),
                     Genre = "Comedy",
                     Rating = "G",
                     Price = 8.99M
                 },

                 new Movie
                 {
                     Title = "Ghostbusters 2",
                     ReleaseDate = DateTime.Parse("1986-2-23"),
                     Genre = "Comedy",
                     Rating = "G",
                     Price = 9.99M
                 },

               new Movie
               {
                   Title = "Rio Bravo",
                   ReleaseDate = DateTime.Parse("1959-4-15"),
                   Genre = "Western",
                   Rating = "PG",
                   Price = 3.99M
               },

               new Movie
               {
                   Title = "Interstellar",
                   ReleaseDate = DateTime.Parse("2014-11-14"),
                   Genre = "Really freaking cool",
                   Rating = "G for Generally Astounding",
                   Price = 100.23M
               }
           );
        }
    }
}
