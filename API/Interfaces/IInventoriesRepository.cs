using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Helpers;
using API.DTOs;
using API.Entities;

namespace API.Interfaces
{
    public interface IInventoriesRepository
    {
        void AddInventory(Inventory inventory);
        Task<PagedList<InventoryDto>> GetInventories(InventoryParams inventoryParams);
        Task<Inventory> GetInventories(int storeId);

        Task<bool> SaveAsync();

       
    }
}