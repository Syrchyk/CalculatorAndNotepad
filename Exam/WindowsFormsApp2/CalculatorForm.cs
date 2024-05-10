using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private bool isCalculate = false;
        private double res = 0;
        private void button_Click(object sender, EventArgs e)
        {
           
            if(sender is Button)
            {
                if(!isCalculate)
                {
                    if (textBox1.Text == "/" || textBox1.Text == "*" || textBox1.Text == "-" || textBox1.Text == "+")
                    {
                        textBox1.Text = (sender as Button).Text;
                    }
                    else
                    {
                        textBox1.Text += (sender as Button).Text;
                    }   
                }
                else
                {
                    textBox2.Text = res.ToString();
                    if (textBox1.Text == "/" || textBox1.Text == "*" || textBox1.Text == "-" || textBox1.Text == "+")
                    {
                        textBox1.Text = (sender as Button).Text;
                    }
                    else
                    {
                        textBox1.Text += (sender as Button).Text;
                    }
                    isCalculate = false;
                }
            }
        }
        private void buttonNotNumber_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                if (!isCalculate)
                {
                    textBox2.Text = "";
                }
                textBox2.Text += textBox1.Text;
                textBox2.Text += (sender as Button).Text;
                textBox1.Text = (sender as Button).Text;
            }
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            textBox2.Text += textBox1.Text;

            string[] a = textBox2.Text.Split('/', '*', '-', '+');
            string[] b = textBox2.Text.Split('1', '2', '3', '4', '5', '6', '7', '8', '9', '0');
            List<string> bList = new List<string>(b.ToList());
            for (int i = 0; i < bList.Count; i++)
            {
                if (bList[i] == "")
                {
                    bList.Remove("");
                    i--;
                }

            }
            if (!String.IsNullOrEmpty(a[0]))
            {
                res = Convert.ToDouble(a[0]);
            }
            else
            {
                return;
            }
            for (int i = 0; i < a.Length-1; i++)
            {
                double secondRes = Convert.ToDouble(a[i+1]);
                switch (bList[i])
                {
                    case "/": res = res / secondRes; break;
                    case "*": res = res * secondRes; break;
                    case "-": res = res - secondRes; break;
                    case "+": res = res + secondRes; break;
                }
            }
            textBox1.Text = res.ToString();
            isCalculate = true;
        }

        private void buttonPlusMinus_Click(object sender, EventArgs e)
        {
            if(Convert.ToDouble(textBox1.Text) > 0)
            {
               textBox1.Text = "-" + textBox1.Text;
            }
            else
            {
                textBox1.Text = (Math.Abs(Convert.ToDouble(textBox1.Text))).ToString();
            }
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            textBox1.Text = ""; 
            if(!String.IsNullOrEmpty(a))
            {
                for (int i = 0; i < a.Length - 1; i++)
                {
                    textBox1.Text += a[i];
                }
            }
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
