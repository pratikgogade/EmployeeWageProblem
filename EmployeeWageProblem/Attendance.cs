using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblems
{
    public class EmpWage
    {
        Random random = new Random();
        public void Attendance()
        {
            int check = random.Next(0, 2);
            if (check == 0)
                Console.WriteLine("Employee is Present.");
            else
                Console.WriteLine("Employee is absent");
        }
    }
}