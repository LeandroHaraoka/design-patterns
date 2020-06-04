using SalaryManagerExample.EmployeeVisitors;

namespace SalaryManagerExample.Employees
{
    public abstract class Employee
    {
        public Leader Parent { get; set; }
        public decimal Salary { get; set; }
        
        public readonly string _name;

        protected readonly UpgradeSalaryVisitor _upgradeSalaryVisitor;
        protected readonly PrintDetailsVisitor _printDetailsVisitor;

        public Employee(string name, decimal salary, UpgradeSalaryVisitor upgradeSalaryVisitor, 
            PrintDetailsVisitor printDetailsVisitor, Leader parent)
        {
            _name = name;
            Salary = salary;
            _upgradeSalaryVisitor = upgradeSalaryVisitor;
            _printDetailsVisitor = printDetailsVisitor;
            Parent = parent;
        }

        public abstract decimal GetTotalSalary();
        public abstract void UpgradeSalary(decimal budget);
        public abstract void PrintDetails(int depth = 0);
    }
}
