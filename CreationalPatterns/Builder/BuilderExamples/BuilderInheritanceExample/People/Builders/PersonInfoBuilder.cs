using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderInheritanceExample.People.Builders
{
    public class PersonInfoBuilder<TBuilder> : PersonBuilder
        where TBuilder : PersonInfoBuilder<TBuilder>
    {
        public TBuilder WithName(string name)
        {
            _person.Name = name;
            return (TBuilder) this;
        }

        public TBuilder WithAge(int age)
        {
            _person.Age = age;
            return (TBuilder) this;
        }
    }
}
