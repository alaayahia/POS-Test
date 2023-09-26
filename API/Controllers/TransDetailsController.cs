using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using API.Interfaces;
using API.Extensions;
using API.Entities;
using API.DTOs;
using API.Helpers;

namespace API.Controllers
{
    
    public class TransDetailsController : BaseApiController
    {
      private readonly IProductsRepository _productsRepository;
      private readonly IStoresRepository _storesRepository;
      private readonly ITransDetailsRepository _transDetailsRepository;

      public TransDetailsController(IProductsRepository productsRepository, 
      IStoresRepository storesRepository, ITransDetailsRepository transDetailsRepository)
      {
        _productsRepository = productsRepository;
        _storesRepository = storesRepository;
        _transDetailsRepository = transDetailsRepository;

      }

      [HttpGet]
       public async Task<ActionResult<IEnumerable<TransDetailDto>>> GetTransDetails([FromQuery] TransDetailParams transDetailParams)
        {
             
            var transDetail = await _transDetailsRepository.GetTransDetails(transDetailParams.transactionId);
            Response.AddPaginationHeader(transDetail.CurrentPage,transDetail.PageSize,transDetail.TotalCount,transDetail.TotalPages);
            return transDetail;

        }

        [HttpPut]
       public async Task<ActionResult> UpdateTransDetails(TransDetailDto transDetailDto)
       {
         
        var transactionDetail = await _userRepository.GetTransDetails(transDetailDto.TransId);
        _mapper.Map(TransDetailDto, transactionDetail);
        _transDetailsRepository.Update(transactionDetail);
        if (await _transDetailsRepository.SaveAllAsync()) return NoContent();
        return BadRequest("Faild to update user");

       }

       [HttpPost]
       public async Task<ActionResult<TransactionDetail>> AddTransDetail(TransDetailDto transDetailDto)
       {
         var product = await _productsRepository.GetProducts(inventoryDto.ProductId);
        var store = await _storesRepository.GetStores(inventoryDto.StoreId);
        var transDetail = new TransactionDetail
        {
            Product = product,
            Store = store,
            QtyIn = transDetailDto.QtyIn,
            QtyOut = transDetailDto.QtyOut,
            CostPrice = transDetailDto.CostPrice,
            SellPrice = transDetailDto.SellPrice,
            TotalCost = transDetailDto.TotalCost,
            TotalSell = transDetailDto.TotalSell,
            TotalDiscount = transDetailDto.TotalDiscount,  
            PaymentStatus = transDetailDto.PaymentStatus,  


        };


         _transDetailsRepository.AddInventory(inventory);
        if(await _transDetailsRepository.SaveAsync()) return Ok();
        return BadRequest("Faild to add inventory");
       }

       
    }
}