using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.DesignPatterns.FactoryAbstract
{



    public interface IloanAccount { }
    public interface ISavingAccount { }

    public abstract class ICreateUnionFactory
    {
        public abstract IloanAccount CreateloanAccount();
        public abstract ISavingAccount CreateSavingAccount();

    }



    public class CitiSavingAccount:ISavingAccount
    {
        public  CitiSavingAccount()
        {
            Console.WriteLine("CitiSavingAccount");
        }
    }
    public class CitiLoanAccount : IloanAccount
    {
        public CitiLoanAccount()
        {
            Console.WriteLine("CitiLoanAccount");
        }
    }

    public class NationSavingAccount : ISavingAccount
    {
        public NationSavingAccount()
        {
            Console.WriteLine("NationSavingAccount");
        }
    }
    public class NationloanAccount : IloanAccount
    {
        public  NationloanAccount()
        {
            Console.WriteLine("NationloanAccount");
        }
    }


    public class CitiUnionFactory : ICreateUnionFactory
    {
        public override IloanAccount CreateloanAccount()
        {
            var obj = new CitiLoanAccount();
            return obj;
        }

        public override ISavingAccount CreateSavingAccount()
        {
            var obj = new CitiSavingAccount();
            return obj;
        }
    }


    public class NationUnionFactory : ICreateUnionFactory
    {
        public override IloanAccount CreateloanAccount()
        {
            var obj = new NationloanAccount();
            return obj;
        }

        public override ISavingAccount CreateSavingAccount()
        {
            var obj = new NationSavingAccount();
            return obj;
        }
    }


    public class CreditUnionFactoryProvider
    {
        public static ICreateUnionFactory GetCreditUnionFactory(string accountNo)
        {
            if (accountNo.Contains("CITI")) { return new CitiUnionFactory(); }
            else
            if (accountNo.Contains("NATIONAL")) { return new NationUnionFactory(); }
            else
                return null;
        }
    }





    //public class CreditUnionFactoryProvider
    //{
    //    public static ICreditUnionFactory GetCreditUnionFactory(string accountNo)
    //    {
    //        if (accountNo.Contains("CITI")) { return new CitiCreditUnionFactory(); }
    //        else
    //        if (accountNo.Contains("NATIONAL")) { return new NationalCreditUnionFactory(); }
    //        else
    //            return null;
    //    }
    //}





    ////////////////////////////////////////////////////////////////////////







    //// Abstract Factory
    //public abstract class ICreditUnionFactory
    //{
    //    public abstract ISavingsAccount CreateSavingsAccount();
    //    public abstract ILoanAccount CreateLoanAccount();
    //}



    ///// ////////////////////////////////////////////////////////////////////////////



    //// Abstract Product A
    //public interface ILoanAccount { }

    //// Abstract Product B
    //public interface ISavingsAccount { }





    ///////////////////////////////////////////////
    /////// ProductA1
    //public class CitiSavingsAccount : ISavingsAccount
    //{
    //    public CitiSavingsAccount()
    //    {
    //        Console.WriteLine("Returned Citi Savings Account");
    //    }
    //}


    //// ProductB1
    //public class CitiLoanAccount : ILoanAccount
    //{
    //    public CitiLoanAccount()
    //    {
    //        Console.WriteLine("Returned Citi Loan Account");
    //    }
    //}


    //// Concrete Factory 1
    //public class CitiCreditUnionFactory : ICreditUnionFactory
    //{
    //    public override ILoanAccount CreateLoanAccount()
    //    {
    //        CitiLoanAccount obj = new CitiLoanAccount();
    //        return obj;
    //    }

    //    public override ISavingsAccount CreateSavingsAccount()
    //    {
    //        CitiSavingsAccount obj = new CitiSavingsAccount();
    //        return obj;
    //    }
    //}


    ///////////////////////////////////////////////////////////////
    ///// // ProductA2
    //public class NationalSavingsAccount : ISavingsAccount
    //{
    //    public NationalSavingsAccount()
    //    {
    //        Console.WriteLine("Returned National Savings Account");
    //    }
    //}


    //// ProductB2
    //public class NationalLoanAccount : ILoanAccount
    //{
    //    public NationalLoanAccount()
    //    {
    //        Console.WriteLine("Returned National Loan Account");
    //    }
    //}


    //// Concrete Factory 2
    //public class NationalCreditUnionFactory : ICreditUnionFactory
    //{
    //    public override ILoanAccount CreateLoanAccount()
    //    {
    //        NationalLoanAccount obj = new NationalLoanAccount();
    //        return obj;
    //    }

    //    public override ISavingsAccount CreateSavingsAccount()
    //    {
    //        NationalSavingsAccount obj = new NationalSavingsAccount();
    //        return obj;
    //    }
    //}

}
