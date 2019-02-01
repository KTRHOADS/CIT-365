using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_ToddRhoads
{
    class Desk

    {
        float width;
        float depth;
        int drawerNumber;
        String surfaceMaterial;
        int shippingDays;

        public Desk()
        {

        }

        public float Width { get => width; set => width = value; }
        public float Depth { get => depth; set => depth = value; }
        public int DrawerNumber { get => drawerNumber; set => drawerNumber = value; }
        public string SurfaceMaterial { get => surfaceMaterial; set => surfaceMaterial = value; }
        public int ShippingDays { get => shippingDays; set => shippingDays = value; }
        public float SurfaceArea { get => surfaceArea; set => surfaceArea = value; }
        public decimal FinalDeskCost { get => finalDeskCost; set => finalDeskCost = value; }

        private float surfaceArea;
        private decimal finalDeskCost;

        internal void calcualateSurfaceArea()
        {
            this.SurfaceArea = this.Width * this.Depth;
        }

        internal void calculateQuote()
        {
            decimal baseCost = 200;
            decimal extraSurfaceAreaCost = 0;
            decimal materialTypeCost = 0;
            decimal shippingCost = 0;
            decimal totalCost = 0;
            decimal drawerCost;

            if (surfaceArea > 1000)
            {
                extraSurfaceAreaCost = (decimal)surfaceArea - 1000;
            }
                switch (SurfaceMaterial) { 



                case "Pine":
                materialTypeCost = 50;
                break;
            case "Oak":
                materialTypeCost = 200;
                break;
            case "Laminate":
                materialTypeCost = 100;
                break;
            case "Rosewood":
                materialTypeCost = 30;
                break;
            case "Veneer":
                materialTypeCost = 125;
                break;
            }

                drawerCost = drawerNumber * 50;
            if (ShippingDays == 14)
            {
                shippingCost += 0;
            }

            else
            {
                if (surfaceArea < 1000)
                {
                    switch (shippingDays)
                    {
                        case 3:
                            shippingCost += 60;
                            break;
                        case 5:
                            shippingCost += 40;
                            break;
                        case 7:
                            shippingCost += 30;
                            break;


                    }
                }
                else if (surfaceArea >= 1000 && surfaceArea <= 2000)
                {

                    switch (shippingDays)
                    {
                        case 3:
                            shippingCost += 70;
                            break;
                        case 5:
                            shippingCost += 50;
                            break;
                        case 7:
                            shippingCost += 35;
                            break;

                    }
                }
                else
                {
                    switch (shippingDays)
                    {
                        case 3:
                            shippingCost += 80;
                            break;
                        case 5:
                            shippingCost += 60;
                            break;
                        case 7:
                            shippingCost += 40;
                            break;


                    }
                }
                    }

                    

                totalCost = materialTypeCost + baseCost + shippingCost + extraSurfaceAreaCost + drawerCost;
                this.FinalDeskCost = totalCost;
            Console.WriteLine(this.FinalDeskCost);
            }
        }

    }
