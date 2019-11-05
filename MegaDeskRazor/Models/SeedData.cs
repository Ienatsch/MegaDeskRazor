using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MegaDeskRazor.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MegaDeskRazorContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MegaDeskRazorContext>>()))
            {
                // Look for any DeskQuotes.
                if (context.DeskQuote.Any())
                {
                    return;   // DB has been seeded
                }

                context.DeskQuote.AddRange(
                    new DeskQuote
                    {
                        QuoteDate = DateTime.Today,
                        FirstName = "Dalan",
                        LastName = "Ienatsch",
                        Width = 24,
                        Depth = 33,
                        SurfaceArea = 792,
                        SurfacePrice = 120,
                        SurfaceMaterial = "Oak",
                        NumDrawers = 3,
                        IsRushOrder = true,
                        DeliveryTime = 3,
                        RushOrderPrice = 40,
                        TotalPrice = 500
    },

                    new DeskQuote
                    {
                        QuoteDate = DateTime.Today,
                        FirstName = "Oswaldo",
                        LastName = "Rodriguez",
                        Width = 44,
                        Depth = 28,
                        SurfaceArea = 1232,
                        SurfacePrice = 180,
                        SurfaceMaterial = "Veneer",
                        NumDrawers = 1,
                        IsRushOrder = false,
                        DeliveryTime = 14,
                        RushOrderPrice = 0,
                        TotalPrice = 450
                    },

                    new DeskQuote
                    {
                        QuoteDate = DateTime.Today,
                        FirstName = "Kate",
                        LastName = "Montesdeoca",
                        Width = 50,
                        Depth = 66,
                        SurfaceArea = 3300,
                        SurfacePrice = 340,
                        SurfaceMaterial = "Pine",
                        NumDrawers = 7,
                        IsRushOrder = true,
                        DeliveryTime = 5,
                        RushOrderPrice = 30,
                        TotalPrice = 1425
                    },

                    new DeskQuote
                    {
                        QuoteDate = DateTime.Today,
                        FirstName = "Max",
                        LastName = "Young",
                        Width = 37,
                        Depth = 25,
                        SurfaceArea = 925,
                        SurfacePrice = 275,
                        SurfaceMaterial = "Pine",
                        NumDrawers = 0,
                        IsRushOrder = true,
                        DeliveryTime = 7,
                        RushOrderPrice = 20,
                        TotalPrice = 475
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
