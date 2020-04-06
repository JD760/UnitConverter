using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void unitInputDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void unitOutputDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void conversionInputBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void conversionOutputBox_Click(object sender, EventArgs e)
        {

        }
        private void convertButton_Click(object sender, EventArgs e)
        {
            bool isValid = inputValidation();
            if (isValid)
            {
                // if both validation checks have passed, execute the conversion method
                convertToUnits();
            }
        }
        #region helper and validation methods
        /// <summary>
        /// Method to validate user input in preparation for casting in Unit Conversion methods
        /// and to ensure that units are selected from both drop-down boxes 
        /// </summary>


        private bool isDecimalValidation()
        {
            try
            {
                decimal userInput = Convert.ToDecimal(this.conversionInputBox.Text);
                return true;
            }
            catch (System.FormatException)
            {
                this.conversionOutputBox.Text = "Invalid input, must be valid integer";
                this.conversionInputBox.Text = "";
                return false;
            }
        }
        private bool inputValidation()
        {
            if (this.unitInputDropdown.SelectedItem == null || this.unitOutputDropdown.SelectedItem == null)
            {
                this.conversionOutputBox.Text = "Please Select a unit for both drop down boxes";
                return false;
            }
            bool isDecimal = isDecimalValidation();
            if(isDecimal)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
        #region Unit conversion
        /// <summary>
        /// Methods to convert user's input into a standard unit, in this case metres(m) and then convert
        /// into the desired units for output onto the windows forms application
        /// </summary>
        /// <returns> user input converted to metres, returned as a decimal number</returns>


        private decimal userInputToMetres()
        {
            // converts the user's input units to the default (Metres) for easier conversion
            // to desired output units


            decimal userInput = Convert.ToDecimal(this.conversionInputBox.Text);
            switch (this.unitInputDropdown.SelectedItem.ToString())
            {
                case "Kilometre":
                    userInput *= 1000;
                    break;

                case "Metre":
                    userInput = userInput * 1;
                    break;

                case "Centimetre":
                    userInput /= 100;
                    break;

                case "Millimetre":
                    userInput /= 1000;
                    break;

                case "Micrometre":
                    userInput /= 1000000; // one million
                    break;

                case "Nanometre":
                    userInput /= 1000000000; // one billion
                    break;

                case "Mile":
                    userInput *= 1609.34M;
                    break;

                case "Yard":
                    userInput /= 1.094M;
                    break;

                case "Foot":
                    userInput /= 3.281M;
                    break;

                case "Inch":
                    userInput /= 39.37M;
                    break;

                case "Nautical Mile":
                    userInput *= 1852;
                    break;
            }
            return userInput;
        }
        private void convertToUnits()
        {
            decimal convertedUserInput = userInputToMetres();
            switch (this.unitOutputDropdown.SelectedItem.ToString())
            {
                case "Kilometre":
                    convertedUserInput /= 1000;
                    break;
                case "Metre":
                    convertedUserInput *= 1;
                    break;
                case "Centimetre":
                    convertedUserInput *= 100;
                    break;
                case "Millimetre":
                    convertedUserInput *= 1000;
                    break;
                case "Micrometre":
                    convertedUserInput *= 1000000; // one million
                    break;
                case "Nanometre":
                    convertedUserInput *= 1000000000; // one billion
                    break;
                case "Mile":
                    convertedUserInput /= 1609;
                    break;
                case "Yard":
                    convertedUserInput *= 1.094M;
                    break;
                case "Foot":
                    convertedUserInput *= 3.281M;
                    break;
                case "Inch":
                    convertedUserInput *= 39.37M;
                    break;
                case "Nautical Mile":
                    convertedUserInput /= 1852;
                    break;
            }
            conversionOutputBox.Text = Convert.ToString(convertedUserInput);
        }
        #endregion
    }
}
