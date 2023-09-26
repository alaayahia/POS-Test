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
    
    public class CategoryController : BaseApiController
    {
        private readonly ICategoriesRepository _categoriesRepository;
        public CategoryController(ICategoriesRepository categoriesRepository)
        {
            _categoriesRepository = categoriesRepository;
        }

        [HttpPost]
        public async Task<ActionResult<Category>> AddCategory(CategoryDto categoryDto)
        {
            var category = new Category
            {
                CategoryName = categoryDto.CategoryName               
            };
            _categoriesRepository.AddCategory(category);
            if(await _categoriesRepository.SaveAsync()) return Ok();
            return BadRequest("Faild to add catetogry");
        }
        
     
    }
}