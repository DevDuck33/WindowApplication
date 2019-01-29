using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Double Value = 0;
        String Operation = "";
        bool Operation_Pressed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if((Result.Text == "0")||(Operation_Pressed))
            {
                Result.Clear();
            }
            Operation_Pressed = false;
            Button Button = (Button)sender;
            Result.Text = Result.Text + Button.Text;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Result.Text = "0";
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button Button = (Button)sender;
            Operation = Button.Text;
            Value = Double.Parse(Result.Text);
            Operation_Pressed = true;
            equation.Text = Value + " " + Operation;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            equation.Text = "";
            switch (Operation)
            {
                case "+":
                    {
                        Result.Text = (Value + Double.Parse(Result.Text)).ToString();
                        break;
                    }
                case "-":
                    {
                        Result.Text = (Value - Double.Parse(Result.Text)).ToString();
                        break;
                    }
                case "/":
                    {
                        Result.Text = (Value / Double.Parse(Result.Text)).ToString();
                        break;
                    }
                case "*":
                    {
                        Result.Text = (Value * Double.Parse(Result.Text)).ToString();
                        break;
                    }
                default:
                    break;
            }
            Operation_Pressed = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Result.Text = "0";
            equation.Text = "";
            Value = 0;
        }
    }
}
