using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompanyManagementSystem
{
    public partial class CalculatorPanel : Form
    {
        double FirstNum;
        string operation;

        public CalculatorPanel()
        {
            InitializeComponent();
        }

        private void CalculatorPanel_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxMonitor.Text == "0")
            {
                textBoxMonitor.Text = "1";

            }
            else
            {
                textBoxMonitor.AppendText("1");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBoxMonitor.Text == "0")
            {
                textBoxMonitor.Text = "2";

            }
            else
            {
                textBoxMonitor.AppendText("2");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBoxMonitor.Text == "0")
            {
                textBoxMonitor.Text = "3";

            }
            else
            {
                textBoxMonitor.AppendText("3");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBoxMonitor.Text == "0")
            {
                textBoxMonitor.Text = "4";

            }
            else
            {
                textBoxMonitor.AppendText("4");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBoxMonitor.Text == "0")
            {
                textBoxMonitor.Text = "5";

            }
            else
            {
                textBoxMonitor.AppendText("5");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBoxMonitor.Text == "0")
            {
                textBoxMonitor.Text = "6";

            }
            else
            {
                textBoxMonitor.AppendText("6");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBoxMonitor.Text == "0")
            {
                textBoxMonitor.Text = "7";

            }
            else
            {
                textBoxMonitor.AppendText("7");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBoxMonitor.Text == "0")
            {
                textBoxMonitor.Text = "8";

            }
            else
            {
                textBoxMonitor.AppendText("8");
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBoxMonitor.Text == "0")
            {
                textBoxMonitor.Text = "9";

            }
            else
            {
                textBoxMonitor.AppendText("9");
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (textBoxMonitor.Text == "0")
            {
                textBoxMonitor.Text = "0";

            }
            else
            {
                textBoxMonitor.AppendText("0");
            }
        }

        private void buttonDecimel_Click(object sender, EventArgs e)
        {
            textBoxMonitor.Text = textBoxMonitor.Text + ".";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxMonitor.Text = "0";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FirstNum = Convert.ToDouble(textBoxMonitor.Text);
            textBoxMonitor.Text = "0";
            operation = "+";
        }

        private void buttonsub_Click(object sender, EventArgs e)
        {
            FirstNum = Convert.ToDouble(textBoxMonitor.Text);
            textBoxMonitor.Text = "0";
            operation = "-";
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            FirstNum = Convert.ToDouble(textBoxMonitor.Text);
            textBoxMonitor.Text = "0";
            operation = "*";
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            FirstNum = Convert.ToDouble(textBoxMonitor.Text);
            textBoxMonitor.Text = "0";
            operation = "/";
        }

        private void buttonequal_Click(object sender, EventArgs e)
        {
            double SecondNum;
            double result;
            SecondNum = Convert.ToDouble(textBoxMonitor.Text);
            if(operation=="+")
            {
                result = (FirstNum + SecondNum);
                textBoxMonitor.Text = Convert.ToString(result);
                FirstNum = result;
            }
            if (operation == "-")
            {
                result = (FirstNum - SecondNum);
                textBoxMonitor.Text = Convert.ToString(result);
                FirstNum = result;
            }
            if (operation == "*")
            {
                result = (FirstNum * SecondNum);
                textBoxMonitor.Text = Convert.ToString(result);
                FirstNum = result;
            }
            if (operation == "/")
            {
                if(SecondNum==0)
                {
                    textBoxMonitor.Text = "Syntex error";
                }
                else
                {
                    result = (FirstNum / SecondNum);
                    textBoxMonitor.Text = Convert.ToString(result);
                    FirstNum = result;
                }
                
            }
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }
    }
}
