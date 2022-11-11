using System;

namespace EmployeeWageProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Problems Statement");
            Console.WriteLine("Enter your choice what you want to know?"
                + "\n" + "1. Attendance" + "\n" + "2. Daily Wage" + "\n" + "3. Monthly Wage" + "\n" + "4. Exit");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Attendance attend = new Attendance();
                    attend.attendance();
                    break;
                case 2:
                    FullTimePartTime wage = new FullTimePartTime();
                    wage.Daily();
                    break;
                case 3:
                    MonthlyEmpWage emp = new MonthlyEmpWage();
                    emp.MonthlyWage();
                    break;
                default:
                    Console.WriteLine("Try Again");
                    break;
            }
        }
    }
}