using System;
using System.Collections.Generic;
using System.Text;
using TemplateA.Domain;

namespace TemplateA.Application
{
    public interface IDatabaseLayer
    {
        void AddPerson(Person person);
    }
}
