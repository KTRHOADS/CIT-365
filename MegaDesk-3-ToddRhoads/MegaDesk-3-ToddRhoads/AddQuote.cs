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
    public partial class AddQuote : Form
    {

        public AddQuote()
        {

            InitializeComponent();

        }

        private void CreateQuote_Click(object sender, EventArgs e)
        {

            
            try
            {
                DeskQuote deskQuote = new DeskQuote();
                Desk desk = new Desk();
                List<DeskQuote> deskQuotes = Program.DeskQuotes;
                desk.SurfaceMaterial = MaterialCombo.SelectedItem.ToString();


                desk.Width = float.Parse(WidthBox.Text);
                if (threeDayRadio.Checked)
                {
                    desk.ShippingDays = 3;
                }

                else if (fiveDayRadio.Checked)
                {
                    desk.ShippingDays = 5;
                }

                else if (sevenDayRadio.Checked)
                {
                    desk.ShippingDays = 7;
                }

                else if (normalRadio.Checked)
                {
                    desk.ShippingDays = 14;
                }


                if ((int.Parse(drawerNumberBox.Text) > 0 && int.Parse(drawerNumberBox.Text) < 8)){

                    desk.DrawerNumber = int.Parse(drawerNumberBox.Text);
                }

                else {
                    MessageBox.Show("Please Enter a Drawer Number Between 1 & 7");
                    return;
                }



                desk.Depth = float.Parse(DepthBox.Text);

               

                desk.calcualateSurfaceArea();
                Console.WriteLine("Width: " + desk.Width +
                   "\n" + "Depth: " + desk.Depth
                   + "\n" + "Surface Type : " + desk.SurfaceMaterial
                   + "\n" + "Surface Area: " + desk.SurfaceArea
                   + "\n" + "Shipping Days " + desk.ShippingDays
                   + "\n" + "# of Drawers " + desk.DrawerNumber
                    );
                deskQuote.Desk = desk;
                deskQuotes.Add(deskQuote);
                Program.DeskQuotes = deskQuotes;
               
                DisplayQuote addNewViewQuoteForm = new DisplayQuote();
                addNewViewQuoteForm.Tag = this;
                addNewViewQuoteForm.Show(this);
                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

            private void button1_Click(object sender, EventArgs e)
            {
                try
                {
                    float width = float.Parse(WidthBox.Text);
                    float depth = float.Parse(DepthBox.Text);
                    float surfaceArea = width * depth;
                    if (width > 0 && depth > 0)
                    {

                        if (surfaceArea < 1000)
                        {
                            threeDayRadio.Text = "3 Days (+ $60)";
                            fiveDayRadio.Text = "5 Days (+ $40)";
                            sevenDayRadio.Text = "7 Days (+ $30)";
                            threeDayRadio.Visible = true;
                            fiveDayRadio.Visible = true;
                            sevenDayRadio.Visible = true;
                        }

                        else if (surfaceArea >= 1000 && surfaceArea < 2000)
                        {
                            threeDayRadio.Text = "3 Days (+ $70)";
                            fiveDayRadio.Text = "5 Days (+ $50)";
                            sevenDayRadio.Text = "7 Days (+ $35)";
                            threeDayRadio.Visible = true;
                            fiveDayRadio.Visible = true;
                            sevenDayRadio.Visible = true;
                        }

                        else
                        {
                            threeDayRadio.Text = "3 Days (+ $80)";
                            fiveDayRadio.Text = " 5 Days (+ $60)";
                            sevenDayRadio.Text = "7 Days (+ $40)";
                            threeDayRadio.Visible = true;
                            fiveDayRadio.Visible = true;
                            sevenDayRadio.Visible = true;
                        }


                    }


                }

                catch
                {
                    MessageBox.Show("To see shipping options, you must enter a width and depth.");

                }



            }
        }
    }
