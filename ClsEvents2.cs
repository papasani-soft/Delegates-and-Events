using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{
    public delegate void Transformer(int x);
    class ClsEvents2
    {   
        public static void CreateDelegate()
        {
            Console.WriteLine("enter a number that you want do square");
            int i = int.Parse(Console.ReadLine());
            Transformer t = Square;
            t += Cuber;
            t(i);
            NotificationMethods nm = new NotificationMethods();
            nm.transformerEvent += User1.Xhandler;
            nm.transformerEvent += User2.Xhandler;
            nm.NotifyOnCall(i);
            Console.Read();
        }
        public static void Square(int x)
        {
            Console.WriteLine(x * x);
        }
        public static void Cuber(int x)
        {
            Console.WriteLine(x * x * x);
        }
    }
    class NotificationMethods
    {
        public Transformer transformerEvent;
        public void NotifyOnCall(int x)
        {
            if (transformerEvent != null)
            {
                transformerEvent(x);
            }
        }
    }
    class User1
    {
        public static void Xhandler(int x)
        {
            Console.WriteLine("Event received by User1 object");
        }
    }
    class User2
    {
        public static void Xhandler(int x)
        {
            Console.WriteLine("Event received by User2 object");
        }
    }
}
