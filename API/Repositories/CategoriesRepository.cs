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
    public class CategoriesRepository : ICategoriesRepository
    {
       private readonly DataContext _context;
        public CategoriesRepository(DataContext context)
        {
            _context = context;
        }
         public void AddCategory(Category category)
        {
            _context.Categories.Add(category);
        }

        public async Task<Category> GetCategories(int id)
        {
            return await _context.Categories
            .SingleOrDefaultAsync(x => x.Id == id);
        }
        

        public async Task<bool> SaveAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}