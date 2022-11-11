using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblems
{
    public class FullTimePartTime
    {
        public void Daily()
        {
            const int FULL_DAY_HR = 8, HALF_DAY_HR = 4, IS_FULL_TIME = 0, IS_HALF_TIME = 1,
                 DAILY_WAGE = 20;
            int empHrs = 0, TOTAL_WAGE = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            switch (empCheck)
            {
                case IS_FULL_TIME:
                    empHrs = FULL_DAY_HR;
                    break;
                case IS_HALF_TIME:
                    empHrs = HALF_DAY_HR;
                    break;
                default:
                    empHrs = 0;
                    break;
            }
            TOTAL_WAGE = empHrs * DAILY_WAGE;
            Console.WriteLine("Total Wage of a day is : " + TOTAL_WAGE);
        }
    }
}