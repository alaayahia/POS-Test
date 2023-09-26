using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using API.Interfaces;
using API.Data;
using API.Helpers;
using API.DTOs;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using AutoMapper.QueryableExtensions;

namespace API.Repositories
{
    public class InventoriesRepository : IInventoriesRepository
    {
        private readonly DataContext _context;
        public InventoriesRepository(DataContext context)
        {
            _context = context;
        }
        public void AddInventory(Inventory inventory)
        {
            _context.Inventories.Add(inventory);
        }
        public async Task<bool> SaveAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }


        public async Task<PagedList<InventoryDto>> GetInventories(InventoryParams inventoryParams)
        {
            var query = _context.Inventories
                    .OrderByDescending(m => m.ProductId)
                    .AsQueryable();
            
            var inventory = query.ProjectTo<InventoryDto>(_mapper.ConfigurationProvider);

            return await PagedList<InventoryDto>.CreateAsync(inventory, inventoryParams.PageNumber, inventoryParams.PagaSize);
        }
        public async Task<Inventory> GetInventories(int storeId)
        {

        }

        
    }
}