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
    public partial class Calculator : Form
    {

        float firstNum, secondNum, result;
        char operation;
        bool dec = false;
        List<string> calculationHistory = new List<string>();
        string calculation;

        private void AddToHistory(string calculation)
        {
            calculationHistory.Add(calculation);
        }

        // Metoda pentru a obține întregul istoric
        private string[] GetHistory()
        {
            return calculationHistory.ToArray();
        }

        private void changeLebel(int numPressed)
        {
            if (dec == true)
            {
                int decimalCount = 0;
                foreach (char c in displayLabel.Text)
                {
                    if (c == '.')
                    {
                        decimalCount++;
                    }
                }
                if (decimalCount < 1)
                {
                    displayLabel.Text = displayLabel.Text + ".";
                }
                dec = false;
            }
            else
            {
                if (displayLabel.Text.Equals("0") == true && displayLabel.Text != null)
                {
                    displayLabel.Text = numPressed.ToString();
                }
                else if (displayLabel.Text.Equals("-0") == true)
                {
                    displayLabel.Text = "-" + numPressed.ToString();
                }
                else
                {
                    displayLabel.Text = displayLabel.Text + numPressed.ToString();
                }
            }
        }

        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
        }

        private void num1_Click(object sender, EventArgs e)
        {
            changeLebel(1);
        }

        private void num2_Click(object sender, EventArgs e)
        {
            changeLebel(2);
        }

        private void num3_Click(object sender, EventArgs e)
        {
            changeLebel(3);
        }

        private void num4_Click(object sender, EventArgs e)
        {
            changeLebel(4);
        }

        private void num5_Click(object sender, EventArgs e)
        {
            changeLebel(5);
        }

        private void num6_Click(object sender, EventArgs e)
        {
            changeLebel(6);
        }

        private void num7_Click(object sender, EventArgs e)
        {
            changeLebel(7);
        }

        private void num8_Click(object sender, EventArgs e)
        {
            changeLebel(8);
        }

        private void num9_Click(object sender, EventArgs e)
        {
            changeLebel(9);
        }

        private void zeroBtn_Click(object sender, EventArgs e)
        {
            changeLebel(0);
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            displayLabel.Text = "0";
            firstNum = 0;
            secondNum = 0;
            result = 0;
            operation = '\0';
            dec = false;
        }

        private void equalBtn_Click(object sender, EventArgs e)
        {
            result = 0;
            if (displayLabel.Text.Equals("0") == false)
            {
                switch (operation)
                {
                    case '+':
                        secondNum = float.Parse(displayLabel.Text);
                        result = firstNum + secondNum;

                        calculation = firstNum.ToString() + " + " + secondNum.ToString() + " = " + result.ToString();
                        break;
                    case '-':
                        secondNum = float.Parse(displayLabel.Text);
                        result = firstNum - secondNum;

                        calculation = firstNum.ToString() + " - " + secondNum.ToString() + " = " + result.ToString();
                        break;
                    case '/':
                        secondNum = float.Parse(displayLabel.Text);
                        result = firstNum / secondNum;

                        calculation = firstNum.ToString() + " / " + secondNum.ToString() + " = " + result.ToString();
                        break;
                    case '*':
                        secondNum = float.Parse(displayLabel.Text);
                        result = firstNum * secondNum;

                        calculation = firstNum.ToString() + " * " + secondNum.ToString() + " = " + result.ToString();
                        break;
                    default:
                        break;
                }
                calculationHistory.Add(calculation);
                foreach (string calculation in calculationHistory)
                {
                    Console.WriteLine(calculation);
                }
            }
            displayLabel.Text = result.ToString();
        }

        private void plusBtn_Click(object sender, EventArgs e)
        {
            firstNum = float.Parse(displayLabel.Text);
            operation = '+';
            result = result + firstNum;
            displayLabel.Text = "";
        }

        private void minusBtn_Click(object sender, EventArgs e)
        {
            firstNum = float.Parse(displayLabel.Text);
            operation = '-';
            result = result - firstNum;
            displayLabel.Text = "";
        }

        private void multiplyBtn_Click(object sender, EventArgs e)
        {
            firstNum = float.Parse(displayLabel.Text);
            operation = '*';
            result = result * firstNum;
            displayLabel.Text = "";
        }

        private void devideBtn_Click(object sender, EventArgs e)
        {
            firstNum = float.Parse(displayLabel.Text);
            operation = '/';
            result = result / firstNum;
            displayLabel.Text = "";
        }

        private void backspaceBtn_Click(object sender, EventArgs e)
        {
            int stringLength = displayLabel.Text.Length;
            if (stringLength > 1)
            {
                displayLabel.Text = displayLabel.Text.Substring(0, stringLength - 1);
            }
            else
            {
                displayLabel.Text = "0";
            }
        }

        private void history_Click(object sender, EventArgs e)
        {
            // Închide formularul curent (Form1)
            this.Hide();

            // Deschide formularul istoric (HistoryForm) și furnizează lista de istoric de calcul
            HistoryForm historyForm = new HistoryForm(calculationHistory);
            historyForm.ShowDialog();

            // După ce formularul istoric este închis, afișează din nou formularul curent (Form1)
            this.Show();
        }

        private void decimalBtn_Click(object sender, EventArgs e)
        {
            dec = true;
            changeLebel(0);
        }

        private void plusMinusBtn_Click(object sender, EventArgs e)
        {
            displayLabel.Text = "-" + displayLabel.Text;
        }
    }
}
