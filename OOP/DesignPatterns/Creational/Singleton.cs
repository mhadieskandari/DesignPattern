using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.DesignPatterns
{    
    public class Policy
    {
        private static readonly Policy _Instance=new Policy();
        public static Policy Instance {
            get
            {
                //if (_Instance == null)
                //{
                //    _Instance = new Policy();
                //}
                return _Instance;
            }
        }
        private int Id { set; get; } = 123;
        private string Insured { set; get; } = "hadi eskandari";
            
        public string GetInsured()
        {
            return Insured;
        }

    }
}
