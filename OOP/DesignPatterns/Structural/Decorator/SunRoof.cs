namespace OOP.DesignPatterns.Structural
{
    public class SunRoof : CarDecorator
    {
        public SunRoof(Car car) : base(car)
        {
            Description = "SunRoof";
        }

        public override double GetCarPrice() => _car.GetCarPrice() + 2700;

        public override string GetDescripton() => $"{_car.GetDescripton()}, {Description}";
    }
}
