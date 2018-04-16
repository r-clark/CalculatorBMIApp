// __Author__ = r-clark
// This is my first windows application with C# to calculate a user's BMI
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlatBmiCalc
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.AcceptButton = buttonCalculate;//Allows for "Enter" key on keyboard to click "Enter" button
            this.CancelButton = buttonClear;//Allows for "ESC" key on keyboard to click "Clear" button
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            double height, weight, userBMI, roundBMI;//variables for apllication

            height = Convert.ToDouble(textHeight.Text);//initializing height variable, must be conveted from string to double
            weight = Convert.ToDouble(textWeight.Text);//initializing weight variable, must be conveted from string to double

            userBMI = (weight * 703) / (height * height);//equation used to calculate the user's BMI
            roundBMI = System.Math.Round(userBMI, 1);//rounding the user's BMI to the tenths place

            labelBmiOut.Text = Convert.ToString(roundBMI);//displaying the user's BMI (Convert back to string from double)
            
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            labelBmiOut.Text = "";//clearing user BMI
            textHeight.Text = "";//clearing user Height
            textWeight.Text = "";//clearing user Weight
        }

        private void toolTipBMI_Popup(object sender, PopupEventArgs e)
        {
            //tool tip that displays the department of HHS BMI ranges
        }
    }
}
