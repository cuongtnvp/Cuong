using AutoMapper;
using Cuong.Application.ViewModels.Product;
using Cuong.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cuong.Application.AutoMapper
{
   public class DomainToViewModelMappingProfile:Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<ProductCategory, ProductCategoryViewModel>();
        }
    }
}
