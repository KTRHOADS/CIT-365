using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_ToddRhoads
{
    static class Program
    {
        private static List<DeskQuote> deskQuotes = new List<DeskQuote>();

        internal static List<DeskQuote> DeskQuotes { get => deskQuotes; set => deskQuotes = value; }

        enum AttributeOrder {
            Width = 0,
            Depth = 1,
            SurfaceArea = 2,
            Material = 3,
            ProductionTime = 4
        }

        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());
            
        }
    }
}
