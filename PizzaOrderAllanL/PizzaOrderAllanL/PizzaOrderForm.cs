/*
 * Allan L
 * ICS3U
 * March 14, 2019
 * Program: pizza order
 * This program calculates the total cost of an order made by the user
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaOrderAllanL
{
    public partial class frmPizzaOrder : Form
    {
        public frmPizzaOrder()
        {
            InitializeComponent();

            //Hiding Labels
            this.lblSubtotal.Hide();
            this.lblHST.Hide();
            this.lblTotal.Hide();

            //Enabling/Disabling
            btnOrderAgain.Enabled = false;
            btnCalculate.Enabled = true;
        }


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Local Variables
            double pizzaCost, toppingsCost, subtotal, hst, total;
            const double HST = 0.13;

            //Pizza Cost
            if (nudPizzaSize.Value == 1)
            {
                pizzaCost = 7.99;
            }
            else
            {
                if (nudPizzaSize.Value == 2)
                {
                    pizzaCost = 9.99;
                }
                else
                {
                    pizzaCost = 12.99;
                }
            }

            //Toppings Cost
            if (nudPizzaToppings.Value == 1)
            {
                toppingsCost = 0.75;
            }
            else
            {
                if (nudPizzaToppings.Value == 2)
                {
                    toppingsCost = 1.35;
                }
                else
                {
                    if (nudPizzaToppings.Value == 3)
                    {
                        toppingsCost = 2.15;
                    }
                    else
                    {
                        if (nudPizzaToppings.Value == 4)
                        {
                            toppingsCost = 2.75;
                        }
                        else
                        {
                            toppingsCost = 3.35;
                        }
                    }
                }
            }

            //Calculations
            subtotal = pizzaCost + toppingsCost;
            hst = subtotal * HST;
            total = subtotal + hst;

            //Set the subtotal, hst, and total to labels
            lblSubtotal.Text = String.Format("${0:0.00}", subtotal);
            lblHST.Text = String.Format("${0:0.00}", hst);
            lblTotal.Text = String.Format("${0:0.00}", total);

            //Show labels
            this.lblSubtotal.Show();
            this.lblHST.Show();
            this.lblTotal.Show();

            //Enabling/Disabling
            btnCalculate.Enabled = false;
            btnOrderAgain.Enabled = true;
        }

        private void btnOrderAgain_Click(object sender, EventArgs e)
        {
            //Restart the program when the button is clicked
            Application.Restart();
        }
    }
    
}
