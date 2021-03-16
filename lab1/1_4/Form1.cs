using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_4
{
    public partial class Form1 : Form
    {
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Label label = new Label();
            label.Text = "label " + count.ToString();
            label.Font = new Font("Arial", 10, FontStyle.Bold | FontStyle.Italic);
            label.Location = new Point(10, 40+20 * count++);
            label.Click += new EventHandler(MyClick);
            this.Controls.Add(label);
        }
        private void MyClick(object sender, EventArgs e)
        {
            label0.Text = "Останній натиснутий елемент під номером: " + sender.ToString().Split(" ")[3];
        }
    }
}
