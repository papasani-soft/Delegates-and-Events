using System;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a program no. to execute");
            int i = Convert.ToInt32(Console.ReadLine());
            switch (i)
            {
                case 1:
                    ClsDelegates1.CreateDelegate();
                    break;
                case 2:
                    ClsDelegates2.CreateDelegate();
                    break;
                case 3:
                    ClsMulticastDelegate.CreateDelegate();
                    break;
                case 4:
                    ClsAnonymous.CreateDelegate();
                    break;
                case 5:
                    ClsLamdaExpressions.CreateDelegate();
                    break;
                case 6:
                    ClsEvents1.CreateEvent();
                    break;
                case 7:
                    ClsEvents2.CreateDelegate();
                    break;
                default:
                    break;
            }
        }
    }
}
