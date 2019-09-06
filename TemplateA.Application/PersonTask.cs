using System;
using System.Collections.Generic;
using System.Text;
using TemplateA.Domain;

namespace TemplateA.Application
{
    public class PersonTask : IPersonTask
    {
        private IDatabaseLayer _databaseLayer;

        public PersonTask(IDatabaseLayer databaseLayer)
        {
            _databaseLayer = databaseLayer;
        }
        public void AddPerson(Person person)
        {
            _databaseLayer.AddPerson(person);
        }
    }
}
