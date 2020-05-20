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
            
            // Move to WIP
            activity.ExecuteCurrentTask(8000);

            // Move to Code Review
            activity.ExecuteCurrentTask(8000);

            // Move to Revision
            activity.ExecuteCurrentTask(8000, true);

            // Move to Deploy Staging
            activity.ExecuteCurrentTask(8000);

            // Move to Business Validation
            activity.ExecuteCurrentTask(8000);

            // Move to Revision
            activity.ExecuteCurrentTask(8000, true);

            // Move to Deploy Staging
            activity.ExecuteCurrentTask(8000);

            // Move to Business Validation
            activity.ExecuteCurrentTask(8000);

            // Move to Deploy Production
            activity.ExecuteCurrentTask(8000);

            // Move to Done
            activity.ExecuteCurrentTask(10000, true);

            // Move to Done
            activity.ExecuteCurrentTask(10000);
        }
    }
}
