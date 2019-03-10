using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Super_Mega_Desk.Models
{
    public class Desk
    {
        public int ID { get; set; }

        public double MaterialCost;
        public double BasePrice = 200;
        [Required]
        [Range(24, 96)]
        public double Width { get; set; }

        [Required]
        [Range(12, 48)]
        public double Depth { get; set; }

        public double FinalCost { get; set; }
        public double ShippingCost { get; set; }
        public double Area { get; set; }

        //[Required]
        public double ShippingDays { get; set; }

        //[Required]
        public string Material { get; set; }

        [Display(Name = "Customer Name")]
        [StringLength(120, MinimumLength = 3)]
        [Required]
        public string CustomerName { get; set; }
        public string Date { get; set; }

        [Display(Name = "Number of Drawers")]
        [Range(0, 7)]
        public double DrawerNumber { get; set; }

        public double ExtraSurfaceAreaCost = 0;
        public double DrawerCost;

        public Desk()
        {


        }
    }
}
