using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace KalkulatorSederhana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label4.Text = "";
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hasil("+");
        }

        bool validate()
        {
            if (textBox1.TextLength < 0 || textBox2.TextLength < 0)
            {
                MessageBox.Show("Error", "Semua input wajib di isi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        void hasil(string op)
        {
            if (!validate())
            {
                return;
            }

            int a, b, result;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);

            if (op == "+")
            {
                result = a + b;
                label4.Text = result.ToString();
            }

            if (op == "-")
            {
                result = a - b;
                label4.Text = result.ToString();
            }

            if (op == "*")
            {
                result = a * b;
                label4.Text = result.ToString();
            }

            if (op == "/")
            {
                result = a / b;
                label4.Text = result.ToString();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            hasil("-");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hasil("*");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hasil("/");
        }
    }
}
