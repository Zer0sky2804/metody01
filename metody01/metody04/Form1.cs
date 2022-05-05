using MatematikaUtil;
using poleUnit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace metody04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            int x = int.Parse(textBox2.Text);
            int[] pole = new int[n];
            int d = -100;
            int h = 100;
            pole = Pole.Gen(n, d, h);
            Pole.vypis(pole, listBox1);
            Pole.Nvm(pole, x);
            Pole.vypis(pole, listBox2);       

        }
    }
}
