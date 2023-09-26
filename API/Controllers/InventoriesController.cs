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

namespace API.Controllers
{
    
    public class InventoriesController : BaseApiController
    {
      
      private readonly IInventoriesRepository _inventoriesRepository;
      private readonly IProductsRepository _productsRepository;
      private readonly IStoresRepository _storesRepository;

      public InventoriesController(IInventoriesRepository inventoriesRepository, IProductsRepository productsRepository, IStoresRepository storesRepository)
      {
        _inventoriesRepository = inventoriesRepository;
        _productsRepository = productsRepository;
        _storesRepository = storesRepository;
      }

      [HttpPost]
      public async Task<ActionResult<Inventory>> AddInventory(InventoryDto inventoryDto)
      {
        var product = await _productsRepository.GetProducts(inventoryDto.ProductId);
        var store = await _storesRepository.GetStores(inventoryDto.StoreId);
        var inventory = new Inventory
        {
            //params here 
            Product = product ,
            Store = store,
            BatchNo = inventoryDto.BatchNo,
            Qty = inventoryDto.Qty,
            CostPrice = inventoryDto.CostPrice,
            SellPrice = inventoryDto.SellPrice,
            Discount = inventoryDto.Discount,

        };
        _inventoriesRepository.AddInventory(inventory);
        if(await _inventoriesRepository.SaveAsync()) return Ok();
        return BadRequest("Faild to add inventory");
      }
    }
}