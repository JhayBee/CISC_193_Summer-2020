using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Takes the user input and converts it from a String to a decimal
            // Assigns those decimals to variables: length and width
            decimal length = Convert.ToDecimal(txtLength.Text);
            decimal width = Convert.ToDecimal(txtWidth.Text);

            // Calculates area and perimeter
            // Can begin calculation by pressing the Enter key or selecting the Calculate button
            // Displays these values in their corresponding read-only text boxes
            txtArea.Text = Convert.ToString(length * width);
            txtPerimeter.Text = Convert.ToString((2 * width) + (2 * length));

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Closes the form when you hit the ESC key
            this.Close();
        }
    }
}
