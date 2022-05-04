using System;

namespace knihovna03
{
    public class Class1
    {
        static public int obsah(int a, int b, out double u)
        {
            int ob = a * b;
            u = Math.Sqrt((a * a) + (b * b));
            return ob;
        }

        static public int k(int a, int b, int c, out double u)
        {
            int o = 2 * (a * b + b * c + c * a);
            u = Math.Sqrt((a * a) + (b * b) + (c * c));
            return o;
        }
    }
}
