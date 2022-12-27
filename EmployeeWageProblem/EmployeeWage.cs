using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationProblem
{
    public class EmployeeWageProblem
    {
        // class variable // UC-1
        public const int Per_hour = 20;
        public const int Full_Day_Hour = 8;
        public const int Part_Time_Hour = 4;
        public const int Wage_per_Hour = 20;
        Random random = new Random();
        public void EmployeeAttendence()
        {
            Random random = new Random();
            int num = random.Next(2);

            if (num == 0)
            {
                Console.WriteLine("Employee is absent");
            }
            else
            {
                Console.WriteLine("Employee is present");
            }
        }
        //UC-2
        //Assume Wage per Hour is 20
        //Assume Full day hour is 8
        public void DailyEmployeeWage()
        {
            int dailyEmpWage = 0, empHrs = 0;
            int empCheck = random.Next(0, 2);
            if (empCheck == Full_Day_Hour)
                empHrs = Per_hour;
            else
                empHrs = 0;
            dailyEmpWage = Full_Day_Hour * Per_hour;
            Console.WriteLine("Daily Emp Wage Full Day :" + dailyEmpWage);
        }
    }
}
    
