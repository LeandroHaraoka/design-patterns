using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace StateExamples.States
{
    public class BusinessValidation : State
    {
        public BusinessValidation(Activity activity) : base(activity, 3000)
        {
        }

        public override void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            Console.WriteLine($"[{_activity._name}] Let's check business rules?");
        }

        public override void Execute(bool withErrors = false)
        {
            _timer.Dispose();

            if (withErrors)
            {
                _activity.ChangeState(new Revision(_activity));
                return;
            }

            _activity.ChangeState(new DeployProduction(_activity));
        }

    }
}
