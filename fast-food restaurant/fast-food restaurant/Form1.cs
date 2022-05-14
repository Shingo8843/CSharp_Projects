using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fast_food_restaurant
{
    public partial class Form1 : Form
    {
        public int BasePrice = 5;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void BurgerOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(BurgerOptions.SelectedIndex == 0)
            {
                BasePrice += 3;
            }
            else if(BurgerOptions.SelectedIndex == 1)
            {
                BasePrice += 4;
            }
            else if (BurgerOptions.SelectedIndex == 2)
            {
                BasePrice += 2;
            }
            Price.Text = BasePrice.ToString();
        }

        private void Price_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ExtraMeat_CheckedChanged(object sender, EventArgs e)
        {
            
            BasePrice += 1;
            Price.Text = BasePrice.ToString();
        }

        private void Cheese_CheckedChanged(object sender, EventArgs e)
        {
            BasePrice += 1;
            Price.Text = BasePrice.ToString();
        }

        private void lettuce_CheckedChanged(object sender, EventArgs e)
        {
            BasePrice += 1;
            Price.Text = BasePrice.ToString();
        }

        private void Tomatoes_CheckedChanged(object sender, EventArgs e)
        {
            BasePrice += 1;
            Price.Text = BasePrice.ToString();
        }

        private void PepperJack_CheckedChanged(object sender, EventArgs e)
        {
            BasePrice += 1;
            Price.Text = BasePrice.ToString();
        }

        private void Jalapenos_CheckedChanged(object sender, EventArgs e)
        {
            BasePrice += 1;
            Price.Text = BasePrice.ToString();
        }

        private void ExtraMeat_CheckedChanged_1(object sender, EventArgs e)
        {
            BasePrice += 1;
            Price.Text = BasePrice.ToString();
        }
    }
}
