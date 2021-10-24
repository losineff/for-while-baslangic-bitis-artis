using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bas = Convert.ToInt32(textBox1.Text);
            int bit = Convert.ToInt32(textBox2.Text);
            int art = Convert.ToInt32(textBox3.Text);
            if (bas < bit)
            {
                for (int a = bas; a <= bit; a += art)
                {
                    comboBox1.Items.Add(a);
                }
            }
            else
            {
                for (int a = bas; a >= bit; a -= art)
                {
                    comboBox1.Items.Add(a);
                }
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            int bas = Convert.ToInt32(textBox1.Text);
            int bit = Convert.ToInt32(textBox2.Text);
            int art = Convert.ToInt32(textBox3.Text);
            if (bas < bit)
            {
                int a = bas;
                while (a <= bit)
                {
                    comboBox2.Items.Add(a);
                    a += art;
                }
            }
            else
             {
               int a = bas;
               while (a >= bit)
                {
                    comboBox2.Items.Add(a);
                    a -= art;
                }
            }


        }
    }
}
