using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageComputation
{
    class Employee
    {
        int IS_FULL_TIME = 1;
        int EMP_RATE_PER_HOUR = 20;

        int empHour = 0;
        int empWage = 0;
        public void Attendence()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee Is Present");
                empHour = 8;
            }
            else
            {
                Console.WriteLine("Employee Is Absent");
                empHour = 0;
            }
            empWage = empHour * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee Wage is :" + empWage);
        }
    }
}
