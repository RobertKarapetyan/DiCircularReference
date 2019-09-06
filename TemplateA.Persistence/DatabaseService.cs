using System;
using TemplateA.Application;
using TemplateA.Domain;

namespace TemplateA.Persistence
{
    public class DatabaseLayer : IDatabaseLayer
    {
        public void AddPerson(Person person)
        {
            Console.WriteLine($"Adding: {person.FirstName}{person.LastName}");
        }
    }
}
