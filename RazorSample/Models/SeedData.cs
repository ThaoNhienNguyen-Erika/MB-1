using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorSample.Data;
using System;
using System.Linq;

namespace RazorSample.Models
{
    public static class SeedData
    {
        public static void Initialize(MotobikeContext context)
        {
            context.Database.EnsureCreated();

            if (context.Motobikes.Any()) return;

            context.Motobikes.AddRange(
                new Motobike
                {
                    Name = "MT-10 SP",
                    Price = 16199,
                    Color = "Silver",
                    Type = "Hyper Naked",
                    Id_Supplier=1
                },

                new Motobike
                {
                    Name = "YZF-R1M",
                    Price = 24399,
                    Color = "Blue",
                    Type = "Sport",
                    Id_Supplier=1
                },

                new Motobike
                {
                    Name = "S 1000 RR",
                    Price = 24099,
                    Color = "Black",
                    Type = "Sport",
                    Id_Supplier=2
                },

                new Motobike
                {
                    Name = "S 1000 XR",
                    Price = 24099,
                    Color = "Red",
                    Type = "Adventure",
                    Id_Supplier=2
                }
            );
            context.SaveChanges();
        }

        internal static void Initialize()
        {
            throw new NotImplementedException();
        }
    }
}