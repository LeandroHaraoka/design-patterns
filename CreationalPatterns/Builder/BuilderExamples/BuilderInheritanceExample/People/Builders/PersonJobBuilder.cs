using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderInheritanceExample.People.Builders
{
    public class PersonJobBuilder<TBuilder> : PersonInfoBuilder<TBuilder>
        where TBuilder : PersonJobBuilder<TBuilder>
    {
        public TBuilder WorkAs(string position)
        {
            _person.Position = position;
            return (TBuilder) this;
        }
    }
}
