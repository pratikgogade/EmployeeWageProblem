using System;

namespace EmployeeWageProblems
{
    public class Attendance
    {
        const int IS_PRESENT = 0;
        Random random = new Random();
        public void attendance()
        {
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_PRESENT)
                Console.WriteLine("Employee is present");
            else
                Console.WriteLine("Employee is absent");
        }
    }
}