using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class CheckAttendance
    {
        public static int rate_per_hr = 20;
        public static int empHrs = 0;
        public static int empWage = 0;
        
        public static void Attendance()
        {
            Random random = new Random();
            int IsEmployeePresent=random.Next(2);
            
            if (IsEmployeePresent == 0)
            {
                Console.WriteLine("Employee is present");
                empHrs = 8;
            }
            else
            {
                Console.WriteLine("Employee is absent");
                empHrs = 0;
            }

            empWage = empHrs * rate_per_hr;
            Console.WriteLine("The Employee Wage is : " + empWage);

        }
    }
}
