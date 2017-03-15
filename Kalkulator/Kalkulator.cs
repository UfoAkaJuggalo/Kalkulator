using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Kalkulator : Form
    {
        private byte dzialanie = 0;
        private float memory = 0, operand = 0;
        private bool kropka = false, clearDisplay = true;

        private void kropkaCheck()
        {
            if (this.txtDisplay.Text.IndexOf(".") >0)
            {
                this.kropka = true;
            }
            else
            {
                this.kropka = false;
            }
        }
        public Kalkulator()
        {
            InitializeComponent();
        }
        private void calculate(byte operationType)
        {
            float operandB = float.Parse(this.txtDisplay.Text);
            if(this.dzialanie == 0)
            {
                this.operand = operandB;
                this.clearDisplay = true;
                this.kropka = false;
                this.dzialanie = operationType;
            }
            else
            {
                if(this.dzialanie == operationType)
                {
                    this.operand = this.operationCalculation(this.operand, operandB, this.dzialanie);
                    this.txtDisplay.Text = Convert.ToString(this.operand);
                    this.clearDisplay = true;
                    this.kropka = false;
                }
                else
                {
                    if (this.clearDisplay)
                    {
                        this.dzialanie = operationType;
                    }
                    else
                    {
                        this.operand = this.operationCalculation(this.operand, operandB, this.dzialanie);
                        this.txtDisplay.Text = Convert.ToString(this.operand);
                        this.clearDisplay = true;
                        this.kropka = false;
                        this.dzialanie = operationType;
                    }
                }
            }
        }
        private float operationCalculation(float operA, float operB, byte operType)
        {
            float result = 0;
            switch(operType)
            {
                case 1:
                    result = operA + operB;
                    break;
                case 2:
                    result = operA - operB;
                    break;
                case 3:
                    result = operA * operB;
                    break;
                case 4:
                    result = operA / operB;
                    break;
            }
            return result;
        }
        private void buttCalc_Click(object sender, EventArgs e)
        {
            if (this.dzialanie > 0)
            {
                float operandB = float.Parse(this.txtDisplay.Text);
                this.operand = this.operationCalculation(this.operand, operandB, this.dzialanie);
                this.txtDisplay.Text = Convert.ToString(this.operand);
                this.clearDisplay = true;
                this.kropka = false;
                this.dzialanie = 0;
            }
        }

        private void buttC_Click(object sender, EventArgs e)
        {
            this.clearDisplay = true;
            this.kropka = false;
            this.operand = 0;
            this.memory = 0;
            this.dzialanie = 0;
            this.txtDisplay.Text = "0";
        }

        private void buttDot_Click(object sender, EventArgs e)
        {
            if (!this.kropka)
            {
                if (this.clearDisplay)
                {
                    this.txtDisplay.Text = "0,";
                    this.clearDisplay = false;
                }
                else
                {
                    this.txtDisplay.Text += ",";
                }
                this.kropka = true;
            }
        }

        private void buttPlus_Click(object sender, EventArgs e)
        {
            this.calculate(1);
        }

        private void buttMinus_Click(object sender, EventArgs e)
        {
            this.calculate(2);

        }
        private void buttMult_Click(object sender, EventArgs e)
        {
            this.calculate(3);
        }

        private void buttDivide_Click(object sender, EventArgs e)
        {
            this.calculate(4);
        }
        private void buttM_Click(object sender, EventArgs e)
        {
            this.memory = float.Parse(this.txtDisplay.Text);
        }

        private void buttMR_Click(object sender, EventArgs e)
        {
            this.txtDisplay.Text = Convert.ToString(this.memory);
            this.kropkaCheck();
        }


        private void buttSign_Click(object sender, EventArgs e)
        {
            float number = -1 * float.Parse(this.txtDisplay.Text);
            this.txtDisplay.Text = Convert.ToString(number);

        }

        private void buttNum_Click(object sender, EventArgs e)
        {
            var buttTxt = ((Button)sender).Text;
            if ((this.txtDisplay.Text == "0")||(this.clearDisplay))
            {
                this.txtDisplay.Text = buttTxt;
                this.clearDisplay = false;
            }
            else
            {
                this.txtDisplay.Text += buttTxt;
            }
        }
    }
}
