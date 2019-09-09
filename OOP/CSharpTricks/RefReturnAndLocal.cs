using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.CSharpTricks
{
    public class RefReturnAndLocal
    {
        public int GetLargest(int a,int b)
        {
            if (a > b)
                return a;
            return b;
        }

        public ref int GetLargest(ref int a,ref int b)
        {
            if (a > b)
                return ref a;
            return ref b;
        }
    }
}
