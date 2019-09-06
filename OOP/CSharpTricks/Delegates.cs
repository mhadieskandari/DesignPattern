using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace OOP.CSharpTricks
{
    public delegate void Display(string sMsg);
    public class ExampleDelegates
    {
        public void test()
        {
            Display del = new Display(ShowMessage);
            del("This is an example for delegate");
        }

        private void ShowMessage(string strMessage)
        {
            Console.WriteLine(strMessage);
        }

    }


    public delegate void SalaryIncreaseEligibility(Employee emp);
    public class Employee
    {
        public int EmployeeId { get; set; }

        public string Name { get; set; }

        public int Experience { get; set; }

        public double Salary { get; set; }

        public byte Level { set; get; }

        public void IncreaseSalary(List<Employee> Employees, SalaryIncreaseEligibility del)
        {
            foreach (Employee emp in Employees)
            {
                del(emp);

            }
        }
    }

    public class EmployeeTest
    {

        public void test()
        {
            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee() { EmployeeId = 100, Name = "Mark", Salary = 2000, Experience = 3, Level = 0 });
            empList.Add(new Employee() { EmployeeId = 101, Name = "John", Salary = 15000, Experience = 8, Level = 3 });
            empList.Add(new Employee() { EmployeeId = 102, Name = "David", Salary = 4000, Experience = 4, Level = 0 });
            empList.Add(new Employee() { EmployeeId = 103, Name = "Bob", Salary = 50000, Experience = 14, Level = 10 });
            empList.Add(new Employee() { EmployeeId = 104, Name = "Alex", Salary = 9000, Experience = 6, Level = 1 });

            SalaryIncreaseEligibility del = new SalaryIncreaseEligibility(SalaryEligibility);
            del += new SalaryIncreaseEligibility(SalaryEligibility1);
            del += new SalaryIncreaseEligibility(SetLevel);
            Employee objEmp = new Employee();
            objEmp.IncreaseSalary(empList, del);

            foreach (var emp in empList)
            {
                Console.WriteLine("empId: "+emp.EmployeeId +" , Salary: "+emp.Salary+" , Level: "+emp.Level);
            }
        }

        private void SalaryEligibility(Employee emp)
        {
            if (emp.Salary > 10000)
            {
                emp.Salary += emp.Salary * 0.3;
            }

        }
        private void SalaryEligibility1(Employee emp)
        {
            if (emp.Salary <= 10000)
            {
                emp.Salary += emp.Salary * 0.3 + 1000;
            }
        }

        private void SetLevel(Employee emp)
        {
            emp.Level = (byte)(emp.Salary /5000);
        }

    }
}
