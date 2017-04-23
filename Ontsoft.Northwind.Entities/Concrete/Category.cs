using Ontsoft.Core.Entities;

namespace Ontsoft.Northwind.Entities.Concrete
{
    public class Category : IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
