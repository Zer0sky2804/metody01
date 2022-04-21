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

        static private int Generuj( int dol = 0, int hor = 100)
        {
            Random nh = new Random();
            int x = nh.Next(dol , hor );
            return x;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            int a=int.Parse(textBox2.Text);
            int b=int.Parse(textBox3.Text);
            int sude = 0;
            int liche = 0;
            int[] pole = new int[n];
            int max = b- 1;
            int pmax=0;
            for(int i = 0; i < n; i++)
            {
                pole[i]= Generuj( a, b);
                listBox1.Items.Add(pole[i]);
                if (Generuj( a, b) % 2 == 0)
                {
                    sude += Generuj( a, b);
                }
                else
                {
                    liche++;
                }
                if (Generuj( a, b) > max)
                {
                    max = Generuj( a, b);
                    pmax = i;
                }
                
            }
            

        }
    }
}
