using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class CheckAttendance
    {
        public static void Attendance()
        {
            Random random = new Random();
            int IsEmployeePresent=random.Next(2);
            if (IsEmployeePresent == 0)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
            

        }
    }
}
