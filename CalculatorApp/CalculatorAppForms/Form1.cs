
using CalculatorApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorAppForms
{
    public partial class Form1 : Form
    {
        float result = 0;

        float operand1, operand2 = 0;
        string prev_btn = "+";
        Calculator calculator = new Calculator();
        public Form1 ()
        {
            InitializeComponent();
        }

        private void Form1_Load (object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged (object sender, EventArgs e)
        {

        }

        private void Add_Click (object sender, EventArgs e)
        {

            //if (result == 0)
            //{
            //    PerformCalculation(prev_btn);
            //    var btn = sender as Button;
            //    prev_btn = btn.Text;
            //    textBox1.Text = "";
            //}
            //else
            //{

            //    textBox1.Text = Convert.ToString(result);
            //}

            //DisplayResult(result);
            //textBox1.Text = string.Empty;
            if (textBox1.Text != "")
            {
                operand2 = Convert.ToInt32(textBox1.Text);
            }
            else
            {
                operand2 = result;
            }
            //textBox1.Text = "";
            result = PerformCalculation(prev_btn);
            
            operand1 = result;
            var btn = sender as Button;
            prev_btn = btn.Text;
            DisplayResult(result);
            textBox1.Text = Convert.ToString(operand1);
            
            
        }

        private void Substract_Click (object sender, EventArgs e)
        {

            //if (result == 0)
            //{
            //    PerformCalculation(prev_btn);                
            //    var btn = sender as Button;
            //    prev_btn = btn.Text;
            //}
            //else
            //{

            //    PerformCalculation(prev_btn);

            //}
            //DisplayResult(result);
            PerformCalculation(prev_btn);

        }

        private void Multiply_Click (object sender, EventArgs e)
        {
            //if (result == 0)
            //{
            //    PerformCalculation(prev_btn);
            //    var btn = sender as Button;
            //    prev_btn = btn.Text;
            //    textBox1.Text = "";
            //}
            //else
            //{

            //    PerformCalculation(prev_btn);

            //}
            //DisplayResult(result);
            PerformCalculation(prev_btn);
        }

        private void button4_Click (object sender, EventArgs e)
        {

            //if (result == 0)
            //{
            //    PerformCalculation(prev_btn);
            //    // result = Convert.ToInt32(textBox1.Text);
            //    var btn = sender as Button;
            //    prev_btn = btn.Text;

            //}
            //else
            //{
               
            //    PerformCalculation(prev_btn);

            //}
            //DisplayResult(result);
        }
        private void DisplayResult(float Result)
        {
            textBox1.Focus();
            textBox1.SelectAll();
            //result = Result;
            textBox1.Text = "";
        }

        private void btn_Calculate_Click (object sender, EventArgs e)
        {
            
        }

        private void button1_Click (object sender, EventArgs e)
        {
            result = 0;
            textBox1.Text = "";
        }

        private float PerformCalculation(string oper)
        {
          float output = 0;
          switch(oper)
          {
                case "+":
                    output = calculator.Add(operand1, operand2);
                    
                    break;
                case "-":
                    output = calculator.Sub(operand2, operand1);
                    break;
                case "*":
                    output = calculator.Mul(operand1, operand2);
                    break;
                case "/":
                    output = calculator.Div(operand1, operand2);
                    break;
          }

         return output;
        }
    }
}
