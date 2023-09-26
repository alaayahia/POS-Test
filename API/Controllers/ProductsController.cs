using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using API.Interfaces;
using API.Entities;
using API.DTOs; 

namespace API.Controllers
{
    
    public class ProductsController : BaseApiController
    {
        private readonly IProductsRepository _productsRepository;
        private readonly ICategoriesRepository _categoriesRepository;
        private readonly IStoresRepository _storesRepository;
        public ProductsController(IProductsRepository productsRepository, ICategoriesRepository categoriesRepository, IStoresRepository storesRepository)
        {
            _productsRepository = productsRepository;
            _categoriesRepository = categoriesRepository;
            _storesRepository = storesRepository;
        } 

        [HttpPost]
        public async Task<ActionResult<Product>> AddProduct(ProductDto productDto)
        {
            var category = await _categoriesRepository.GetCategories(productDto.CategoryId);
            var product = new Product
            {
              
               ProductName = productDto.ProductName, 
               ProductDesc = productDto.ProductDesc,
               Barcode = productDto.Barcode,
               Category = category,
               PayOff = productDto.PayOff
            };
            _productsRepository.AddProduct(product);
            if(await _productsRepository.SaveAsync()) return Ok();
            return BadRequest("Faild To add product");
            
        }
        

            
        
        [HttpPost("stores")]
        public async Task<ActionResult<Store>> AddStore(StoreDto storeDto)
        {
            var store = new Store
            {
                StoreName = storeDto.StoreName,
                IsShowRoom = storeDto.IsShowRoom
            };
            _storesRepository.AddStore(store);
            if(await _storesRepository.SaveAsync()) return Ok();
            return BadRequest("Faild To add store");
        }
    }
}