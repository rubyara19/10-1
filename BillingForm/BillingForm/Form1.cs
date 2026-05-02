using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingForm
{
    public partial class Form1 : Form
    {
        // variables for calculation
        decimal subtotalDec, totalDec, grandTotalDec;
        int countInt;

        const decimal TAX_RATE = 0.08m;
        const decimal CAPPUCCINO_PRICE = 2.00m;
        const decimal ESPRESSO_PRICE = 2.25m;
        const decimal LATTE_PRICE = 1.75m;
        const decimal ICED_PRICE = 2.50m;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e){}

        private void textBox2_TextChanged(object sender, EventArgs e){}

        private void TaxCB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void QuantityTB_TextChanged(object sender, EventArgs e)
        {

        }

        // calculation of price
        private void CalculateBT_Click(object sender, EventArgs e)
        {

            // vars
            decimal priceDec = 0, taxDec = 0, itemAmountDec = 0;
            int quantityInt = 0;


            // sets price 

            if (CappuccinoRB.Checked) priceDec = CAPPUCCINO_PRICE;
            else if (EspressoRB.Checked) priceDec = ESPRESSO_PRICE;
            else if (LatteRB.Checked) priceDec = LATTE_PRICE;
            else if (IcedCappuccinoRB.Checked) priceDec = ICED_PRICE;
            else if (IcedLatteRB.Checked) priceDec = ICED_PRICE;

            try
            {

                quantityInt = int.Parse(QuantityTB.Text);
                itemAmountDec = priceDec * quantityInt;
                subtotalDec += itemAmountDec;

                if (TaxCB.Checked) taxDec = TAX_RATE * subtotalDec;
                else taxDec = 0;

                totalDec = subtotalDec + taxDec;

                // displaying text boxes

                ItemAmountTB.Text = itemAmountDec.ToString("C");
                SubTotalTB.Text = subtotalDec.ToString("n");
                TaxTB.Text = taxDec.ToString("n");
                TotalTB.Text = totalDec.ToString("C");

                TaxCB.Enabled = false;
                ClearBT.Enabled = true;
                clearItemToolStripMenuItem.Enabled = true;
                newOrderToolStripMenuItem.Enabled = true;
            }


            catch
            {
                MessageBox.Show("Quantity must be numeric and drink choice must be selected",
                    "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                QuantityTB.Focus();
                QuantityTB.SelectAll();

            }



                
        }

        private void ClearBT_Click(object sender, EventArgs e)
        {

        }

        private void ItemAmountTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void SubTotalTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void TaxTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void TotalTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void newOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void summaryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        // Exit in File
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calculateSelectionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clearItemToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        // About in Help
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string aboutMessage;
            aboutMessage = "R & R Billing " + Environment.NewLine + "Programmed by Ruby Radosevic";
            MessageBox.Show(aboutMessage, "About Billing", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
