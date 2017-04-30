using Ontsoft.Core.Entities;

namespace Ontsoft.Northwind.Entities.Concrete
{
   public class LanguageWord : IEntity
    {
        public int LanguageId { get; set; }
        public string Code { get; set; }
        public string Value { get; set; }
    }
}
