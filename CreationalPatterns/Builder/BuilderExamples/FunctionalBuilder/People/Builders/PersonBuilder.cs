using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalBuilder.People.Builders
{
    public sealed class PersonBuilder
        : FunctionalBuilder<PersonBuilder>
    {
        public PersonBuilder Called(string name)
            => Do(p => p.Name = name);

        public PersonBuilder WithAge(int age)
            => Do(p => p.Age = age);
    }
}
