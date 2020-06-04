using SalaryManagerExample.Employees;
using System;

namespace SalaryManagerExample.EmployeeVisitors
{
    public class PrintDetailsVisitor
    {
        public void Visit(Analyst analyst, int depth = 0)
            => PrintEmployeeDetails(analyst, depth, ConsoleColor.DarkGreen);

        public void Visit(Leader leader, int depth = 0)
        {
            Console.WriteLine();
            PrintEmployeeDetails(leader, depth, ConsoleColor.Yellow);
            leader.GetEmployees().ForEach(c => c.PrintDetails(depth + 1));
        }

        private void PrintEmployeeDetails(Employee employee, int depth, ConsoleColor color)
        {
            Console.Write(new string(' ', depth * 3));
            Console.ForegroundColor = color;
            Console.Write($"Employee: {employee._name}");
            Console.SetCursorPosition(50, Console.CursorTop);
            Console.WriteLine($"Salary: ${decimal.Round(employee.Salary)}");
        }
    }
}
