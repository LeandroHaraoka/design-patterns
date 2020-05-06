using System;
using System.Collections.Generic;
using System.Text;

namespace HomeEventsExample.Events
{
    public class Person
    {
        public event EventHandler LeftHome;
        public event EventHandler ArrivedAtHome;
        public event EventHandler LeftWork;

        public void GoToWork()
        {
            Console.WriteLine("\nPerson is going to work.");
            LeftHome?.Invoke(this, EventArgs.Empty);
        }

        public void LeaveWork()
        {
            Console.WriteLine("\nPerson is coming back to home.");
            LeftWork?.Invoke(this, EventArgs.Empty);
        }

        public void ArriveAtHome()
        {
            Console.WriteLine("\nPerson arrived at home.");
            ArrivedAtHome?.Invoke(this, EventArgs.Empty);
        }
    }
}
