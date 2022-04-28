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

namespace metody02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {     int[] pole;
            int n = int.Parse(textBox1.Text);
            if (textBox2.Text == "" && textBox3.Text == "")
            {
                pole = Pole.Generuj(n);
            }
            else
            {
            int a=int.Parse(textBox2.Text);
            int b=int.Parse(textBox3.Text);
                pole = Pole.Gen(n, a, b);   
            }

            Pole.vypis(pole, listBox1);
            int sude;
            int liche;
            bool ros = Pole.rost(pole);
            Pole.lichasuda(pole, out sude, out liche);
            Pole.vymena(pole);
            Pole.vypis(pole, listBox2);
            label6.Text = "Soucet cudych je " + sude + " pocet lichych je " + liche;
            if (ros)
            {
                label7.Text = "Funkce je rostouci";
            }
            else
            {
                label7.Text = "Funkce neni rostouci";
            }

        }
    }
}
