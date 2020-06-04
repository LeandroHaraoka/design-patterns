using SalaryManagerExample.Employees;
using SalaryManagerExample.EmployeeVisitors;

namespace SalaryManagerExample
{
    public class CompanyHierachyBuilder
    {
        private readonly Leader _root;
        private Leader _currentEmployee;

        public CompanyHierachyBuilder(string ceoName, decimal ceoSalary)
        {
            _root = new Leader(ceoName, ceoSalary, new UpgradeSalaryVisitor(), new PrintDetailsVisitor());
            _currentEmployee = _root;
        }

        public CompanyHierachyBuilder StartLeaderCreation(string leaderName, decimal leaderSalary)
        {
            var newLeader = new Leader(leaderName, leaderSalary, 
                new UpgradeSalaryVisitor(), new PrintDetailsVisitor(), _currentEmployee);

            _currentEmployee.Add(newLeader);
            _currentEmployee = newLeader;
            return this;
        }

        public CompanyHierachyBuilder AddAnalyst(string analystName, decimal analystSalary)
        {
            _currentEmployee.Add(
                new Analyst(analystName, analystSalary, new UpgradeSalaryVisitor(), new PrintDetailsVisitor(), _currentEmployee));

            return this;
        }

        public CompanyHierachyBuilder EndLeaderCreation()
        {
            _currentEmployee = _currentEmployee.Parent;
            return this;
        }

        public Leader Build() => _root;
    }
}
