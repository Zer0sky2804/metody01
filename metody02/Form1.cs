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

        static private int[] Generuj(int n )
        {
            Random nh = new Random();
            int [] x= new int[n];
            int dol = 1;
            int hor = 100;
            for (int i = 0; i < n; i++)
            {
                 x[i] = nh.Next(dol, hor);
                
            }
            return x;
        }


        static private void vypis(int[]pole,ListBox lb)
        {
            lb.Items.Clear();
            for (int i = 0; i < pole.Length; i++)
            {
                
                lb.Items.Add(pole[i]);
            }
        }


        static private int ls(int[]pole,out int suda, out int licha)
        {


            for (int i = 0; i < pole.Length; i++)
            {
                if (pole[i] % 2 == 0)
                {
                    suda += pole[i];
                }
                else
                {
                    licha++;
                }
            }
        }




        private void button1_Click(object sender, EventArgs e)
        {     int[] pole;
            int n = int.Parse(textBox1.Text);
            if (textBox2.Text == "" && textBox3.Text == "")
            {
                pole = Generuj(n);
            }
            else
            {
            int a=int.Parse(textBox2.Text);
            int b=int.Parse(textBox3.Text);

            }
            int sude = 0;
            int liche = 0;
            int max = 0;
            int pmax=0;
       
            
                if (x[i] > max)
                {
                    max = x[i];
                    pmax = i;
                }

        }
    }
}
