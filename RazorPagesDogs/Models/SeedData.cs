using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesDogs.Data;
using System;
using System.Linq;

namespace RazorPagesDogs.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesDogsContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesDogsContext>>()))
            {
                // Look for any movies.
                if (context.Dogs.Any())
                {
                    return;   // DB has been seeded
                }

                context.Dogs.AddRange(
                    new Dogs
                    {
                      Breed = "Labrador",
                      Age    = DateTime.Parse("2021-2-12"),
                      Color = "Rose Gold",
                      Price = 350.78M
                    },

                    new Dogs
                    {
                      Breed = "German Shepherd",
                      Age    = DateTime.Parse("2022-1-12"),
                      Color = "Dark Brown",
                      Price = 250.78M
                    },

                    new Dogs
                    {
                      Breed = "Pomarian",
                      Age    = DateTime.Parse("2022-1-1"),
                      Color = "Brown",
                      Price = 20.78M
                    },

                    new Dogs
                    {
                      Breed = "Toy Pom",
                      Age    = DateTime.Parse("2020-8-9"),
                      Color = "White",
                      Price = 80.78M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}