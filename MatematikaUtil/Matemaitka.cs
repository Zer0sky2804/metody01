using System;

namespace MatematikaUtil
{
    public class Matemaitka
    {
        static public int Mocnina(int cislo,int x)
        {
            int moc = 1;
            for (int p = 0; p < x; p++)
            {
                moc *= cislo;
            }
            return moc;
        }
    }
}
