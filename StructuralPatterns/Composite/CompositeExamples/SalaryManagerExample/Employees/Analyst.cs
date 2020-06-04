using SalaryManagerExample.EmployeeVisitors;
using System;

namespace SalaryManagerExample.Employees
{
    public class Analyst : Employee
    {
        public Analyst(string name, decimal salary, UpgradeSalaryVisitor upgradeSalaryVisitor, 
            PrintDetailsVisitor printDetailsVisitor, Leader parent = default) 
            : base(name, salary, upgradeSalaryVisitor, printDetailsVisitor, parent)
        {
        }

        public override decimal GetTotalSalary() => Salary;

        public override void PrintDetails(int depth = 0)
            => _printDetailsVisitor.Visit(this, depth);

        public override void UpgradeSalary(decimal budget)
            => _upgradeSalaryVisitor.Visit(this, budget);
    }
}
