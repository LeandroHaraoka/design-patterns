using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace BidirectionalObserver.Observers
{
    public class Window : INotifyPropertyChanged
    {
        private string _displayName;
        public string DisplayName
        {
            get => _displayName;
            set
            {
                if (value != _displayName)
                {
                    _displayName = value;
                    Console.WriteLine("Changing window display name.");
                    OnPropertyChanged();
                }
            }
        }

        public Window(Database product)
        {
            _displayName = product.ProductName;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
