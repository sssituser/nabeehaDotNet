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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtNum1.Text);
            int num2 = int.Parse(txtNum2.Text);
            lblResult.Text = $"Sum is  {num1 + num2}";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtNum1.Text = txtNum2.Text =string.Empty;
            lblResult.Text = "Result";
        }
    }
}
