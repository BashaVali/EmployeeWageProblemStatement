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
        public const int Working_Day = 20;
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
        //UC-3
        //Assume Wage per Hour is 20
        //Assume ParTime  Hour is 4
        public void PartTimeEmpWage()
        {
            int dailyEmpWage = 0, empHrs = 0;
            int empCheck = random.Next(0, 2);
            if (empCheck == Part_Time_Hour)
                empHrs = Per_hour;
            else
                empHrs = 0;
            dailyEmpWage = Part_Time_Hour * Per_hour;
            Console.WriteLine("Daily Emp Wage Full Day :" + dailyEmpWage);
        }
        //UC-4
        // Using-Switch Case 
        public void SwitchCase()
        {
            int dailyEmpWage = 0;
            int empCheck = random.Next(0, 2);
            Console.WriteLine("Randomly Selected The Full_Day_Hour & Part_Time_Hour ");
            switch (empCheck)
            {

                case 0:
                    dailyEmpWage = Full_Day_Hour * Per_hour;
                    Console.WriteLine("Daily Emp Wage Full Day :" + dailyEmpWage);
                    break;
                case 1:
                    dailyEmpWage = Part_Time_Hour * Per_hour;
                    Console.WriteLine("Daily Emp Wage Part Time :" + dailyEmpWage);
                    break;
                default:
                    Console.WriteLine("Employee is absent");
                    break;
            }
        }
            //UC-5
            //Assume  20 working Days per Month
            //Assume Full day hour is 8
            public void MonthlyEmployeeWage()
            {
                int monthlyEmpWage = 0, empHrs = 0;
                int empCheck = random.Next(0, 2);
                if (empCheck == empHrs)
                    empHrs = Per_hour * Full_Day_Hour;
                else
                    empCheck = random.Next(0, 2);
                monthlyEmpWage = Working_Day * empHrs;
                Console.WriteLine("Daily Emp Wage for a Month :" + monthlyEmpWage);
            }

    }
}


    
