using System;

namespace OOP.DesignPatterns.Beahavioral
{
    public class Fan : IFan
    {
        public void Update(ICeleberity celeberity)
        {
            Console.WriteLine($"Fan notified. Tweet of{celeberity.FullName}: {celeberity.Tweet}");
        }
    }
}
