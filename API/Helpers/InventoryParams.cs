using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Helpers
{
    public class InventoryParams : PaginationParams
    {
        public int ProductId { get; set; }
        public int StoreId { get; set; }
        
    }
}