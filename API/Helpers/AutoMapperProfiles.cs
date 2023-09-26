using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using API.DTOs;
using API.Extensions;
using AutoMapper;

namespace API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
             CreateMap<Inventory, InventoryDto>();
             CreateMap<Product, ProductDto>();
             CreateMap<Store, StoreDto>();
             CreateMap<Category, CategoryDto>();
             CreateMap<TransactionDetail, TransDetailDto>();
        }
        
    }
}