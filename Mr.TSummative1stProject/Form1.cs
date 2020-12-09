/* Date: November 26, 2020
 * Author: Mann Patel
 * Description: Cash Register Program 
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
        int numberBurgers;
        int numberFries;
        int numberDrinks;
        double subTotal;
        double total;
        double tenderedAmount;
        double change;
        double totalTax = 1.13;
        

        public form1()
        {
            InitializeComponent();
        }

        private void totalCalulator_Click(object sender, EventArgs e)
        {
            try
            {
                // Converting number of burgers into an integer
                numberBurgers = Convert.ToInt32(burgerAmounttextBox.Text);
                // Showing that any number of burgers can be entered
                burgerAmounttextBox.Text = $"{numberBurgers}";
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
                numberFries = Convert.ToInt32(friesAmounttextBox.Text);
                // Showing that any number of fries can be entered
                friesAmounttextBox.Text = $"{numberFries}";
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
                numberDrinks = Convert.ToInt32(drinkAmounttextBox.Text);
                // Showing that any number can be entered for the amount of drinks wanted
                drinkAmounttextBox.Text = $"{numberDrinks}";
            }
            catch
            {
                // identifying only integer values for amount of drinks
                drinkAmounttextBox.Text = $"not valid";
                return;
            }
                // Calculation of subtotal amount, tax, and total
                subTotal = numberBurgers * burger + numberFries * fries + numberDrinks * drinks;
                tax = numberBurgers * burger * tax + numberFries * fries * tax + numberDrinks * drinks * tax;
                total = numberBurgers * burger * totalTax + numberFries * fries * totalTax + numberDrinks * drinks * totalTax;
                // The amounts for subtotal, tax, and total for order
                totalAmountlabel.Text = $"SubTotal                  {subTotal.ToString("C")}" +
                    $"\n\nTax                          {tax.ToString("C")}" +
                    $"\n\nTotal                        {total.ToString("C")}";    
        }

        private void calculateChangebutton_Click(object sender, EventArgs e)
        {
            try 
            {  
                // Conversion of tendered amount to any integer
                tenderedAmount = Convert.ToInt32(tenderedAmounttextLabel.Text);
                tenderedAmounttextLabel.Text = $"{tenderedAmount}";

                // Calculation of change received by customer
                change = tenderedAmount - total;
                changeLabel.Text = $"Change                                 {change.ToString("C")}";
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
               cashregister.Play();
            // Text shown on receipt
               receiptLabel.Text = $"             Best Burgers in Town INC.";
               Refresh();
               Thread.Sleep(300);
               receiptLabel.Text += $"\n\nBurgers    x{numberBurgers}                                  @ {numberBurgers * burger}";
               Refresh();
               Thread.Sleep(300);
               receiptLabel.Text += $"\n\nFries     x{numberFries}                                      @ {numberFries * fries}";
               Refresh();
               Thread.Sleep(300);
               receiptLabel.Text += $"\n\nDrinks   x{numberDrinks}                                     @ {numberDrinks * drinks}";
               Refresh();
               Thread.Sleep(300);
               receiptLabel.Text += $"\n\nSubtotal                                          {subTotal.ToString("C")}";
               Refresh();
               Thread.Sleep(300);
               receiptLabel.Text += $"\nTax                                                  {tax.ToString("C")}";
               Refresh();
               Thread.Sleep(300);
               receiptLabel.Text += $"\nTotal                                                {total.ToString("C")}";
               Refresh();
               Thread.Sleep(300);
               receiptLabel.Text += $"\n\nTendered                                        {tenderedAmount.ToString("C")}";
               Refresh();
               Thread.Sleep(300);
               receiptLabel.Text += $"\nChange                                            {change.ToString("C")}";
               Refresh();
               Thread.Sleep(300);
               receiptLabel.Text += $"\n\n       Thank You! Have an Amazing Day!";
               Refresh();
               Thread.Sleep(300);
            cashregister.Stop();
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
               totalTax = 0;
               burger = 3.75;
               fries = 1.25;
               drinks = 1.00;
               tax = 0.13;
               totalTax = 1.13;
          
        }
    }
}
