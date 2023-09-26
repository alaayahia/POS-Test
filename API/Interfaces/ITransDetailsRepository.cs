using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Helpers;
using API.DTOs;
using API.Entities;

namespace API.Interfaces
{
    public interface ITransDetailsRepository
    {
        void AddTransDetails(TransactionDetail transDetail);
        void UpdateTransDetails(TransactionDetail transDetail);
        Task<PagedList<TransDetailDto>> GetTransDetails(TransDetailParams transDetailParams);
        Task<TransactionDetail> GetTransDetails(int transId);

        Task<bool> SaveAsync();        
    }
}