using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{
    public delegate void LinkToEventHandler1();

    class Client1
    {
        string name;
        public Client1(string nameArg)
        {
            name = nameArg;
        }
        public void Client1EventHandler()
        {
            System.Console.WriteLine("EventHandler Called for object {0}", name);
        }
    }

    class Client2
    {
        string name;
        public Client2(string nameArg)
        {
            name = nameArg;
        }
        public void Client2EventHandler()
        {
            System.Console.WriteLine("EventHandler Called for object {0}", name);
        }
    }

    class EventGeneratorClass1
    {
        public static event LinkToEventHandler Evt;

        public static void Main()
        {
            Client1 c1_o1 = new Client1("Object1 of Client1 class");
            Client1 c1_o2 = new Client1("Object2 of Client1 class");
            Client1 c1_o3 = new Client1("Object3 of Client1 class");

            Client2 c2_o1 = new Client2("Object1 of Client2 class");
            Client2 c2_o2 = new Client2("Object2 of Client2 class");
            Client2 c2_o3 = new Client2("Object3 of Client2 class");

            Evt += new LinkToEventHandler(c1_o1.Client1EventHandler);
            Evt += new LinkToEventHandler(c1_o2.Client1EventHandler);
            Evt += new LinkToEventHandler(c1_o3.Client1EventHandler);

            Evt += new LinkToEventHandler(c2_o1.Client2EventHandler);
            Evt += new LinkToEventHandler(c2_o2.Client2EventHandler);
            Evt += new LinkToEventHandler(c2_o3.Client2EventHandler);

            DoSomething();
            Console.Read();
        }

        public static void DoSomething()
        {
            System.Console.WriteLine("Something Happened! We need to send an event.");
            SendEvent();
        }

        public static void SendEvent()
        {
            if (Evt != null)
            {
                Evt();
            }
        }
    }
}
