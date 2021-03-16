using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_5
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            label1.Text = "Початок роботи";
            textBox1.Text = "";
            this.BackColor = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
        }
    }
}
