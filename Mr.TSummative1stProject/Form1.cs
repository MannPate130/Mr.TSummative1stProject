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
        double burger = 3.75;
        double fries = 1.25;
        double drinks = 1.00;
        double tax = 0.13;
        int numberburgers;
        int numberfries;
        int numberdrinks;
        double subtotal;
        double total;
        int tendered;
        int tenderedamount;
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
                numberburgers = Convert.ToInt32(burgerAmounttextBox.Text);

                burgerAmounttextBox.Text = $"{numberburgers}";
            }
            catch
            {
                burgerAmounttextBox.Text = $"not valid";
                return;
            }
            try
            {
                numberfries = Convert.ToInt32(friesAmounttextBox.Text);

                friesAmounttextBox.Text = $"{numberfries}";
            }
            catch
            {
                friesAmounttextBox.Text = $"not valid";
                return;
            }
            try
            {
                numberdrinks = Convert.ToInt32(drinkAmounttextBox.Text);

                drinkAmounttextBox.Text = $"{numberdrinks}";
            }
            catch
            {
                drinkAmounttextBox.Text = $"not valid";
                return;
            }
                subtotal = numberburgers * burger + numberfries * fries + numberdrinks * drinks;

                tax = numberburgers * burger * tax + numberfries * fries *tax + numberdrinks * drinks * tax;

                total = numberburgers * burger * totaltax + numberfries * fries * totaltax + numberdrinks * drinks * totaltax;

                totalAmountlabel.Text = $"SubTotal                  {subtotal}" +
                    $"\n\nTax                         {tax}" +
                    $"\n\nTotal                     {total}";


         
        }

        private void calculateChangebutton_Click(object sender, EventArgs e)
        {
            try 
            {
                tenderedamount = Convert.ToInt32(tenderedAmounttextLabel.Text);

                tenderedAmounttextLabel.Text = $"{tenderedamount}";

                change = tenderedamount - total;

                changeLabel.Text = $"Change        {change}";
            }
            catch
            {
                tenderedAmounttextLabel.Text = $"not valid";
            }
        }

        private void printReceiptbutton_Click(object sender, EventArgs e)
        {

            SoundPlayer cashregister = new SoundPlayer(Properties.Resources.CashRegisterSound);
            cashregister.PlaySync();

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

            burgerAmounttextBox.Text = $"";
            friesAmounttextBox.Text = $"";
            drinkAmounttextBox.Text = $"";
            totalAmountlabel.Text = $"";
            tenderedAmounttextLabel.Text = $"";
            changeLabel.Text = $"";
            receiptLabel.Text = $"";
            double burger = 0;
            double fries = 0;
            double drinks = 0;
            double tax = 0;
            double totaltax = 0;

        }
    }
}
