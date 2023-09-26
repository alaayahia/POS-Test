using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;

namespace API.Interfaces
{
    public interface IStoresRepository
    {
           Task<Store> GetStores(int id);

           void AddStore(Store store);
            Task<bool> SaveAsync();
    }
}