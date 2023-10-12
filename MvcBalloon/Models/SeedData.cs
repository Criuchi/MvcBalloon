using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcBalloon.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcBalloon.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcBalloonContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcBalloonContext>>()))
            {
                // Look for any movies.
                if (context.Balloon.Any())
                {
                    return;   // DB has been seeded
                }

                context.Balloon.AddRange(
                    new Balloon
                    {
                          Name = "Birthday Balloon",
                          Color= "Blue",
                          Size= "12 inches",
                          Theme = "Happy Birthday",
                          Price = 2.99M,
                          Rating = 4
                    },

                    new Balloon
                    {
                        Name = "Graduation Balloon",
                        Color = "Gold",
                        Size = "18 inches",
                        Theme = "Congratulations Graduate",
                        Price = 3.49M,
                        Rating = 5
                    },

                    new Balloon
                    {
                        Name = "Valentine's Day Balloon",
                        Color = "Red",
                        Size = "10 inches",
                        Theme = "Love Hearts",
                        Price = 1.99M,
                        Rating = 3
                    },

                    new Balloon
                    {
                        Name = "Baby Shower Balloon",
                        Color = "Pink",
                        Size = "16 inches",
                        Theme = "It's a Girl!",
                        Price = 2.79M,
                        Rating = 4
                    },

                    new Balloon
                    {
                        Name = "Halloween Balloon",
                        Color = "Orange",
                        Size = "14 inches",
                        Theme = "Spooky Ghosts",
                        Price = 2.29M,
                        Rating = 5
                    },

                    new Balloon
                    {
                        Name = "Anniversary Balloon",
                        Color = "Silver",
                        Size = "12 inches",
                        Theme = "Celebrating Love",
                        Price = 3.99M,
                        Rating = 5
                    },

                    new Balloon
                    {
                        Name = "Christmas Balloon",
                        Color = "Green",
                        Size = "10 inches",
                        Theme = "Festive Reindeer",
                        Price = 2.49M,
                        Rating = 4
                    },

                    new Balloon
                    {
                        Name = "Mardi Gras Balloon",
                        Color = "Purple, Green, Gold",
                        Size = "14 inches",
                        Theme = "Carnival Masks",
                        Price = 2.99M,
                        Rating = 2
                    },

                    new Balloon
                    {
                        Name = "Sports Balloon",
                        Color = "Various",
                        Size = "9 inches",
                        Theme = "Soccer Balls",
                        Price = 1.79M,
                        Rating = 5
                    },

                    new Balloon
                    {
                        Name = "Get Well Soon Balloon",
                        Color = "Bright Yellow",
                        Size = "16 inches",
                        Theme = "Get Well Wishes",
                        Price = 2.59M,
                        Rating = 1
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
