using Ontsoft.Core.DataAccess;
using Ontsoft.Northwind.Entities.Concrete;

namespace Ontsoft.Northwind.DataAccess.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
        //Custom repository operations. 
    }
}