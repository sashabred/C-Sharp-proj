using System;

namespace Vector
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector v = new Vector();
            v.Append(-5);
            v.Append(4.8);
            v.Append(1.2E5);
            Vector w = new Vector();
            w.Append(2);
            w.Append(3);
            w.Append(4);
            Vector z = new Vector();
            z.Append(5);
            z.Append(6);
            z.Append(8);
            
            Vector y = new Vector();
            y=z.Subtract(w);
            Console.WriteLine(y.GetAll());
            y = z.Add(w);
            Console.WriteLine(y.GetAll());

        }
    }
}
