using System;

namespace knihovna01
{
    public class Pole
    {
        static public int SoucetArPosl(int a1, int a2, int n, out int pp, out int rozdil, out string posl)
        {
            rozdil = a2 - a1;
            int vysledek = 0;
            posl = "";
            pp = 0;
            for (int i = 1; i <= n; i++)
            {
                a1 += rozdil;
                vysledek += a1;
                posl += a1.ToString() + ",";
                pp = a1;
            }
            return vysledek;
        }
    }
}
