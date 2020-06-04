using SalaryManagerExample.EmployeeVisitors;
using System.Collections.Generic;
using System.Linq;

namespace SalaryManagerExample.Employees
{
    public class Leader : Employee
    {
        protected readonly List<Employee> _employees = new List<Employee>();

        public Leader(string name, decimal salary, UpgradeSalaryVisitor upgradeSalaryVisitor,
            PrintDetailsVisitor printDetailsVisitor, Leader parent = default)
            : base(name, salary, upgradeSalaryVisitor, printDetailsVisitor, parent)
        {
        }

        public override void UpgradeSalary(decimal budget)
            => _upgradeSalaryVisitor.Visit(this, budget);

        public override void PrintDetails(int depth = 0)
            => _printDetailsVisitor.Visit(this, depth);

        public override decimal GetTotalSalary() 
            => Salary + _employees.Sum(e => e.GetTotalSalary());

        public List<Employee> GetEmployees() => _employees;

        public void Add(Employee employee)
        {
            _employees.Add(employee);
            employee.Parent = this;
        }

        public void Remove(Employee employee) => _employees.Remove(employee);
    }
}
