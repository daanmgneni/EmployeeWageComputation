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
        
        public static void wagesUsingSwitchCase()
        {
            Random random = new Random();
            int IsEmployeePresent=random.Next(3);
            
            switch (IsEmployeePresent)
            {
                case 0:
                    {
                        empHrs = 0;
                        Console.WriteLine("Employee is absent");
                        break;
                    }

                case 1:
                    {
                        empHrs = 8;
                        Console.WriteLine("Employee is present Full Time");
                        break;
                    }
                case 2:
                    {
                        empHrs = 4;
                        Console.WriteLine("Employee is present Part Time");
                        break;
                    }
            }

            empWage = empHrs * rate_per_hr;
            Console.WriteLine("The Employee Wage is : " + empWage);

        }
    }
}
