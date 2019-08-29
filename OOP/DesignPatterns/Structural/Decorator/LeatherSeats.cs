namespace OOP.DesignPatterns.Structural
{
    public class LeatherSeats : CarDecorator
    {
        public LeatherSeats(Car car) : base(car)
        {
            Description = "LeatherSeats";
        }

        public override double GetCarPrice() => _car.GetCarPrice()+2500;

        public override string GetDescripton() => $"{_car.GetDescripton()}, {Description}";
    }
}
