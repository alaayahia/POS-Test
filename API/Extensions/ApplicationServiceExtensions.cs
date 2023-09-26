using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Interfaces;
using API.Data;
using API.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace API.Extensions
{
    public static class ApplicationServiceExtensions
    {

    public static IServiceCollection AddApplicationServices(this IServiceCollection services , IConfiguration config) 
       {
        services.AddScoped<ICategoriesRepository, CategoriesRepository>();
        services.AddScoped<IStoresRepository, StoresRepository>();
        services.AddScoped<IProductsRepository, ProductsRepository>();
        services.AddScoped<IInventoriesRepository, InventoriesRepository>();
        services.AddScoped<ITransDeatilsRepository, TransDetailsRepository>();


        services.AddAutoMapper(typeof(AutoMapperProfiles).Assembly);

         services.AddDbContext<DataContext>(options => {
               options.UseSqlite(config.GetConnectionString("DefaultConnection"));
         });
       
       return services;
       }
        
    }
}