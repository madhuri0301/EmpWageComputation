using System;

namespace EmpWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To The Employee Wage Computation");

            Employee employee = new Employee();
            employee.Attendence("Myntra",20,5,10);
            employee.Attendence("SnapDeal", 10, 5, 20);
            employee.Attendence("Amazon", 10, 5, 30);

        }
    }
}
