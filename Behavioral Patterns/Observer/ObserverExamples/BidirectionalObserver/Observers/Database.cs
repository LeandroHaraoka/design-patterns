using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace BidirectionalObserver.Observers
{
    public class Database : INotifyPropertyChanged
    {
        private string _productName;
        public string ProductName { 
            get => _productName;
            set
            {
                if (value != _productName)
                {
                    _productName = value;
                    Console.WriteLine("Changing database product name.");
                    OnPropertyChanged();
                }
            } 
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
