using StatelessExamples;
using System;

namespace StatelessExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("State");
            Console.WriteLine("Stateless Example\n");

            var activity = new Activity("Implement Authentication");

            // Move to TODO
            activity.ExecuteTasksWithSuccess();
            // Move to WIP
            activity.ExecuteTasksWithSuccess();
            // Move to Code Review
            activity.ExecuteTasksWithSuccess();
            // Move to Revision
            activity.ExecuteTasksWithErrors();
            // Move to Deploy Staging
            activity.ExecuteTasksWithSuccess();
            // Move to Business Validation
            activity.ExecuteTasksWithSuccess();
            // Move to Revision
            activity.ExecuteTasksWithErrors();
            // Move to Deploy Staging
            activity.ExecuteTasksWithSuccess();
            // Move to Business Validation
            activity.ExecuteTasksWithSuccess();
            // Move Deploy Production
            activity.ExecuteTasksWithSuccess();
            // Still in Deploy Production
            activity.ExecuteTasksWithErrors();
            // Move to Done
            activity.ExecuteTasksWithSuccess();

            // Print Uml Dot Graph
            //activity.PrintUmlDotGraph();
        }
    }
}
