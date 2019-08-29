using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.DesignPatterns.FactoryMethod
{
    class FactoryMethod
    {
    }
    public abstract class ISavingAccount
    {
        public decimal Balance { set; get; }
    }

    public class CitiSavingAccount : ISavingAccount
    {
        public CitiSavingAccount()
        {
            Balance = 2000;
        }
    }

    public class NationalSavingAccount : ISavingAccount
    {
        public NationalSavingAccount()
        {
            Balance = 5000;
        }
    }

    public interface ICreateUnionFactory
    {
        ISavingAccount GetSavingAccount(Type type);
    }

    public class SavingAccountFactory : ICreateUnionFactory
    {
        public ISavingAccount GetSavingAccount(Type type)
        {
            if (type == typeof(NationalSavingAccount))
            {
                return new NationalSavingAccount();
            }
            else if (type == typeof(CitiSavingAccount))
            {
                return new CitiSavingAccount();
            }
            throw new ArgumentException("there isn't any type as you passed");
        }
    }
}
