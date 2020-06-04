using SalaryManagerExample.Employees;

namespace SalaryManagerExample
{
    public static class CompanyHierarchy
    {
        public static Employee Generate()
        {
            var hierarchy = new CompanyHierachyBuilder("CEO", 900);
            hierarchy
                // Tech Team
                .StartLeaderCreation("Tech Executive", 500)
                    .StartLeaderCreation("Development Leader", 300)
                        .AddAnalyst("Developer one", 200)
                        .AddAnalyst("Developer two", 150)
                    .EndLeaderCreation()
                    .StartLeaderCreation("Infrastrucure Leader", 300)
                        .AddAnalyst("Sre", 150)
                    .EndLeaderCreation()
                .EndLeaderCreation()
                // Financial Team
                .StartLeaderCreation("Financial Executive", 500)
                    .StartLeaderCreation("Treasury Leader", 300)
                        .AddAnalyst("Treasury Analyst one", 250)
                        .AddAnalyst("Treasury Analyst two", 100)
                    .EndLeaderCreation()
                    .StartLeaderCreation("Accounting Leader", 300)
                        .AddAnalyst("Accounting Analyst one", 200)
                        .AddAnalyst("Accounting Analyst two", 100)
                    .EndLeaderCreation()
                .EndLeaderCreation()
                // Sales Team
                .StartLeaderCreation("Sales Executive", 500)
                    .AddAnalyst("Sales Analyst", 250)
                .EndLeaderCreation();
            
            return hierarchy.Build();

        }
    }
}
