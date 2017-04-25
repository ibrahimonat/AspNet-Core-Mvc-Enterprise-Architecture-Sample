using Ontsoft.Core.DataAccess.EntityFramework;
using Ontsoft.Northwind.DataAccess.Abstract;
using Ontsoft.Northwind.Entities.Concrete;

namespace Ontsoft.Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, NorthwindContext>, ICategoryDal
    {
    }
}