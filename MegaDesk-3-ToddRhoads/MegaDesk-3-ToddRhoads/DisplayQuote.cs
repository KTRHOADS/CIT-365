using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_ToddRhoads
{
    public partial class DisplayQuote : Form
    {
        public DisplayQuote()
        {

            InitializeComponent();
            List<DeskQuote> deskQuotes = Program.DeskQuotes;
            String[] widths = new string[deskQuotes.Count];
            String[] depths = new string[deskQuotes.Count];
            String[] materials = new string[deskQuotes.Count];
            String[] surfaceAreas = new string[deskQuotes.Count];
            String[] shippingDays = new string[deskQuotes.Count];
            

            Console.WriteLine(deskQuotes.Count);
            Console.WriteLine(deskQuotes.Count);
            for (int i = 0; i < deskQuotes.Count; i++)
            {
                shippingDays[i] = deskQuotes[i].Desk.ShippingDays.ToString();
                widths[i] = deskQuotes[i].Desk.Width.ToString();
                depths[i] = deskQuotes[i].Desk.Depth.ToString();
                surfaceAreas[i] = deskQuotes[i].Desk.SurfaceArea.ToString();
                materials[i] = deskQuotes[i].Desk.SurfaceMaterial;
                listView.Items.Add(new ListViewItem(new string[] { widths[i], depths[i], surfaceAreas[i], materials[i],shippingDays[i] }));
               


            }

          

        }


    
       

        private void button1_Click(object sender, EventArgs e)
        {
            AddQuote addNewQuoteForm = new AddQuote();
            addNewQuoteForm.Tag = this;
            addNewQuoteForm.Show(this);
            Hide();
        }
    }
}

