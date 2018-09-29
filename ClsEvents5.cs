using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{
    public delegate void LinkToEventHandler2(int i);

    class MaleStudent
    {
        string name;
        int Marks;
        public MaleStudent(string nameArg, int marks)
        {
            name = nameArg;
            Marks = marks;
        }
        public void MyActionItem(int i)
        {
            if (i == 1)
                System.Console.WriteLine("{0} Got Admission. He must pay fees", name);
            else
                System.Console.WriteLine(
                  "{0} did not Get Admission. He must lookout for other college", name);
        }
        public int GetMarks()
        {
            return Marks;
        }
    }

    class FemaleStudent
    {
        string name;
        int Marks;

        public FemaleStudent(string nameArg, int marks)
        {
            name = nameArg;
            Marks = marks;
        }
        public void MyActionItem(int i)
        {
            if (i == 1)
                System.Console.WriteLine("{0} got Admission. He must pay fees", name);
            else
                System.Console.WriteLine(
                  "{0} did not Get Admission. He must lookout for other college", name);

        }
        public int GetMarks()
        {
            return Marks;
        }
    }

    class EventGeneratorClass2
    {
        public static event LinkToEventHandler2 AdmissionDeniedEvt;
        public static event LinkToEventHandler2 AdmissionGrantedEvt;

        public static void Main()
        {
            MaleStudent Tom = new MaleStudent("Tom", 95);
            MaleStudent hari = new MaleStudent("hari", 89);
            MaleStudent Harry = new MaleStudent("Harry", 91);

            FemaleStudent Shaka = new FemaleStudent("Shaka", 92);
            FemaleStudent Laka = new FemaleStudent("Laka", 88);
            FemaleStudent Baby = new FemaleStudent("Baby", 91);

            if (Tom.GetMarks() >= 90)
                AdmissionGrantedEvt += new LinkToEventHandler2(Tom.MyActionItem);
            else
                AdmissionDeniedEvt += new LinkToEventHandler2(Tom.MyActionItem);

            if (hari.GetMarks() >= 90)
                AdmissionGrantedEvt += new LinkToEventHandler2(hari.MyActionItem);
            else
                AdmissionDeniedEvt += new LinkToEventHandler2(hari.MyActionItem);

            if (Harry.GetMarks() >= 90)
                AdmissionGrantedEvt += new LinkToEventHandler2(Harry.MyActionItem);
            else
                AdmissionDeniedEvt += new LinkToEventHandler2(Harry.MyActionItem);

            if (Shaka.GetMarks() >= 90)
                AdmissionGrantedEvt += new LinkToEventHandler2(Shaka.MyActionItem);
            else
                AdmissionDeniedEvt += new LinkToEventHandler2(Shaka.MyActionItem);

            if (Laka.GetMarks() >= 90)
                AdmissionGrantedEvt += new LinkToEventHandler2(Laka.MyActionItem);
            else
                AdmissionDeniedEvt += new LinkToEventHandler2(Laka.MyActionItem);

            if (Baby.GetMarks() >= 90)
                AdmissionGrantedEvt += new LinkToEventHandler2(Baby.MyActionItem);
            else
                AdmissionDeniedEvt += new LinkToEventHandler2(Baby.MyActionItem);

            SendEvent();
            Console.Read();
        }

        public static void SendEvent()
        {
            if (AdmissionGrantedEvt != null)
            {
                AdmissionGrantedEvt(1);
            }

            if (AdmissionDeniedEvt != null)
            {
                AdmissionDeniedEvt(0);
            }
        }
    }
}
