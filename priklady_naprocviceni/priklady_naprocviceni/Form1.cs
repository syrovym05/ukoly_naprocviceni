using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace priklady_naprocviceni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form u1 = new u1();
            u1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form u2 = new u2();
            u2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form u3 = new u3();
            u3.Show();            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("dsaod");
        }
    }
}
