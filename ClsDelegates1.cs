using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{
    class ClsDelegates1
    {
        delegate int Transformer(int x);
        public static int Square(int x)
        {
            return x * x;
        }
        public static void CreateDelegate()
        {
            Console.WriteLine("enter a number that you want do square");
            int i = int.Parse(Console.ReadLine());
            Transformer t = Square;
            int j=t(i);
            Console.WriteLine(j);
            Console.Read();
        }
    }
}
