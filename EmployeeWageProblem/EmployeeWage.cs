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
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUMBER_OF_WORKING_DAYS = 20;
        public const int MAX_HOURS_IN_MONTH = 100;
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
        //UC6-TotalMonthlyWages
        public void TotalMonthlyWages()
        {
            int day = 0, hours = 0, DailyEmpWage = 0, EmpWage = 0;
            while (day < 20 & hours < 100)
            {
                day++;
                hours += 8;

            }
            EmpWage = day * hours;
            DailyEmpWage = Wage_per_Hour * EmpWage;
            Console.WriteLine("Employee TotalMonthlyWorkingHours Wage :" + DailyEmpWage);

        }
        //UC7-Refactor Class
        public void RefactorEmployeeWageClass()
        {
            //Variables
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            // Computation
            while (totalEmpHrs <= MAX_HOURS_IN_MONTH && totalWorkingDays < NUMBER_OF_WORKING_DAYS)

            {
                totalWorkingDays++;
                Console.WriteLine("Select the option");
                Console.WriteLine("1.Part Time" + "\n" +
                                  "2.Full Time" + "\n" +
                                  "3.Absent" + "\n");

                int options = Convert.ToInt32(Console.ReadLine());
                switch (options)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default: // Assume As Absent
                        empHrs = 0;
                        break;

                }

                totalEmpHrs += empHrs;
                Console.WriteLine("Day#" + totalWorkingDays + " Emp Hrs  :" + empHrs);
            }
            int totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Emp Wage :" + totalEmpWage);
        }


            public void ComputeWage(string company, int wage_per_hour, int max_working_days, int maxHoursPerMonth)
            {
                int empHours = 0;
                int empDailyWage = 0;
                int workingDays = 1;
                int workingHrs = 0;
                int totalWage = 0;
                //Creating a Random Function
                Random random = new Random();

                while (workingDays <= max_working_days && workingHrs <= maxHoursPerMonth)
                {
                    //Calling the next method in Random Class
                    int empInput = random.Next(0, 3);
                    switch (empInput)
                    {
                        case IS_FULL_TIME:
                            // Console.WriteLine("Employee is present for full-time");
                            empHours = 8;
                            break;
                        case IS_PART_TIME:
                            //Console.WriteLine("Employee is present for part-time");
                            empHours = 4;
                            break;
                        default:
                            //Console.WriteLine("Employee is absent");
                            break;

                    }
                    empDailyWage = empHours * wage_per_hour;
                    totalWage += empDailyWage;
                    workingHrs += empHours;
                    if (empInput != 0)
                    {
                        workingDays++;

                    }
                    Console.WriteLine("Company Name:" + company);
                    Console.WriteLine("Working Hours :" + workingHrs);
                    Console.WriteLine("Employee Wage Per day :" + empDailyWage);
                    Console.WriteLine("Working days in a month :" + workingDays);
                    Console.WriteLine("Employee Wage for Total working days :" + totalWage);
                }

            }
        }
}

    



    
