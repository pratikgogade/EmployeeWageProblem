using System;

namespace EmployeeWageProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Problems Statement");
            EmpWage emp = new EmpWage();
            emp.Attendance();
            emp.Wage();
        }
    }
}