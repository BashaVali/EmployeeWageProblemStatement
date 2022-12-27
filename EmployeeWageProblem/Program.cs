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
                                  "4.SwitchCaseStatement" + "\n " +
                                  "5.MonthWages" + "\n" +
                                  "6.TotalMonthlyWorkingHours" + "\n" +
                                  "7.RefactorEmployeeWageClass" + "\n " +
                                  "8.EmployeeWageMultipleCompanies" + "\n " +
                                  "9.Exit" + "\n");
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
                        EmployeeWageProblem monthWages = new EmployeeWageProblem();
                        monthWages.MonthlyEmployeeWage();
                        break;
                    case 6:
                        EmployeeWageProblem totalMonthlyWorkingHours = new EmployeeWageProblem();
                        totalMonthlyWorkingHours.TotalMonthlyWages();
                        break;
                    case 7:
                        EmployeeWageProblem refactorEmployeeWageClassMethod = new EmployeeWageProblem();
                        refactorEmployeeWageClassMethod.RefactorEmployeeWageClass();
                        break;
                    case 8:
                        Console.WriteLine("Welcome to employee wage computation");
                        EmployeeWageProblem employeeWageMultipleCompany = new EmployeeWageProblem();
                        employeeWageMultipleCompany.ComputeWage("Accenture", 60, 50, 90);
                        EmployeeWageProblem employeeWageMultipleCompany1 = new EmployeeWageProblem();
                        employeeWageMultipleCompany1.ComputeWage("TCS", 65, 55, 95);
                        EmployeeWageProblem employeeWageMultipleCompany2 = new EmployeeWageProblem();
                        employeeWageMultipleCompany2.ComputeWage("CapGemini", 70, 75, 100);
                        break;
                    case 9:
                        flag = false;
                        break;
                }
            }
        }
    }
}