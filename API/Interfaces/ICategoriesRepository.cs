using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;


namespace API.Interfaces
{
    public interface ICategoriesRepository
    {
         void AddCategory(Category category);
         Task<Category> GetCategories(int id);

          Task<bool> SaveAsync();
        
    }
}