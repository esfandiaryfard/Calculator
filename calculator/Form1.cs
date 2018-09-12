using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {

        int a;
        int b=1;
        calculate c1;
        
        public Form1()
        {
            InitializeComponent();
            c1=new calculate(a,b);
            
            
        }
         
        private void Addbtn_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            textBox1.Text = c1.add(a, b).ToString();
            textBox2.Clear();
        }

        private void sub_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            textBox1.Text = c1.subtract(a, b).ToString();
            textBox2.Clear();


        }


        private void multiple_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            textBox1.Text = c1.multiple(a, b).ToString();
            textBox2.Clear();


        }

        private void divide_Click(object sender, EventArgs e)
        {

            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            textBox1.Text = c1.divide(a, b).ToString();
            textBox2.Clear();

        }

        
    }
}
