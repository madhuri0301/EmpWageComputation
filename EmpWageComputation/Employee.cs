﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageComputation
{
    class Employee
    {
        public int Attendence(String company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;

            int totalEmpWage = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            while (totalEmpHrs <= maxHoursPerMonth && totalWorkingDays < numOfWorkingDays)
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
                int empWage = empHour * empRatePerHour;
                totalEmpWage += empWage;
                Console.WriteLine("Day :" + totalWorkingDays + " Employee Wage is :" + empWage);
            }
            Console.WriteLine("Total Employee Wage for Company " + company + " is:" + totalEmpWage);
            return totalEmpWage;
        }
    }
}