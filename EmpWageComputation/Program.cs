using System;

namespace EmpWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To The Employee Wage Computation");
            Employee myntra = new Employee("Myntra", 20, 5, 10);
            Employee Snapdeal = new Employee("SnapDeal", 10, 5, 20);
            Employee amazon = new Employee("Myntra", 20, 5, 10);
            myntra.Attendence();
            Snapdeal.Attendence();
            amazon.Attendence();
        }

    }
}
