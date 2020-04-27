using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderInheritanceExample.People.Builders
{
    public abstract class PersonBuilder
    {
        protected Person _person;

        public PersonBuilder()
        {
            _person = new Person();
        }

        public Person Build()
        {
            return _person;
        }
    }
}
