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
            int IsEmployeePresent=random.Next(3);
            
            if (IsEmployeePresent == 1)
            {
                Console.WriteLine("Employee is present Full_time");
                empHrs = 8;
            }
            else if(IsEmployeePresent==2)
            {
                Console.WriteLine("Employee is present Part_time");
                empHrs = 4;
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
