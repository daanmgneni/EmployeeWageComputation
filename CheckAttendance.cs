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
        public static int monthlyWage=0;
        public static int totalHrs = 0;

  //Using wagesUsingSwitchCase function to find wages according to working hours
        public static void wagesUsingSwitchCase()
        {
 //for calculating wages for 20 days
            for (int i = 0; i < 20; i++)
            {

                Random random = new Random();
                int IsEmployeePresent = random.Next(3);

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
                Console.WriteLine($"The Employee Wage for day {i+1} is :{empWage}\n ");
                totalHrs += empHrs;
                if (totalHrs >= 100) { break; }
                monthlyWage += empWage;


            }

            Console.WriteLine("The total working hours for the month is : " + totalHrs);
            Console.WriteLine("\nThe Employee Wage for Total Month of 20 days is : " +monthlyWage);

        }
    }
}
