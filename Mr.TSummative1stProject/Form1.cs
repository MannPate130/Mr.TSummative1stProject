/* Date: November 26, 2020
 * Author: Mann Patel
 * Purpose: Cash Register For Restaurant
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
using System.Threading;
using System.Media;

namespace Mr.TSummative1stProject
{
    public partial class form1 : Form
    {    
        // Global Variables
        double burger = 3.75;
        double fries = 1.25;
        double drinks = 1.00;
        double tax = 0.13;
        int numberburgers;
        int numberfries;
        int numberdrinks;
        double subtotal;
        double total;
        double tenderedamount;
        double change;
        double totaltax = 1.13;
        

        public form1()
        {
            InitializeComponent();
        }

        private void totalCalulator_Click(object sender, EventArgs e)
        {
            try
            {
                // Converting number of burgers into an integer
                numberburgers = Convert.ToInt32(burgerAmounttextBox.Text);
                // Showing that any number of burgers can be entered
                burgerAmounttextBox.Text = $"{numberburgers}";
            }
            catch
            {
                // Identifying only integer values for amount of burgers
                burgerAmounttextBox.Text = $"not valid";
                return;
            }
            try
            {
                // Converting number of fries into an integer
                numberfries = Convert.ToInt32(friesAmounttextBox.Text);
                // Showing that any number of fries can be entered
                friesAmounttextBox.Text = $"{numberfries}";
            }
            catch
            {
                // Identifying only integer values for amount of fries
                friesAmounttextBox.Text = $"not valid";
                return;
            }
            try
            {
                // Converting number of drinks into an integer
                numberdrinks = Convert.ToInt32(drinkAmounttextBox.Text);
                // Showing that any number can be entered for the amount of drinks wanted
                drinkAmounttextBox.Text = $"{numberdrinks}";
            }
            catch
            {
                // identifying only integer values for amount of drinks
                drinkAmounttextBox.Text = $"not valid";
                return;
            }
                // Calculation of subtotal amount, tax, and total
                subtotal = numberburgers * burger + numberfries * fries + numberdrinks * drinks;
                tax = numberburgers * burger * tax + numberfries * fries *tax + numberdrinks * drinks * tax;
                total = numberburgers * burger * totaltax + numberfries * fries * totaltax + numberdrinks * drinks * totaltax;
                // The amounts for subtotal, tax, and total for order
                totalAmountlabel.Text = $"SubTotal                  {subtotal}" +
                    $"\n\nTax                           {tax.ToString(".00")}" +
                    $"\n\nTotal                        {total.ToString(".00")}";    
        }

        private void calculateChangebutton_Click(object sender, EventArgs e)
        {
            try 
            {  
                // Conversion of tendered amount to any integer
                tenderedamount = Convert.ToInt32(tenderedAmounttextLabel.Text);
                tenderedAmounttextLabel.Text = $"{tenderedamount}";

                // Calculation of change received by customer
                change = tenderedamount - total;
                changeLabel.Text = $"Change                                 {change.ToString(".00")}";
            }
            catch
            {
                // Identifying only integer values are acceptable
                tenderedAmounttextLabel.Text = $"not valid";
            }
        }

        private void printReceiptbutton_Click(object sender, EventArgs e)
        {
                // Receipt printer sound
               SoundPlayer cashregister = new SoundPlayer(Properties.Resources.CashRegisterSound);
               cashregister.PlaySync();
                // Text shown on receipt
               receiptLabel.Text = $"             Best Burgers in Town INC." +
                $"\n\nBurgers    x{numberburgers}                              @ {numberburgers * burger}" +
                $"\n\nFries     x{numberfries}                                  @ {numberfries * fries}" +
                $"\n\nDrinks   x{numberdrinks}                                 @ {numberdrinks * drinks}" +
                $"\n\nSubtotal                                        {subtotal.ToString("C")}" +
                $"\nTax                                                {tax.ToString("C")}" +
                $"\nTotal                                              {total.ToString("C")}" +
                $"\n\nTendered                                     {tenderedamount.ToString("C")}" +
                $"\nChange                                         {change.ToString("C")}" +
                $"\n\n       Thank You! Have an Amazing Day!";
        }

        private void newOrderbutton_Click(object sender, EventArgs e)
        {
                // Actions for "new order" button (reset order info)
               burgerAmounttextBox.Text = $"";
               friesAmounttextBox.Text = $"";
               drinkAmounttextBox.Text = $"";
               totalAmountlabel.Text = $"";
               tenderedAmounttextLabel.Text = $"";
               changeLabel.Text = $"";
               receiptLabel.Text = $"";
               burger = 0;
               fries = 0;
               drinks = 0;
               tax = 0;
               totaltax = 0;
               burger = 3.75;
               fries = 1.25;
               drinks = 1.00;
               tax = 0.13;
               totaltax = 1.13;
        }
    }
}
