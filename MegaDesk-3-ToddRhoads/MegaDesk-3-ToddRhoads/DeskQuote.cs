using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_ToddRhoads
{
    class DeskQuote
    {
        Desk desk;
        //double surfaceArea = calculateDeskSurfaceArea();
      

        private static double calculateShippingPrice(int noOfDays, double width, double depth) {
            //TO DO - Add Shipping Logic
            double shippingPrice =0;
           double surfaceArea = width * depth;

            return shippingPrice;
        }

       // private static double calculateDeskSurfaceArea()
        //{
           // double surfaceArea = desk.Depth * desk.Width;
            //return surfaceArea;
        //}
        internal Desk Desk { get => desk; set => desk = value; }
    }
}
