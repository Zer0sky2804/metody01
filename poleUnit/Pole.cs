using System;
using System.Windows.Forms;

namespace poleUnit
{
    public class Pole
    {
        static public int[] Generuj(int n )
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
        static public int[] Gen(int n, int dol,int hor)
        {
            Random nh = new Random();
            int[] x = new int[n];

            for (int i = 0; i < n; i++)
            {
                x[i] = nh.Next(dol, hor);

            }
            return x;
        }
        static public void vypis(int[]pole,ListBox lb)
        {
            lb.Items.Clear();
            for (int i = 0; i < pole.Length; i++)
            {
                
                lb.Items.Add(pole[i]);
            }
        }
        static public void lichasuda(int[]pole,out int suda, out int licha)
        {
            suda = 0;
            licha = 0;
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
        static public bool rost(int[] pole)
        {
            bool r = true;
            int a = pole[0];
            for (int i = 1; i < pole.Length; i++)
            {
                if (pole[i] < a)
                {
                    r = false;
                }
                a = pole[i];
            }
            return r;
        } 
        static public void vymena(int[] pole)
        {
            int max = 0;
            int pmax = 0;
            int last = 0;
            int plast = 0;
            for (int i = 0; i < pole.Length; i++)
            {
                if (pole[i] > max)
                {
                    max = pole[i];
                    pmax = i;
                }
                last = pole[i];
                plast = i;
            }
            pole[pmax] = last;
            pole[plast] = max;

        }
    }
}
