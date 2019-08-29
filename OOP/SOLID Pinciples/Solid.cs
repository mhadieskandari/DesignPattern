using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Solid
{
    class Solid
    {
    }

    public interface IPerson
    {
        void ShowInfo();
    }
    public abstract class Person /*: IPerson*/
    {
        //public abstract void ShowInfo();
        public void ShowInfo() { return; }
    }

    public class Teacher : Person
    {
        public new void ShowInfo()
        {
            Console.WriteLine("I am a teacher!");
        }
    }

    public class Student : Person
    {
        public new void ShowInfo()
        {
            Console.WriteLine("I am a student!");
        }
    }

    public class Persion1
    {
        public void ShowInfo()
        {
            Console.WriteLine("I am a teacher!");
        }
    }
    public class Teacher1 : Persion1
    {
        public new void ShowInfo()
        {
            Console.WriteLine("I am a teacher!");
        }
    }
}
