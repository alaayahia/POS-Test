using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Text.Json;
using API.Helpers;


namespace API.Extensions
{
    public static class HttpExtensions
    {
        public static void AddPaginationHeader(this HttpResponse response, int currentPage, int itemsPerPage, int totalItems, int totalPages)
        {
            var paginationHeader = new PaginationHeader(currentPage, itemsPerPage, totalItems, totalPages);
            var options = new JsonSerializerOptions
             {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
             };
             response.Headers.Add("Pagination", JsonSerializer.Serialize(paginationHeader, options));
             response.Headers.Add("Access-control-Expose-Headers","Pagination");

        }

        
    }
}