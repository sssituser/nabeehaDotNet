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
    public partial class Form5 : Form
    {
        int a, b;
        public Form5()
        {
            InitializeComponent();
        }
        public  void ReadAb()
        {
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
        }
        private void button1_Click(object sender, EventArgs e)
        {
           ReadAb();
            label1.Text = $"Sum {a + b}";
            button1.Text = $"{a + b}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReadAb();
            label1.Text = $"Sub {a - b}";
            button2.Text = $"{a - b}";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReadAb();
            label1.Text = $"Mul {a * b}";
            button3.Text = $"{a * b}";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ReadAb();
            button4.Text = $"{a / b}";
            label1.Text = $"Quo {a / b}";
        }
    }
}
