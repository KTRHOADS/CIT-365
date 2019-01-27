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

        private float surfaceArea;
        internal void calcualateSurfaceArea()
        {
            this.SurfaceArea = this.Width * this.Depth;
        }
    }
}
