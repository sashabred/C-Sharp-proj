using System;
using Vector;

namespace _2_2_Vector
{
    class Program
    {
        static void Main(string[] args)
        {
            MyVector v = new MyVector();
            v.Append(-5);
            v.Append(4.8);
            v.Append(1.2E5);
            MyVector w = new MyVector();
            w.Append(2);
            w.Append(3);
            w.Append(4);
            MyVector z = new MyVector();
            z.Append(2);
            z.Append(3);
            z.Append(4);

            MyVector result = v + w;
            MyVector iValue = result + 23;
            Console.WriteLine(z.Divide(2.1));
            
            bool wEqualsZ = w == z;
            bool vEqualsW = v == w;

            Console.WriteLine(vEqualsW);
            Console.WriteLine(wEqualsZ);
            Console.WriteLine(v.GetElementAt(1));
        }

    }
}
