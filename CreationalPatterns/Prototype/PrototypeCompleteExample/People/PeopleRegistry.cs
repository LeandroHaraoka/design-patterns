using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeCompleteExample.People
{
    public class PeopleRegistry
    {
        private readonly Dictionary<string, Person> _registry = new Dictionary<string, Person>();

        public PeopleRegistry() => LoadPeopleRegistry();

        public Person CreatePerson(string registryName)
        {
            return _registry.GetValueOrDefault(registryName);
        }

        private void LoadPeopleRegistry()
        {
            var malePerson = new Person()
            {
                Name = "Male Name",
                Age = 99,
                Document = new Document(DocumentType.CPF, "xxx.xxx.xxx-xx")
            };

            var femalePerson = new Person()
            {
                Name = "Female Name",
                Age = 99,
                Document = new Document(DocumentType.CPF, "xxx.xxx.xxx-xx")
            };

            _registry.Add("male", malePerson);
            _registry.Add("female", femalePerson);
        }
    }
}
