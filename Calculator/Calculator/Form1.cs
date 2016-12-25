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
        Calculator calculator;
        double operand;
        string deistvie_1;
        string deistvie_2;
        bool beghinOperatin;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            calculator = new Calculator();
            operand = 0;
            beghinOperatin = true;
            label1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";
        }

        private void buttonENTER_Click(object sender, EventArgs e)
        {
            operand = Read();
            MesagFromCalculator();
            deistvie_1 = "=";
            richTextBox1.Text = calculator.ShouList();
            label1.Text =  calculator.ShouRegister();
            Cleaning();
        }

        private void buttonADD_Click(object sender, EventArgs e)
        {
            if (beghinOperatin)
            {
                operand = Read();
                calculator.Add(operand);
                beghinOperatin = false;
                deistvie_1 = "+";
            }
            else
            {
                deistvie_2 = "+";
                operand = Read();
                MesagFromCalculator();
                deistvie_1 = deistvie_2;
            }
            
            Cleaning();
            richTextBox1.Text = calculator.ShouList()+"+";
            label1.Text = calculator.ShouRegister();
        }

        private void MesagFromCalculator()
        {
            if (deistvie_1 == "+")
            {
                 calculator.Add(operand);
            }

            if (deistvie_1 == "-")
            {
                 calculator.Sub(operand);
            }

            if (deistvie_1 == "*")
            {
                 calculator.Mul(operand);
            }

            if (deistvie_1 == "/")
            {
                 calculator.Div(operand);
            }
        }

        private void buttonSUB_Click(object sender, EventArgs e)
        {
            if (beghinOperatin)
            {
                operand = Read();
                calculator.Add(operand);
                beghinOperatin = false;
                deistvie_1 = "-";
            }
            else
            {
                deistvie_2 = "-";
                operand = Read();
                MesagFromCalculator();
                deistvie_1 = deistvie_2;
            }

            Cleaning();
            richTextBox1.Text = calculator.ShouList() + "-";
            label1.Text =  calculator.ShouRegister();
        }

        private void buttonMUL_Click(object sender, EventArgs e)
        {
            if (beghinOperatin)
            {
                operand = Read();
                calculator.Add(operand);
                beghinOperatin = false;
                deistvie_1 = "*";
            }
            else
            {
                deistvie_2 = "*";
                operand = Read();
                MesagFromCalculator();
                deistvie_1 = deistvie_2;
            }

            Cleaning();
            richTextBox1.Text = calculator.ShouList() + "*";
            label1.Text =calculator.ShouRegister();
        }

        private void buttonDIV_Click(object sender, EventArgs e)
        {
            if (beghinOperatin)
            {
                operand = Read();
                calculator.Add(operand);
                beghinOperatin = false;
                deistvie_1 = "/";
            }
            else
            {
                deistvie_2 = "/";
                operand = Read();
                MesagFromCalculator();
                deistvie_1 = deistvie_2;
            }

            Cleaning();
            richTextBox1.Text = calculator.ShouList() + "/";
            label1.Text =calculator.ShouRegister();
        }

        private void buttonRedo_Click(object sender, EventArgs e)
        {
            
            calculator.Redo(1);
            Cleaning();
            richTextBox1.Text = calculator.ShouList();
            label1.Text = calculator.ShouRegister();
        }

        private void buttonUndo_Click(object sender, EventArgs e)
        {
            calculator.Undo(1);
            Cleaning();
            richTextBox1.Text = calculator.ShouList();
            label1.Text = calculator.ShouRegister();
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            beghinOperatin = true;
            calculator.Cleaning();
            richTextBox1.Text = calculator.ShouList();
            label1.Text = "";
        }

        private void Cleaning()
        {
            textBox1.Text = "";
        }

        private double Read()
        {
            if (textBox1.Text == "") return 0;
            return Convert.ToDouble(textBox1.Text);
        }
    }
}
