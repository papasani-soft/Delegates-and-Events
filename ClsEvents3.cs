using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{
    public delegate void LinkToEventHandler();

    class Client
    {
        string name;
        public Client(string nameArg)
        {
            name = nameArg;
        }
        public void Client1EventHandler()
        {
            System.Console.WriteLine("EventHandler Called for object {0}", name);
        }
    }

    class EventGeneratorClass
    {
        public static event LinkToEventHandler Evt;

        public static void Main()
        {
            Client c1_o1 = new Client("Object1 of Client1 class");
            Evt += new LinkToEventHandler(c1_o1.Client1EventHandler);
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
