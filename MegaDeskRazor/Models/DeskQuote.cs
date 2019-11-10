using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MegaDeskRazor.Models
{
    public class DeskQuote
    {
        public int ID { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Date Added")]
        public DateTime QuoteDate { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Range(24, 96)]
        public int Width { get; set; }
        [Range(12, 48)]
        public int Depth { get; set; }
        [Display(Name = "Surface Area")]
        public int SurfaceArea { get; set; }
        [Display(Name = "Surface Price")]
        public int SurfacePrice { get; set; }
        [Display(Name = "Surface Material")]
        public string SurfaceMaterial { get; set; }
        [Display(Name = "Drawers")]
        [Range(0, 7)]
        public int NumDrawers { get; set; }
        public bool IsRushOrder { get; set; }
        [Display(Name = "Delivery Time")]
        public int DeliveryTime { get; set; }
        [Display(Name = "Delivery Price")]
        public int RushOrderPrice { get; set; }
        [Display(Name = "Total Price")]
        public decimal TotalPrice { get; set; }
    }
}
