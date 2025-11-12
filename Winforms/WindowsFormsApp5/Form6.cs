using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        int a,b;
        string oper = string.Empty;
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3;
               
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4;
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5;
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6;
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7;
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8;
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9;
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += 0;
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            oper = "+";
            a = int.Parse(textBox1.Text);
            textBox1.Text = string.Empty;
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            oper = "-";
            a = int.Parse(textBox1.Text);
            textBox1.Text = string.Empty;
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            oper = "x";
            a = int.Parse(textBox1.Text);
            textBox1.Text = string.Empty;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            oper = "/";
            a = int.Parse(textBox1.Text);
            textBox1.Text = string.Empty;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            switch (oper)
            {
                case "+":
                    
                    a += int.Parse(textBox1.Text);
                    break;
                   
                case "-":
                    a-=int.Parse(textBox1.Text);
                    break;
                case "x":
                    a*=int.Parse(textBox1.Text);
                    break;
                case "/":
                    a/=int.Parse(textBox1.Text);
                    break;

            }
            textBox1.Text = a.ToString();
        }
    }
}
