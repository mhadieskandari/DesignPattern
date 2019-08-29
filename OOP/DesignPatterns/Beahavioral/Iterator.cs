using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP.DesignPatterns.Beahavioral
{

    public interface INewsPaper
    {
        IIterator CreateIterator();
    }

    public class LAPaper : INewsPaper
    {
        private string[] _reporters;
        public LAPaper()
        {
            _reporters = new string[] {
                "john smitt - LA",
                "gary bolton - LA",
                "nocolas caje - LA",
                "sara vandella - LA"
            };
        }
        public IIterator CreateIterator()
        {
            return new LANewsIterator(_reporters);
        }
    }

    public class NYPaper : INewsPaper
    {
        private List<string> _reporters;
        public NYPaper()
        {
            _reporters = new List<string> {
                "john smitt - NY",
                "gary bolton - NY",
                "nocolas caje - NY",
                "sara vandella - NY"
            };
        }
        public IIterator CreateIterator()
        {
            return new NYNewsIterator(_reporters);
        }
    }


    public interface IIterator
    {
        void First();
        string Next();
        bool IsDone();
        string CurrentItem();

    }

    public class LANewsIterator : IIterator
    {
        private string[] _reporters;
        private int _current;
        public LANewsIterator(string[] reporters)
        {
            _reporters = reporters;
            _current = 0;
        }
        public string CurrentItem()
        {
            return _reporters[_current];
        }

        public void First()
        {
            _current = 0;
        }

        public bool IsDone()
        {
            return _current < _reporters.Length;
        }

        public string Next()
        {
            return _reporters[_current++];
        }
    }

    public class NYNewsIterator : IIterator
    {
        private List<string> _reporters;
        private int _current;

        public NYNewsIterator(List<string> reporters)
        {
            _reporters = reporters;
            _current = 0;
        }
        public string CurrentItem()
        {
            return _reporters.ElementAt(_current);
        }

        public void First()
        {
            _current = 0;
        }

        public bool IsDone()
        {
            return _current < _reporters.Count();
        }

        public string Next()
        {
            return _reporters.ElementAt(_current++);
        }
    }
}
