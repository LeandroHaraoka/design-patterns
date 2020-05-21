using System;
using System.Timers;

namespace StateExamples.States
{
    public abstract class State
    {
        protected readonly Activity _activity;
        protected static Timer _timer;

        public State(Activity activity, double alertInterval)
        {
            _activity = activity;
            ConfigureAlertTimer(alertInterval);
        }

        public abstract void OnTimedEvent(object source, ElapsedEventArgs e);

        private void ConfigureAlertTimer(double alertInterval)
        {
            if (alertInterval <= 0)
            {
                _timer = default;
                return;
            }

            _timer = new Timer(alertInterval)
            {
                AutoReset = true,
            };

            _timer.Elapsed += OnTimedEvent;
        }

        public void InitializeAlertTimer() => _timer?.Start();

        public abstract void Execute(bool withErrors = false);
    }









 






}
