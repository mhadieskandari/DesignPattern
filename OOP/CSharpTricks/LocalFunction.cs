using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.CSharpTricks
{
    public class LocalFunction
    {
        public int GetAverage(int a ,int b,int c)
        {
            return avg(a, b, c);
            int avg(int aa,int bb,int cc)
            {
                return (aa + bb + cc) / 3;
            }
        }
    }
}
