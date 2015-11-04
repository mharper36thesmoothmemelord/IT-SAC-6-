using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Price_Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void solematerialbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            String Value1 = solematerialbox.Text;

            if (Value1 == "Leather")
            {
                PriceSole.Text = "20";
            }
            else if (Value1 == "Rubber")
            {
                PriceSole.Text = "15";
            }
            else if (Value1 == "Composite")
            {
                PriceSole.Text = "22.5";
            }
        }

        private void colourbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            String Value2 = colourbox.Text;

            if (Value2 == "Black")
            {
                PriceColour.Text = "5";
            }
            else if (Value2 == "Brown")
            {
                PriceColour.Text = "5";
            }
            else if (Value2 == "Tan")
            {
                PriceColour.Text = "7.9";
            }
            else if (Value2 == "Red")
            {
                PriceColour.Text = "7.9";
            }
            else if (Value2 == "Blue")
            {
                PriceColour.Text = "7.9";
            }

        }

        private void typebox_SelectedIndexChanged(object sender, EventArgs e)
        {
            String Value3 = typebox.Text;

            if (Value3 == "Balmoral")
            {
                PriceType.Text = "30";
            }
            else if (Value3 == "Brouge")
            {
                PriceType.Text = "55.5";
            }
            else if (Value3 == "Demi Boot")
            {
                PriceType.Text = "120";
            }
            else if (Value3 == "Dress Pump")
            {
                PriceType.Text = "100.5";
            }
            else if (Value3 == "Loafer")
            {
                PriceType.Text = "37.9";
            }
            else if (Value3 == "Oxford")
            {
                PriceType.Text = "220";
            }
            else if (Value3 == "Ranch Boot")
            {
                PriceType.Text = "170";
            }
            else if (Value3 == "Sandals")
            {
                PriceType.Text = "15";
            }
            else if (Value3 == "Shenandoah")
            {
                PriceType.Text = "22.5";
            }

        }

        private void calculate_Click(object sender, EventArgs e)
        {
            double SoleValue = Double.Parse(PriceSole.Text);
            double ColourValue = Double.Parse(PriceColour.Text);
            double TypeValue = Double.Parse(PriceType.Text);

            double FinalValue = SoleValue + ColourValue + TypeValue;

            String Number = FinalValue.ToString();
            String Number2 = "$" + Number;
            TotalTextBox.Text = Number2.ToString();


        }

    }
}
