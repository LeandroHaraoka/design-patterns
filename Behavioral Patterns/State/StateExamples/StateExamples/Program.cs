using System;
using System.Threading;

namespace StateExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("State");
            Console.WriteLine("Product Backlog Example\n");

            var activity = new Activity("Implement Authentication");

            // Move to Work In Progress
            activity.ExecuteCurrentTask(2500);

            // Move to Code Review
            activity.ExecuteCurrentTask(2500);

            // Move to Revision (errors at code review result in revision need)
            activity.ExecuteCurrentTask(2500, true);

            // Move to Deploy Staging
            activity.ExecuteCurrentTask(2500);

            // Move to Business Validation
            activity.ExecuteCurrentTask(2500);

            // Move to Revision (errors at business validation result in revision need)
            activity.ExecuteCurrentTask(2500, true);

            // Move to Deploy Staging
            activity.ExecuteCurrentTask(2500);

            // Move to Business Validation
            activity.ExecuteCurrentTask(2500);

            // Move to Deploy Production
            activity.ExecuteCurrentTask(2500);

            // Move to Done (errors at deploy result in no change)
            activity.ExecuteCurrentTask(2500, true);

            // Move to Done
            activity.ExecuteCurrentTask(2500);
        }
    }
}
