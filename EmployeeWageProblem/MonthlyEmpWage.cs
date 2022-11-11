using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblems
{
    public class MonthlyEmpWage
    {
        const int PER_HR_WAGE = 20, IS_PRESENT = 0, IS_ABSENT = 1, IS_FULL_TIME = 8, IS_HALF_TIME = 4,
            TOTAL_WORKING_DAYS = 20, TOTAL_WORKING_HRS = 100;
        Random random = new Random();
        public void MonthlyWage()
        {
            int empHrs = 0, Total_Wage = 0;
            for (int i = 0; i < TOTAL_WORKING_DAYS && empHrs < 100; i++)
            {
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PRESENT:
                        empHrs += IS_FULL_TIME;
                        break;
                    case IS_HALF_TIME:
                        empHrs += IS_HALF_TIME;
                        break;
                    default:
                        empHrs += 0;
                        break;
                }
            }
            Total_Wage = empHrs * PER_HR_WAGE;
            Console.WriteLine("Monthly Employer Wage will be : " + Total_Wage);
        }
    }
}