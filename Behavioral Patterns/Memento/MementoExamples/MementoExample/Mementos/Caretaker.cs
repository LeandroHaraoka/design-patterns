﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Memento.Mementos
{
    public class Caretaker
    {
        private readonly Originator _originator;
        private readonly List<IMemento> _mementos = new List<IMemento>();

        public Caretaker(Originator originator)
        {
            _originator = originator;
        }

        public void Backup()
        {
            _mementos.Add(_originator.Save());
            CustomConsole.WriteLine(ConsoleColor.Yellow, "Saving the current result to calculator history.\n");
        }

        public void RestorePreviousState()
        {
            if (_mementos.Count == 0)
                return;

            CustomConsole.WriteLine(ConsoleColor.Yellow, "Restoring last saved state.");
        
            var memento = _mementos.Last();
            _mementos.Remove(memento);
            _originator.Restore(memento);
        }
    }
}
