using System.Collections.Generic;

namespace OOP.DesignPatterns.Beahavioral
{
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
}
