using System;
using System.Linq;
using System.Text;

namespace OOP.DesignPatterns.Beahavioral
{
    public interface IIterator
    {
        void First();
        string Next();
        bool IsDone();
        string CurrentItem();
    }
}
