using System;

namespace SalaryManagerExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!\n");

            var hierarchy = CompanyHierarchy.Generate();

            Print("\nSee the original employees details.", ConsoleColor.DarkRed);
            hierarchy.PrintDetails();

            hierarchy.UpgradeSalary(2500);
            
            Print("\nA budget of $2500 was shared among all employees.", ConsoleColor.DarkRed);
            Print("It was divided pro rata with salaries (50% of the employee salary).", ConsoleColor.DarkRed);

            hierarchy.PrintDetails();
        }

        private static void Print(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
