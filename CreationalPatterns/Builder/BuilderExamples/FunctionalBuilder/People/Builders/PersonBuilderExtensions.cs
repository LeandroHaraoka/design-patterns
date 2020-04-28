using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalBuilder.People.Builders
{
    public static class PersonBuilderExtensions
    {
        public static PersonBuilder WorkAs(this PersonBuilder personBuilder, string position)
            => personBuilder.Do(p => p.Position = position);
    }
}
