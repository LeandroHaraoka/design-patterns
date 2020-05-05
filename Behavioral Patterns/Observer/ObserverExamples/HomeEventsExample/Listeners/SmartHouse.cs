using HomeEventsExample.Events;
using System;

namespace HomeEventsExample.Listeners
{
    public class SmartHouse
    {
        private readonly Device _windowsControl = new Device();
        private readonly Device _airConditioner = new Device();
        private readonly Device _lights = new Device();

        // Here should exist abstractions to respect Dependency Inversion Principle
        public SmartHouse(Person person)
        {
            person.LeftHome += (s, e) => { DisableAllDevices(s, e); };
            person.LeftWork += (s, e) => { EnableAirConditioner(s, e); };
            person.ArrivedAtHome += (s, e) => { TurnLightsOn(s, e); };
        }

        public void DisableAllDevices(object sender, EventArgs e)
        {
            Console.WriteLine("Closing windows, turning off lights and air conditioner.");
            _windowsControl.IsEnabled = false;
            _airConditioner.IsEnabled = false;
            _lights.IsEnabled = false;
        }

        public void EnableAirConditioner(object sender, EventArgs e)
        {
            Console.WriteLine("Turning on the air conditioner.");
            _airConditioner.IsEnabled = true;
        }

        public void TurnLightsOn(object sender, EventArgs e)
        {
            Console.WriteLine("Turning lights on.");
            _lights.IsEnabled = true;
        }
    }
}