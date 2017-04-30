using Ontsoft.Core.Entities;

namespace Ontsoft.Northwind.Entities.Concrete
{
    public class Language : IEntity
    {
        public string Name { get; set; }
        public string Code { get; set; }
    }
}
