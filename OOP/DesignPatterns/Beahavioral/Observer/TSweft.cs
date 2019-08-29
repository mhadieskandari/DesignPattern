﻿using System.Collections.Generic;

namespace OOP.DesignPatterns.Beahavioral
{
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
