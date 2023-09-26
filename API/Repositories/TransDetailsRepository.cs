using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Interfaces;
using API.Data;
using API.Entities;
using API.Helpers;
using API.DTOs;
using Microsoft.EntityFrameworkCore;

namespace API.Repositories
{
    public class TransDetailsRepository : ITransDetailsRepository
    {
        private readonly DataContext _context;
        TransDetailsRepository(DataContext context)
        {
            _context = context;
        }


       public async void AddTransDetails(TransactionDetail transDetail)
       {
        _context.TransactionDetails.Add(transDetail);
       }
         public async void UpdateTransDetails(TransactionDetail transDetail)
         {
             _context.Entry(transDetail).State = EntityState.Modified;
         }
        public async Task<PagedList<TransDetailDto>> GetTransDetails(TransDetailParams transDetailParams)
        {
             var query = _context.TransactionDetails
                    .OrderByDescending(m => m.TransactionId)
                    .AsQueryable();
            
            var transDetail = query.ProjectTo<TransDetailDto>(_mapper.ConfigurationProvider);

            return await PagedList<TransDetailDto>.CreateAsync(transDetail, transDetailParams.PageNumber, transDetailParams.PagaSize);
        }
        public async Task<TransactionDetail> GetTransDetails(int transId)
        {
             return await _context.TransactionDetails.FindAsync(transId);
        }

        public async Task<bool> SaveAsync()
        {
             return await _context.SaveChangesAsync() > 0;
        }
        
    }
}