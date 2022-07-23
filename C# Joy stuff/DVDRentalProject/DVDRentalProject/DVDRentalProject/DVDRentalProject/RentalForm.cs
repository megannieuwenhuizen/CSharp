using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DVDRentalProject
{
    public partial class RentalForm : Form
    {

        //declare public variables here
        const decimal ChildrenTaxRate = 0.05M;    //these are constants
        const decimal ComedyTaxRate  = 0.07M;
        const decimal otherTaxRate  = 0.1M;

        public RentalForm()
        {
            InitializeComponent();
        }

        
        private decimal calculateTax(decimal price)
        {

            decimal taxPrice = 0;
            if (ChildrenGenre.Checked)
            {
                taxPrice = ChildrenTaxRate * price;
            }
            else if (ComedyGenre.Checked)
            {
                taxPrice = ComedyTaxRate * price;
            }
            else if (ActionGenre.Checked || AdventureGenre.Checked)
            {
                taxPrice = otherTaxRate * price;
            }

            return taxPrice;
        }
        
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            //declare local variables here
            decimal decPrice;
            if ((ChildrenGenre.Checked == true)|| (ComedyGenre.Checked ==true)|| 
                (ActionGenre.Checked ==true)||(AdventureGenre.Checked==true))
            {

                if (string.IsNullOrEmpty(PriceTextBox.Text))
                {
                    MessageBox.Show("Please enter some data");

                }
                else
                {
                    
                    decPrice = decimal.Parse(PriceTextBox.Text);
                    TaxTextBox.Text = calculateTax(decPrice).ToString();             
                    AmountTextBox.Text = (decPrice + decimal.Parse(TaxTextBox.Text)).ToString("C");
                    CustomerGroupBox.Visible = true;
                    CustomerLabel.BackColor = Color.LightYellow;
                    CustomerLabel.Text = " Hi " + CustomerName.Text + Environment.NewLine +
                                            "Your total account accrued is" +
                                           Environment.NewLine + AmountTextBox.Text;
                    GenreGroupBox.Enabled = false;
                }
                }
            else
                MessageBox.Show("please make a Genre selection");
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
              PriceTextBox.Clear();
              TaxTextBox.Clear();
              AmountTextBox.Clear();
              CustomerLabel.Text = "";
        }

        private void RentalForm_Load(object sender, EventArgs e)
        {
            ChildrenGenre.Checked = false;
            ComedyGenre.Checked = false;
            ActionGenre.Checked = false;
            AdventureGenre.Checked = false;
            CustomerGroupBox.Visible = false;
        }
        
    }
}
