using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;


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
            CappuccinoRB.Checked = true;
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
            CappuccinoRB.Checked = true;
            ItemAmountTB.Clear();
            QuantityTB.Clear();
            QuantityTB.Focus();
            TaxCB.Checked = false;
        }



        private void newOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult responseDialogResult;
            string messageStr;

            messageStr = "Clear the current order figures?";
            responseDialogResult = MessageBox.Show(messageStr, "Clear Order?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);        
        
            if (responseDialogResult == DialogResult.Yes)
            {
                ClearBT_Click(sender, e);
                SubTotalTB.Text = " ";
                TaxTB.Text = " ";
                TotalTB.Text = " ";

                if (subtotalDec != 0)
                    {
                    grandTotalDec += totalDec;
                    countInt += 1;

                    subtotalDec = 0;
                    totalDec = 0;
                    }
                TaxCB.Enabled = true;
                TaxCB.Checked = false;

                ClearBT.Enabled = false;
                clearItemToolStripMenuItem.Enabled = false;
                newOrderToolStripMenuItem.Enabled = false;

            }     
        }

        private void summaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            decimal averageDec;
            string messageStr;

            if (totalDec != 0)
            {
                newOrderToolStripMenuItem_Click(sender, e);
            }

            if (countInt > 0)
            {
                averageDec = grandTotalDec / countInt;
                messageStr = "Number of Orders: " +
                    countInt.ToString() +
                    Environment.NewLine + Environment.NewLine +
                    "Total Sales: " + grandTotalDec.ToString("C") +
                    Environment.NewLine + Environment.NewLine +
                    "Average Sales: " + averageDec.ToString("C");

                MessageBox.Show(messageStr, "Coffee Sales Summary",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);



            }
            else
            {
                messageStr = "No sales to summarize.";
                MessageBox.Show(messageStr, "Coffee Sales Summary",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }


        // Exit in File
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calculateSelectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalculateBT_Click(sender, null);
        }

        private void clearItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearBT_Click(sender, null);
        }

        // About in Help
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string aboutMessage;
            aboutMessage = "R & R Billing " + Environment.NewLine + "Programmed by Ruby Radosevic";
            MessageBox.Show(aboutMessage, "About Billing", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {

            fontDialog1.Font = SubTotalTB.Font;
            fontDialog1.ShowDialog();
            SubTotalTB.Font = fontDialog1.Font;
            TaxTB.Font = fontDialog1.Font;
            TotalTB.Font = fontDialog1.Font;

        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {

            colorDialog1.Color = SubTotalTB.ForeColor;
            colorDialog1.ShowDialog();
            SubTotalTB.ForeColor = colorDialog1.Color;
            TaxTB.ForeColor = colorDialog1.Color;
            TotalTB.ForeColor = colorDialog1.Color;

        }



        // not being used
        private void QuantityTB_TextChanged(object sender, EventArgs e){}
        private void Form1_Load(object sender, EventArgs e){}
        private void textBox2_TextChanged(object sender, EventArgs e){}
        private void TaxCB_CheckedChanged(object sender, EventArgs e){}
        private void ItemAmountTB_TextChanged(object sender, EventArgs e){}
        private void SubTotalTB_TextChanged(object sender, EventArgs e){}
        private void TaxTB_TextChanged(object sender, EventArgs e){}
        private void TotalTB_TextChanged(object sender, EventArgs e){}

    }
}
