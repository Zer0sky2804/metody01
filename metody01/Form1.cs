using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace metody01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static private int SoucetArPosl(int a1,int a2,int n,out int pp,out int rozdil,out string posl)
        {
            rozdil = a2 - a1;
            int vysledek = 0;
            posl = "";
            pp = 0;
            for(int i = 1; i <= n; i++)
            {
                a1 += rozdil;
                vysledek += a1;
                posl += a1.ToString() + ",";
                pp = a1;
            }
            return vysledek;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int n = int.Parse(textBox3.Text);
            int soucet = SoucetArPosl(a, b, n,out int posledni, out int rozdil,out string vse);
            label4.Text = "soucet prvku je " + soucet;
            label5.Text = "posloupnost prvku je " + vse;
            label6.Text = "posledni prvek je " + posledni + ", diference je " + rozdil;
        }
    }
}
