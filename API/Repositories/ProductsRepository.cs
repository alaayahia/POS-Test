using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Interfaces;
using API.Data;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Repositories
{
    public class ProductsRepository : IProductsRepository
    {
        private readonly DataContext _context;
        public ProductsRepository(DataContext context)
        {
            _context = context;
        } 

        public void AddProduct(Product product)       
        {
            _context.Products.Add(product);
        }
       
         public async Task<Product> GetProducts(int id)
        {
            return await _context.Products
            .SingleOrDefaultAsync(x => x.Id == id);
        }

        public async Task<bool> SaveAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}