using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.DesignPatterns.Beahavioral
{
    public interface ICeleberity
    {
        string FullName { get; }
        string Tweet { get; set; }
        void Nodify(string tweet);
        void AddFollower(IFan fan);
        void RemoveFollower(IFan fan);
    }

    public interface IFan
    {
        void Update(ICeleberity celeberity);
    }

    public class Fan : IFan
    {
        public void Update(ICeleberity celeberity)
        {
            Console.WriteLine($"Fan notified. Tweet of{celeberity.FullName}: {celeberity.Tweet}");
        }
    }


    public class GCloony : ICeleberity
    {

        private readonly List<IFan> _fans = new List<IFan>();
        private string _tweet;


        public GCloony(string tweet)
        {
            _tweet = tweet;
        }

        public string FullName  { get => "George Cloony"; }

        public string Tweet { get { return _tweet; }
            set
            {
                Nodify(value);
            }
        }

        public void AddFollower(IFan fan)
        {
            _fans.Add(fan);
        }

        public void Nodify(string tweet)
        {
            _tweet = tweet;
            foreach(var fan in _fans)
            {
                fan.Update(this);
            }
        }

        public void RemoveFollower(IFan fan)
        {
            _fans.Remove(fan);
        }
    }

    public class TSweft : ICeleberity
    {

        private readonly List<IFan> _fans = new List<IFan>();
        private string _tweet;


        public TSweft(string tweet)
        {
            _tweet = tweet;
        }

        public string FullName { get => "Taylor Sweet"; }

        public string Tweet
        {
            get { return _tweet; }
            set
            {
                Nodify(value);
            }
        }

        public void AddFollower(IFan fan)
        {
            _fans.Add(fan);
        }

        public void Nodify(string tweet)
        {
            _tweet = tweet;
            foreach (var fan in _fans)
            {
                fan.Update(this);
            }
        }

        public void RemoveFollower(IFan fan)
        {
            _fans.Remove(fan);
        }
    }
}
