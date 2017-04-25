using Ontsoft.Core.DataAccess;
using Ontsoft.Northwind.Entities.Concrete;

namespace Ontsoft.Northwind.DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        //Custom repository operations. 
    }
}
