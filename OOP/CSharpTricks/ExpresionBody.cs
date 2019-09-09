using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.CSharpTricks
{
    public class ExpresionBody
    {
        private int _initVal;
        public int InitVal
        {
            set { _initVal = value; }
            get { return _initVal; }
        }

        public ExpresionBody(int initVal) => InitVal = initVal;

        ~ExpresionBody() => Console.WriteLine("Release Unmanaged Code!");

    }
}
