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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            for (int i = 10; i <= 100; i++) { 
             comboBox1.Items.Add(i.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            int age = int.Parse(comboBox1.SelectedItem.ToString());
            string dob = dateTimePicker1.Text;
            string gen = string.Empty;
            if (radioButton1.Checked)
            {
                gen = radioButton1.Text;
            }else if (radioButton2.Checked)
            {
                gen = radioButton2.Text;    
            }
            string hob = string.Empty;
            if (checkBox1.Checked)
            {
                hob += checkBox1.Text;
            }
            if (checkBox2.Checked)
            {
                hob += checkBox2.Text;
            }
            if (checkBox3.Checked)
            {
                hob += checkBox3.Text;
            }
            if (checkBox4.Checked)
            {
                hob += checkBox4.Text;
            }
            string address = textBox2.Text;
            label7.Text = $"Name :{name}\nAge : {age}\nGen :{gen}\nHoobies : {hob}\nDate of Birth :{dob}\n Address : {address}";
        }
    }
}
