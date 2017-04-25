using System;
using System.Collections.Generic;
using System.Text;
using Ontsoft.Core.DataAccess.EntityFramework;
using Ontsoft.Northwind.DataAccess.Abstract;
using Ontsoft.Northwind.Entities.Concrete;

namespace Ontsoft.Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
    }
}
