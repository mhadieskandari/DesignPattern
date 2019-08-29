using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.DesignPatterns.Structural
{
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
