using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;

namespace API.Interfaces
{
    public interface IProductsRepository
    {
        void AddProduct(Product product);
       
        Task<Product> GetProducts(int id);
        Task<bool> SaveAsync();
        
    }
}