using OOP.CSharpTricks;
using OOP.DesignPatterns.Beahavioral;
using OOP.DesignPatterns.Structural;
using System;
using System.Collections.Generic;
using System.Data;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {



            #region Generic InterFaces

            //var inv = new Invoice
            //{
            //    Id = 1,
            //    FirstName = "hadi",
            //    LastName = "eskandari"
            //};
            //var genericCalss = new listGeneric<Invoice>(inv);
            //foreach(var p in genericCalss.GetListProperties())
            //{
            //    Console.WriteLine(p);
            //}

            #endregion

            #region Generic Class
            //GenericClass<int> c1 = new GenericClass<int>(10);
            //c1.GetTypeName();

            //GenericClass<string> c2 = new GenericClass<string>("a");
            //c2.GetTypeName();
            //GenericClass<decimal> c3 = new GenericClass<decimal>(10);
            //c3.GetTypeName();
            //GenericClass<double> c4 = new GenericClass<double>(10);
            //c4.GetTypeName();

            //var list = new DataSet();
            //list.Tables.Add();
            //GenericClassIDisposable<DataSet> lst = new GenericClassIDisposable<DataSet>(list);
            //lst.GetTypeName();
            #endregion

            #region ref return and local in C# 7.0

            //var refClass = new RefReturnAndLocal();
            //int a = 10;
            //int b = 20;
            //int val = refClass.GetLargest(a, b);
            //val += 20;
            //Console.WriteLine($"a is {a} and b is {b} and val is {val}");
            //ref int refval = ref refClass.GetLargest(ref a, ref b);
            //refval += 20;
            //Console.WriteLine($"ref===>>> a is {a} and b is {b} and val is {refval}");

            //Console.WriteLine($"b equal val1 ==>{b.Equals(refval) } ");


            //unsafe
            //{
            //    IntPtr a_memory_address = (IntPtr)(&a);
            //    IntPtr b_memory_address = (IntPtr)(&b);
            //    IntPtr val_memory_address = (IntPtr)(&val);

            //    fixed(int*  refval_var =&refval)
            //    {
            //        IntPtr refval_memory_address = (IntPtr)(refval_var);
            //        Console.WriteLine($"memory address of a equal {a_memory_address}");
            //        Console.WriteLine($"memory address of b equal {b_memory_address}");
            //        Console.WriteLine($"memory address of val equal {val_memory_address}");
            //        Console.WriteLine($"memory address of refval equal {refval_memory_address}");

            //    }

            //}

            #endregion

            #region new spilited int type with _ in C# 7.0
            //var a = 123123;
            //var b= 123_123;

            //Console.WriteLine($"a is {a} and  is {b}");
            #endregion

            #region Local Function in C# 7.0
            //var lf = new LocalFunction();
            //Console.WriteLine(lf.GetAverage(1, 2, 3));

            #endregion

            #region Deconstruct in C# 7
            //Person p = new Person
            //{
            //    FirstName = "Hadi",
            //    LastName = "Eskandari",
            //    BirthDate = new DateTime(1989, 2, 11)
            //};

            //var (firstname, lastname) = p;

            //Console.WriteLine($"firstname is {firstname } and lastname is {lastname}");

            #endregion

            #region Delegate
            //var exampleDelegates = new ExampleDelegates();
            //exampleDelegates.test();

            //var employeeTest = new EmployeeTest();
            //employeeTest.test();
            #endregion

            #region Observer Pattern
            //ICeleberity GCloony = new GCloony("gc tweet 1");
            //ICeleberity TSweeft = new TSweft("ts tweet 1");

            //IFan fan1 = new Fan();
            //IFan fan2 = new Fan();

            //GCloony.AddFollower(fan1);
            //GCloony.AddFollower(fan2);

            //TSweeft.AddFollower(fan1);
            //TSweeft.AddFollower(fan2);

            //GCloony.Tweet="gc tweet2";
            //TSweeft.Tweet = "ts tweet2";


            #endregion

            #region Iterator Pattern

            //INewsPaper NYNews = new NYPaper();
            //INewsPaper LANews = new LAPaper();

            //IIterator NYIterator = NYNews.CreateIterator();
            //IIterator LAIterator = LANews.CreateIterator();

            //PrintReporter(NYIterator);
            //PrintReporter(LAIterator);

            #endregion

            #region Structrual

            ////Decorator Pattern
            //Car compactCar = new CompactCar();
            //compactCar = new LeatherSeats(compactCar);
            //compactCar = new Navigation(compactCar);
            //compactCar = new SunRoof(compactCar);
            //Console.WriteLine(compactCar.GetCarPrice());
            //Console.WriteLine(compactCar.GetDescripton());

            //Car fullsizeCar = new FullSizeCar();
            //fullsizeCar = new LeatherSeats(fullsizeCar);
            //fullsizeCar = new Navigation(fullsizeCar);
            //fullsizeCar = new SunRoof(fullsizeCar);
            //Console.WriteLine(fullsizeCar.GetCarPrice());
            //Console.WriteLine(fullsizeCar.GetDescripton());

            #endregion

            #region Creational


            ////Singleton Pattern
            //Policy p = Policy.Instance;
            //Console.WriteLine(p.GetInsured());

            ////FactoryMethodExample
            //var f = new SavingAccountFactory() as ICreateUnionFactory;
            //var citiBalance = f.GetSavingAccount(typeof(CitiSavingAccount));
            //var nationBalance = f.GetSavingAccount(typeof(NationalSavingAccount));
            //Console.WriteLine("CitiSavingAccount : "+citiBalance.Balance);
            //Console.WriteLine("NationalSavingAccount : " +nationBalance.Balance );
            //Console.ReadLine();


            ///Abstract factory
            //List<string> accntNumbers = new List<string> {
            //                            "CITI-456",
            //                            "NATIONAL-987",
            //                            "CHASE-222" };
            //for (int i = 0; i < accntNumbers.Count; i++)
            //{
            //    ICreditUnionFactory anAbstractFactory = CreditUnionFactoryProvider.GetCreditUnionFactory(accntNumbers[i]);
            //    if (anAbstractFactory == null)
            //    {
            //        Console.WriteLine("Sorry. This credit union w/ account number" +
            //                          " ' {0} ' is invalid.", (accntNumbers[i]));
            //    }
            //    else
            //    {
            //        ILoanAccount loan = anAbstractFactory.CreateLoanAccount();
            //        ISavingsAccount savings = anAbstractFactory.CreateSavingsAccount();
            //    }
            //}

            //List<string> accntNumbers = new List<string> {
            //                            "CITI-456",
            //                            "NATIONAL-987",
            //                            "CHASE-222" };
            //for (int i = 0; i < accntNumbers.Count; i++)
            //{
            //    ICreateUnionFactory anAbstractFactory = CreditUnionFactoryProvider.GetCreditUnionFactory(accntNumbers[i]);
            //    if (anAbstractFactory == null)
            //    {
            //        Console.WriteLine("Sorry. This credit union w/ account number" +
            //                          " ' {0} ' is invalid.", (accntNumbers[i]));
            //    }
            //    else
            //    {
            //        IloanAccount loan = anAbstractFactory.CreateloanAccount();
            //        ISavingAccount savings = anAbstractFactory.CreateSavingAccount();
            //    }
            //}

            #endregion

            Console.ReadLine();
        }

        static void PrintReporter(IIterator iterator)
        {
            iterator.First();
            while (iterator.IsDone())
            {
                Console.WriteLine(iterator.Next());
            }
        }

    }
}
