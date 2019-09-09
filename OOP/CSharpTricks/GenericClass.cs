using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.CSharpTricks
{
    public class GenericClass<T>
    {
        private T _type;

        public GenericClass(T type) => _type = type;


        public void GetTypeName()
        {
            Console.WriteLine($"the type is {_type.GetType()}");
        }
    }

    public class GenericClassIDisposable<T> where T : IDisposable
    {
        private T _type;

        public GenericClassIDisposable(T type) => _type = type;


        public void GetTypeName()
        {
            Console.WriteLine($"the type is {_type.GetType()}");
        }
    }
}
