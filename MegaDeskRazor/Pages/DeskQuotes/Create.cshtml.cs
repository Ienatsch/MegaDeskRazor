using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MegaDeskRazor.Models;

namespace MegaDeskRazor.Pages.DeskQuotes
{
    public class CreateModel : PageModel
    {
        private readonly MegaDeskRazor.Models.MegaDeskRazorContext _context;

        public CreateModel(MegaDeskRazor.Models.MegaDeskRazorContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public DeskQuote DeskQuote { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var width = int.Parse(Request.Form["width"]);
            var depth = int.Parse(Request.Form["depth"]);
            var deliveryTime = int.Parse(Request.Form["deliveryTime"]);
            var numDrawers = int.Parse(Request.Form["numDrawers"]);
            var surfaceMaterial = Request.Form["surfaceMaterial"];
            DeskQuote.QuoteDate = DateTime.Today;
            DeskQuote.SurfaceMaterial = surfaceMaterial;
            DeskQuote.Width = width;
            DeskQuote.Depth = depth;
            DeskQuote.NumDrawers = numDrawers;
            DeskQuote.DeliveryTime = deliveryTime;
            DeskQuote.SurfaceArea = width * depth;

            GetDeliveryPrice(deliveryTime);
            GetSurfacePrice(surfaceMaterial);

            DeskQuote.TotalPrice = 200 + (numDrawers * 50) + DeskQuote.SurfacePrice + DeskQuote.RushOrderPrice;
            _context.DeskQuote.Add(DeskQuote);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }

        private void GetDeliveryPrice(int deliveryTime)
        {
            switch (deliveryTime)
            {
                case 3:
                    if (DeskQuote.SurfaceArea < 1000)
                    {
                        DeskQuote.RushOrderPrice = 60;
                    }
                    if (DeskQuote.SurfaceArea > 2000)
                    {
                        DeskQuote.RushOrderPrice = 80;
                    }
                    else
                    {
                        DeskQuote.RushOrderPrice = 70;
                    }
                    break;
                case 5:
                    if (DeskQuote.SurfaceArea < 1000)
                    {
                        DeskQuote.RushOrderPrice = 40;
                    }
                    if (DeskQuote.SurfaceArea > 2000)
                    {
                        DeskQuote.RushOrderPrice = 60;
                    }
                    else
                    {
                        DeskQuote.RushOrderPrice = 50;
                    }
                    break;
                case 7:
                    if (DeskQuote.SurfaceArea < 1000)
                    {
                        DeskQuote.RushOrderPrice = 30;
                    }
                    if (DeskQuote.SurfaceArea > 2000)
                    {
                        DeskQuote.RushOrderPrice = 40;
                    }
                    else
                    {
                        DeskQuote.RushOrderPrice = 35;
                    }
                    break;
                default:
                    DeskQuote.RushOrderPrice = 0;
                    break;
            }
        }

        private void GetSurfacePrice(string surfaceMaterial)
        {
            switch (surfaceMaterial)
            {
                case "Oak":
                    DeskQuote.SurfacePrice = 200;
                    break;
                case "Laminate":
                    DeskQuote.SurfacePrice = 100;
                    break;
                case "Pine":
                    DeskQuote.SurfacePrice = 50;
                    break;
                case "Rosewood":
                    DeskQuote.SurfacePrice = 300;
                    break;
                default:
                    DeskQuote.SurfacePrice = 125;
                    break;
            }
        }
    }
}