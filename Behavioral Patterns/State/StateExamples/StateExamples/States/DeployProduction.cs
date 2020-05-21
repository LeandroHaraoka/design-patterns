using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace StateExamples.States
{
    public class DeployProduction : State
    {
        public DeployProduction(Activity activity) : base(activity, 1000)
        {
        }

        public override void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            Console.WriteLine($"[{_activity._name}] I need leaders to approve the ticket.");
        }

        public override void Execute(bool withErrors = false)
        {
            if (withErrors)
            {
                Console.WriteLine($"[{_activity._name}] Deploy failed.");
                return;
            }

            _timer.Dispose();
            _activity.ChangeState(new Done(_activity));
        }
    }
}
