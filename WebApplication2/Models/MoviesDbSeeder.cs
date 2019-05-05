using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class MoviesDbSeeder
    {
        public static void Initialize(MoviesDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any movies.
            if (context.Movies.Any())
            {
                return;   // DB has been seeded
            }

            context.Movies.AddRange(
                new Movie
                {
                    Title = "SomeMovie",
                    Runtime = 1230,
                    Rating = 9,
                    Storyline = "the storyline of some movie"
                },
                new Movie
                {
                    Title = "AnotherMovie",
                    Runtime = 1300,
                    Rating = 8,
                    Storyline = "the storyline of another movie"
                }
            );
            context.SaveChanges();
        }
    }
}
