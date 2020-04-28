using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunctionalBuilder.People.Builders
{
    public abstract class FunctionalBuilder<TBuilder>
        where TBuilder : FunctionalBuilder<TBuilder>
    {
        private readonly List<Func<Person, Person>> _builderFunctions =
            new List<Func<Person, Person>>();

        public TBuilder Do(Action<Person> action)
            => AddAction(action);

        public Person Build()
            => _builderFunctions.Aggregate(new Person(), (entity, action) => action(entity));

        private TBuilder AddAction(Action<Person> action)
        {
            _builderFunctions.Add(builderFunction);
            return (TBuilder) this;

            Person builderFunction(Person p)
            {
                action(p);
                return p;
            }
        }
    }
}
