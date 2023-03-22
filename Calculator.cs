using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace finalProject
{
    public partial class Calculator : Form
    {
        private decimal currentValue;
        private decimal operand1;
        private decimal operand2;
        private string op;
        private bool isOperationClicked = false;
        public Calculator()
        {
            InitializeComponent();
            Clear();
        }

        public decimal CurrentValue
        {
            get { return Math.Round(currentValue,8); }
        }

        public void Add(decimal displayValue)
        {
            operand1 = displayValue;
            currentValue = displayValue;
            op = "+";
        }

        public void Subtract(decimal displayValue)
        {
            operand1 = displayValue;
            currentValue = displayValue;
            op = "-";
        }

        public void Multiply(decimal displayValue)
        {
            operand1 = displayValue;
            currentValue = displayValue;
            op = "*";
        }

        public void Divide(decimal displayValue)
        {
            operand1 = displayValue;
            currentValue = displayValue;
            op = "/";
        }

        public void Equals()
        {
            switch (op)
            {
                case "+":
                    currentValue = operand1 + operand2;
                    break;
                case "-":
                    currentValue = operand1 - operand2;
                    break;
                case "*":
                    currentValue = operand1 * operand2;
                    break;
                case "/":
                    if (operand2 == 0)
                    {
                        MessageBox.Show("Cannot divide by zero");
                    } 
                    else
                    {
                        currentValue = operand1 / operand2;
                    }
                    break;
            }

            string path = @".\files\Calculator.txt";
            string dir = @".\files\";
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            try
            {
                FileStream fileStream = new FileStream(path, FileMode.Append, FileAccess.Write);
                StreamWriter writer = new StreamWriter(fileStream);
                writer.WriteLine($"{operand1} {op} {operand2} = {CurrentValue}");
                writer.Close();
                fileStream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured, try again. \n" + ex.Message);
            }
            operand1 = currentValue;
        }

        public void Equals(decimal displayValue)
        {
            operand2 = displayValue;
            Equals();
        }

        public void Clear()
        {
            currentValue = 0;
            operand1 = 0;
            operand2 = 0;
            op = null;
            textBox.Text = "0";
        }

        private void exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to quit the calculator?", "Exit", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                this.Close();
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (!textBox.Text.Contains("."))
            {
                textBox.Text += ".";
                isOperationClicked = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isOperationClicked)
            {
                MessageBox.Show("Select another number");
            }
            else
            {
                Add(decimal.Parse(textBox.Text));
                textBox.Text = "+";
                isOperationClicked = true;
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (isOperationClicked)
            {
                MessageBox.Show("Select another number");
            }
            else
            {
                Subtract(decimal.Parse(textBox.Text));
                textBox.Text = "-";
                isOperationClicked = true;
            }
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            if (isOperationClicked)
            {
                MessageBox.Show("Select another number");
            }
            else
            {
                Multiply(decimal.Parse(textBox.Text));
                textBox.Text = "*";
                isOperationClicked = true;
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (isOperationClicked)
            {
                MessageBox.Show("Select another number");
            }
            else
            {
                Divide(decimal.Parse(textBox.Text));
                textBox.Text = "/";
                isOperationClicked = true;
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            try
            {
                Equals(decimal.Parse(textBox.Text));
                textBox.Text = CurrentValue.ToString();
                operand1 = 0;
                operand2 = 0;
                op = null;
            }
            catch
            {
                MessageBox.Show("An error occured, please review the operations entered!", "Error");
                Clear();
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (isOperationClicked)
            {
                textBox.Text = "1";
                isOperationClicked = false;
            }
            else if (textBox.Text == "0")
            {
                    textBox.Text = "1";
            } 
            else
            {
                    textBox.Text += "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (isOperationClicked)
            {
                textBox.Text = "2";
                isOperationClicked = false;
            }
            else if (textBox.Text == "0")
            {
                textBox.Text = "2";
            }
            else
            {
                textBox.Text += "2";
            }

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (isOperationClicked)
            {
                textBox.Text = "3";
                isOperationClicked = false;
            }
            else if (textBox.Text == "0")
            {
                textBox.Text = "3";
            }
            else
            {
                textBox.Text += "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (isOperationClicked)
            {
                textBox.Text = "4";
                isOperationClicked = false;
            }
            else if (textBox.Text == "0")
            {
                textBox.Text = "4";
            }
            else
            {
                textBox.Text += "4";
            }

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (isOperationClicked)
            {
                textBox.Text = "5";
                isOperationClicked = false;
            }
            else if (textBox.Text == "0")
            {
                textBox.Text = "5";
            }
            else
            {
                textBox.Text += "5";
            }

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (isOperationClicked)
            {
                textBox.Text = "6";
                isOperationClicked = false;
            }
            else if (textBox.Text == "0")
            {
                textBox.Text = "6";
            }
            else
            {
                textBox.Text += "6";
            }

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (isOperationClicked)
            {
                textBox.Text = "7";
                isOperationClicked = false;
            }
            else if (textBox.Text == "0")
            {
                textBox.Text = "7";
            }
            else
            {
                textBox.Text += "7";
            }

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (isOperationClicked)
            {
                textBox.Text = "8";
                isOperationClicked = false;
            }
            else if (textBox.Text == "0")
            {
                textBox.Text = "8";
            }
            else
            {
                textBox.Text += "8";
            }

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (isOperationClicked)
            {
                textBox.Text = "9";
                isOperationClicked = false;
            }
            else if (textBox.Text == "0")
            {
                textBox.Text = "9";
            }
            else
            {
                textBox.Text += "9";
            }

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (isOperationClicked)
            {
                textBox.Text = "0";
                isOperationClicked = false;
            }
            else if (textBox.Text == "0")
            {
                textBox.Text = "0";
            }
            else
            {
                textBox.Text += "0";
            }

        }
    }
}
