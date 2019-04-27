using Cuong.Data.Entities;
using Cuong.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cuong.Data.IRepositories
{
   public interface IProductCategoryRepository:IRepository<ProductCategory,int>
    {
        List<ProductCategory> GetByAlias(string alias);
    }
}
