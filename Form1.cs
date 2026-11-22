using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            double height = double.Parse(heightbox.Text) /100;
            double weight =double.Parse(weightbox.Text);
            double bmi = weight / (height * height);
            bmilbl.Text ="Your BMI is: " +Math.Round(bmi, 1);
            if (bmi < 18.5)
            {bmirslt.Text ="Underweight";
                bmirslt.ForeColor = Color.Orange;
            }
            else if (bmi < 25)
            {bmirslt.Text = "Normal weight";
                bmirslt.ForeColor = Color.Green;
            }
            else
            {bmirslt.Text = "Overweight";
                bmirslt.ForeColor = Color.Red;
            }




        }

        private void bmiresult_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

