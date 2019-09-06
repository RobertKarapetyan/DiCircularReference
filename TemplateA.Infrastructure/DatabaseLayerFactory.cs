using System;
using TemplateA.Application;
using TemplateA.Persistence;

namespace TemplateA.Infrastructure
{
    public class DatabaseLayerFactory
    {
        public static IDatabaseLayer Default()
        {
            var result = new DatabaseLayer();
            return result;
        }
    }
}
