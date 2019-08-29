using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.DesignPatterns.Structural
{
    public abstract class Car
    {
        public string Description { set; get; }
        public abstract string GetDescripton();
        public abstract double GetCarPrice();
    }

    public class CompactCar : Car
    {
        public CompactCar()
        {
            Description = "Compact Car";
        }
        public override double GetCarPrice() => 10000.00;

        public override string GetDescripton() => Description;
    }

    public class FullSizeCar : Car
    {
        public FullSizeCar()
        {
            Description = "Full Size Car";
        }
        public override double GetCarPrice() => 30000.00;

        public override string GetDescripton() => Description;
    }

    public class CarDecorator : Car
    {
        protected Car _car;
        public CarDecorator(Car car)
        {
            _car = car;
        }

        public override double GetCarPrice() => _car.GetCarPrice();

        public override string GetDescripton() => _car.GetDescripton();
    }

    public class LeatherSeats : CarDecorator
    {
        public LeatherSeats(Car car) : base(car)
        {
            Description = "LeatherSeats";
        }

        public override double GetCarPrice() => _car.GetCarPrice()+2500;

        public override string GetDescripton() => $"{_car.GetDescripton()}, {Description}";
    }

    public class SunRoof : CarDecorator
    {
        public SunRoof(Car car) : base(car)
        {
            Description = "SunRoof";
        }

        public override double GetCarPrice() => _car.GetCarPrice() + 2700;

        public override string GetDescripton() => $"{_car.GetDescripton()}, {Description}";
    }
    public class Navigation : CarDecorator
    {
        public Navigation(Car car) : base(car)
        {
            Description = "Navigation";
        }

        public override double GetCarPrice() => _car.GetCarPrice() + 3000;

        public override string GetDescripton() => $"{_car.GetDescripton()}, {Description}";
    }
}
