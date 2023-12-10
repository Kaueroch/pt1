using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _27_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] num = new int[8];
            Random r = new Random();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            for(int i  = 0; i< 8; i++)
            {
                num[i] = r.Next(500);
                listBox1.Items.Add(num[i]);
                listBox2.Items.Add(num[i]);
                listBox3.Items.Add(Math.Pow(num[i],2));
            }
        }
    }
}
