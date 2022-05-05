using knihovna03;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matody03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            double u;
            
            if (a == b)
            {
                int o = Class1.obsah(a, out u);
                label4.Text = "Obsah ctverce je " + o + " a uholpricka je " + u;
            }
            else
            {
                int o = Class1.obsah(a, b, out u);
                label4.Text = "Obsah obdelniku je " + o + " a uholpricke je " + u;
            }
        }
        


        private void button2_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c = int.Parse(textBox3.Text);
            double u;
            
            if (a == b && b == c)
            {
                int o = Class1.k(a, out u);
                label5.Text = "osah krychle je " + o + " a uhlopricka je " + u;
            }
            else
            {
                int o = Class1.k(a, b, c, out u);
                label5.Text = "osah kvadru je " + o + " a uhlopricka je " + u;
            }
        }
    }
}
