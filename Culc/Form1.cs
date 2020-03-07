using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Culc
{
    public partial class Form1 : Form
    {
        public double num1, num2;
        public string D;
        public int val;
        public bool flag = true;

        public Form1()
        {
            InitializeComponent();
        }
        private void calculate()
        {
            switch (val)
            {
                case 43:
                    if (textBox1.Text == "")
                    {
                        num2 = num1 + num1;
                        textBox1.Text = num2.ToString();
                    }
                    else
                    {
                        num2 = num1 + double.Parse(textBox1.Text);
                        textBox1.Text = num2.ToString();
                    }
                    break;

                case 45:
                    if (textBox1.Text == "")
                    {
                        num2 = num1 - num1;
                        textBox1.Text = num2.ToString();
                    }
                    else
                    {
                        num2 = num1 - double.Parse(textBox1.Text);
                        textBox1.Text = num2.ToString();
                    }
                    break;
                case 120:
                    if (textBox1.Text == "")
                    {
                        num2 = num1 * num1;
                        textBox1.Text = num2.ToString();
                    }
                    else
                    {
                        num2 = num1 * double.Parse(textBox1.Text);
                        textBox1.Text = num2.ToString();
                    }
                    break;
                case 47:
                    if (textBox1.Text == "")
                    {
                        num2 = num1 / num1;
                        textBox1.Text = num2.ToString();
                    }
                    else
                    {
                        num2 = num1 / double.Parse(textBox1.Text);
                        textBox1.Text = num2.ToString();
                    }
                    break;

                default:
                    break;
            }

        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            calculate();
            label1.Text = "";
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains(","))
            {
                return;
            }
            textBox1.Text += ",";
            
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Text = "0";
            label1.Text = "";
        }

        private void buttonС_Click(object sender, EventArgs e)
        {
            int lenght = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
            if(textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ташкинов Дмитрий 18 лет\nСтудент 1-го курса ПМИ миопд", "Справка");
        }

        private void button0_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            B.BackColor = System.Drawing.Color.Transparent;
            if (textBox1.Text == "0" && label1.Text == "")
            {
                textBox1.Clear();
                textBox1.Text = B.Text;
            }
            else
            {
                textBox1.Text += B.Text;
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            D = B.Text;
            

            if (label1.Text.Contains("+") || label1.Text.Contains("-") || label1.Text.Contains("x") || label1.Text.Contains("/"))
            {
                val = char.Parse(D);
                label1.Text = num1.ToString() + D;
                flag = true;
            }
            else
            {
                num1 = double.Parse(textBox1.Text);
                textBox1.Clear();
                val = char.Parse(D);
                label1.Text = num1.ToString() + D;
                flag = true;
            }

        }

        private void buttonZnak_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                if (textBox1.Text == "" )
                {
                    return;
                }
                if (textBox1.Text == "0")
                {
                    return;
                }
                textBox1.Text = "-" + textBox1.Text;
                flag = false;
            }
            else if (flag == false)
            {
                textBox1.Text = textBox1.Text.Replace("-", "");
                flag = true;
            }
        }
    }
}