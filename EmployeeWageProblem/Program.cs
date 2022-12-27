using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the EmployeeWageComputationProblem");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("****** Employee Wage Problem ******");

                Console.WriteLine(" Select the option ");

                Console.WriteLine("1.Attendance" + "\n" +
                                  "2.DailyEmployeeWage" + "\n" +
                                  "3.PartTimeEmployeeWage" + "\n" +
                                  "4.SwitchCaseStatement" + "\n" +
                                  "5.Exit" + "\n");
                int check = Convert.ToInt32(Console.ReadLine());
                switch (check)
                {
                    case 1:
                        EmployeeWageProblem employeeWageProblem = new EmployeeWageProblem();
                        employeeWageProblem.EmployeeAttendence();
                        break;
                    case 2:
                        EmployeeWageProblem employeeWageProblem1 = new EmployeeWageProblem();
                        employeeWageProblem1.DailyEmployeeWage();
                        break;
                    case 3:
                        EmployeeWageProblem partTimeEmployeeWage = new EmployeeWageProblem();
                        partTimeEmployeeWage.PartTimeEmpWage();
                        break;
                    case 4:
                        EmployeeWageProblem switchCaseStatement = new EmployeeWageProblem();
                        switchCaseStatement.SwitchCase();
                        break;
                    case 5:
                        flag = false;
                        break;
                }
            }
        }
    }
}
