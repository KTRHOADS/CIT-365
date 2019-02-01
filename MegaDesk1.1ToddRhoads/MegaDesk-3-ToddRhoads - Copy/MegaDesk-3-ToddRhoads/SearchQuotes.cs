using System;
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
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();
            populateCombo();
        }

        private void populateCombo()
        {
            string[] enumList = Enum.GetNames(typeof(AddQuote.materials));
            List<String> materialList = new List<String>(enumList);
            MaterialCombo.DataSource = materialList;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SearchQuotesByMaterial() {
            listView.Items.Clear();
            string line;
            var text = MaterialCombo.SelectedItem.ToString();

            System.IO.StreamReader file =
                new System.IO.StreamReader("quotes.txt");

            while ((line = file.ReadLine()) != null)
            {
                if (line.Contains(text))
                {
                    String[] quotes = line.Split(',');
                    string name = quotes[0];
                    string width = quotes[1];
                    string depth = quotes[2];
                    string material = quotes[3];
                    string shippingDays = quotes[4];
                    string finalCost = quotes[5];
                    string date = quotes[6];
                    listView.Items.Add(new ListViewItem(new string[] {name, width, depth, material, shippingDays, finalCost, date }));
                    
                }

              
            }




        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            SearchQuotesByMaterial();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainMenu mm = new MainMenu();
            mm.Tag = this;
            mm.Show(this);
            Hide();
        }

        
    }
}
