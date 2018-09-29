using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{
    class ClsMulticastDelegate
    {
        delegate void Transformer(int x);      
        public static void CreateDelegate()
        {
            Console.WriteLine("enter a number that you want do square");
            int i = int.Parse(Console.ReadLine());
            Transformer t = Square;
            t += Cuber;
            t(i);
            Console.Read();       
        }
        public static void Square(int x)
        {
            Console.WriteLine( x * x);
        }
        public static void Cuber(int x)
        {
            Console.WriteLine( x * x * x);
        }
    }
}
