using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Reflection;

namespace BidirectionalObserver.Observers
{
    public class BidirectionalBinding : IDisposable
    {
        private bool _isDisposed;

        public BidirectionalBinding(
            INotifyPropertyChanged firstObserver,
            Expression<Func<object>> firstExpression,
            INotifyPropertyChanged secondObserver,
            Expression<Func<object>> secondExpression)
        {
            if (firstExpression.Body is MemberExpression firstExprBody &&
                secondExpression.Body is MemberExpression secondExprBody)
                if (firstExprBody.Member is PropertyInfo firstProperty &&
                    secondExprBody.Member is PropertyInfo secondProperty)
                {
                    firstObserver.PropertyChanged += (s, e) =>
                    {
                        if (!_isDisposed)
                            secondProperty.SetValue(secondObserver, firstProperty.GetValue(firstObserver));
                    };
                    
                    secondObserver.PropertyChanged += (s, e) =>
                    {
                        if (!_isDisposed)
                            firstProperty.SetValue(firstObserver, secondProperty.GetValue(secondObserver));
                    };
                }
        }

        public void Dispose()
        {
            Console.WriteLine("\nDisposing bidirectional binding.");
            _isDisposed = true;
        }
    }
}
