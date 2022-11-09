using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture_12_RadioButtons_CheckBoxes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // CHeckboxes
            // Panel
            PizzaDefault();


        }

        public void PizzaDefault()
        {
            // Sets rbMedium to true, selecting it
            rbMedium.Checked = true;
            rbRegular.Checked = true;
        }

        private void btnShowPizzaStuff_Click(object sender, EventArgs e)
        {
            // Make sure to call your method
            CalculatePizzaOrder();
        }

        // Holds the code to calculate our pizza order


        public void CalculatePizzaOrder()
        {
            string pizzaSize, pizzaCrust;
            string recipt = "Slice of Pi Pizza\n";
            recipt += $"Name: {txtPizzaName.Text}\n";
            recipt += $"---------------------------\n";
            // Keeps track of our subsubTotal
            double subTotal = 0;

           

            // Radio buttons
            // Group together with a panel or group box for multiple sets of radio buttons

            // To get the selected value use .checked on the radio button name

            // Use an if / else if / else structure
            if (rbSmall.Checked)
            {
                /*rtbEnroll.Text = "Pizza Size: Small";*/ // 10
                subTotal += 10;
                pizzaSize = "Small";
            }
            else if (rbMedium.Checked)
            {
                /*rtbEnroll.Text = "Pizza Size: Medium";*/ // 13
                subTotal += 13;
                pizzaSize = "Medium";
            }
            else if(rbLarge.Checked)
            {
                /*rtbEnroll.Text = "Pizza Size: Large";*/ // 15
                subTotal += 15;
                pizzaSize = "Large";

            }
            else 
            {
                /*rtbEnroll.Text = "Pizza Size: Extra Large";*/ // 18
                subTotal += 18;
                pizzaSize = "XL";
            }

            // Crusts
            if (rbRegular.Checked)
            {
                subTotal += 0;
                pizzaCrust = "Regular";
            }
            // Crusts
            else if (rbStuffed.Checked)
            {
                subTotal += 3;
                pizzaCrust = "Stuffed Crust";
            }
            // Crusts
            else 
            {
                subTotal += 1.50;
                pizzaCrust = "Garlic Crust";
            }

            // Displays pizza size and crust
            recipt += $"{pizzaSize} {pizzaCrust} Pizza\n\n";
            recipt += $"Toppings:\n";

            // ----------------------------------------------

            // Responds if a checkbox is checked
            // Use .checked to return if a checkbox is check
            if (chkPepperoni.Checked) // Pepperoni
            {
                double itemPrice = 2.50;
                subTotal += itemPrice;
                recipt += $"Pepperoni - {itemPrice.ToString("c")}\n";
            }

            if (chkMushrooms.Checked) // Mushrooms - 1
            {
                double itemPrice = 1;
                subTotal += itemPrice;
                recipt += $"Mushroom - {itemPrice.ToString("c")}\n";
            }

            if (chkPineapple.Checked) // Pineapple - 4
            {
                double itemPrice = 4;
                subTotal += itemPrice;
                recipt += $"Pineapple - {itemPrice.ToString("c")}\n";
            }

            if (chkXCheese.Checked) // Extra Cheese - 1
            {
                double itemPrice = 1;
                subTotal += itemPrice;
                recipt += $"Extra Cheese - {itemPrice.ToString("c")}\n";
            }
            // Checkboxes
            // To access a checkbox, use the checkboxes name
            //rtbEnroll.Text = chkPepperoni.Checked.ToString();

            recipt += $"-----------------------------\n";
            // Display Price Information
            recipt += $"Subtotal: {subTotal.ToString("c")}\n";

            double taxPercent = .1;
            double taxAmount = CalculateTax(subTotal, taxPercent);

            recipt += $"Tax: {taxPercent * 100}% - {taxAmount.ToString("c")}\n";

            double finalTotal = subTotal + taxAmount;

            recipt += $"Total: {finalTotal.ToString("c")}";

            // DIsplays the subTotal amount of the pizza
            rtbEnroll.Text = recipt;
        }

        // This method will take a subtotal, and a percent, and return a tax amount
        public double CalculateTax(double subTotal, double taxPercent)
        {

            return subTotal * taxPercent;

        } // CalculateTax()

            /*
            * Slice of PI Pizza
            * Name: {Users Name}
            * -------------------------------
            * {Pizza Size} {Pizza Crust} Pizza
            * Toppings:
            * {LIst of toppings}
            * --------------------------------
            * SubsubTotal: {subsubTotal value}
            * Tax: {dollar amount of tax}
            * subTotal: {subTotal Costs}
            */

        #region ExampleCode
        private void btnEnroll_Click(object sender, EventArgs e)
        {
            rtbEnroll.Text = "";
            string name = tbName.Text;


            // Check check boxes for classes selected
            string classes = "Classes:\n";

            if (chkWeb.Checked) classes += "Web Developement\n";

            if (chkGame.Checked) classes += "Game Development\n";

            if (chkDatabase.Checked) classes += "Database\n";

            if (chkProg.Checked) classes += "Programming\n";

            // Check radio buttons for quarter selected
            string quarter = "Quarter: ";

            if(rbFall.Checked)
            {
                quarter += "Fall";
            }
            else if (rbWinter.Checked) {
                quarter += "Winter";
            }
            else if (rbSpring.Checked)
            {
                quarter += "Spring";
            }
            else
            {
                quarter += "Summer";

            }

            string enroll = $"" +
                $"Student: {name}\n\n" +
                $"{quarter}\n\n" +
                $"{classes}";

            rtbEnroll.Text = enroll;

        }
        #endregion ExampleCode


    }
}
