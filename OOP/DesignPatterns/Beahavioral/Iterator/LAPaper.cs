namespace OOP.DesignPatterns.Beahavioral
{
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
}
