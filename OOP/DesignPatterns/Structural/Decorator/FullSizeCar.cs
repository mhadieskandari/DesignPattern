namespace OOP.DesignPatterns.Structural
{
    public class FullSizeCar : Car
    {
        public FullSizeCar()
        {
            Description = "Full Size Car";
        }
        public override double GetCarPrice() => 30000.00;

        public override string GetDescripton() => Description;
    }
}
