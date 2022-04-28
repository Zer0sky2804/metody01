using knihovna01;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matody01b
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int n = int.Parse(textBox3.Text);
            int soucet =Pole.SoucetArPosl(a, b, n, out int posledni, out int rozdil, out string vse);
            label4.Text = "soucet prvku je " + soucet;
            label5.Text = "posloupnost prvku je " + vse;
            label6.Text = "posledni prvek je " + posledni + ", diference je " + rozdil;
        }
    }
}
