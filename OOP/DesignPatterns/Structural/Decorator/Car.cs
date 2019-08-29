namespace OOP.DesignPatterns.Structural
{
    public abstract class Car
    {
        public string Description { set; get; }
        public abstract string GetDescripton();
        public abstract double GetCarPrice();
    }
}
