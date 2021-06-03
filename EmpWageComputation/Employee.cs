using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageComputation
{
    class Employee
    {
        const int IS_FULL_TIME = 1;
        const int IS_PART_TIME = 2;
        const int EMP_RATE_PER_HOUR = 20;
        const int NO_WORKING_DAYS = 20;
        const int MAX_HRS_IN_MONTH = 100;

        int totalEmpWage = 0;
        int totalEmpHrs = 0;
        int totalWorkingDays = 0;
        public void Attendence()
        {
            while (totalEmpHrs <= MAX_HRS_IN_MONTH && totalWorkingDays < NO_WORKING_DAYS)
            {
                int empHour = 0;
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case 1:
                        Console.WriteLine("Employee Is Present");
                        empHour = 8;
                        break;
                    case 2:

                        Console.WriteLine("Employee Is Working Part Time");
                        empHour = 4;
                        break;

                    default:
                        Console.WriteLine("Employee Is Absent");
                        empHour = 0;
                        break;
                }
                totalEmpHrs += empHour;
                int empWage = empHour * EMP_RATE_PER_HOUR;
                totalEmpWage += empWage;
                Console.WriteLine("Employee Wage is :" + empWage);
            }
            Console.WriteLine("Total Employee Wage is :" + totalEmpWage);
        }
    }
}