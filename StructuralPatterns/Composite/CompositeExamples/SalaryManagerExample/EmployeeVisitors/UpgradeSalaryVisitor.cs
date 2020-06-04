using SalaryManagerExample.Employees;

namespace SalaryManagerExample.EmployeeVisitors
{
    public class UpgradeSalaryVisitor
    {
        public void Visit(Analyst analyst, decimal budget) => analyst.Salary += budget;
        public void Visit(Leader leader, decimal budget)
        {
            var employees = leader.GetEmployees();

            var totalSalary = leader.GetTotalSalary();

            leader.Salary += CalculateBudget(budget, leader.Salary, totalSalary);

            foreach (var employee in employees)
            {
                var employeeBudget = CalculateBudget(budget, employee.GetTotalSalary(), totalSalary);
                employee.UpgradeSalary(employeeBudget);
            }
        }

        private decimal CalculateBudget(decimal totalBudget, decimal employeeSalary, decimal totalSalary)
            => totalBudget * employeeSalary / totalSalary;
    }
}
