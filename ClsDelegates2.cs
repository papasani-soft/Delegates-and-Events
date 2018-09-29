using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{
    class Utility
    {
       public delegate int Transformer(int x);
        public static int Transform(int x, Transformer t)
        {
            return x = t(x);
        }
    }
    class ClsDelegates2
    {     
        public static void CreateDelegate()
        {
            Console.WriteLine("enter a number that you want do square");
            int i = int.Parse(Console.ReadLine());
            int result= Utility.Transform(i,Square);
            Console.WriteLine(result);
            Console.Read();
        }
        public static int Square(int x)
        {
            return x * x;
        }
        public static int Cuber(int x)
        {
            return x * x * x;
        }
    }
}
