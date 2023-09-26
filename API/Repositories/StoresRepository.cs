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
    public class StoresRepository : IStoresRepository
    {
          private readonly DataContext _context;
        public StoresRepository(DataContext context)
        {
            _context = context;
        }
         public async Task<Store> GetStores(int id)
        {
            return await _context.Stores
            .SingleOrDefaultAsync(x => x.Id == id);
        }

        public void AddStore(Store store)
        {
            _context.Stores.Add(store);
        }
         public async Task<bool> SaveAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
        
    }
}