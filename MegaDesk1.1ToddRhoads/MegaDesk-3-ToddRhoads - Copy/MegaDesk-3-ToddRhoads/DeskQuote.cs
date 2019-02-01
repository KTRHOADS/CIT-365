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
        String name;
        String date = DateTime.Now.ToString("MMMM dd, yyyy");
        

        public DeskQuote()
        {
          
        }

        private static double calculateShippingPrice(int noOfDays, double width, double depth) {
            double shippingPrice =0;
           double surfaceArea = width * depth;

            return shippingPrice;
        }

       
        internal Desk Desk { get => desk; set => desk = value; }
        public string Name { get => name; set => name = value; }
        public string Date { get => date; set => date = value; }
    }
}
