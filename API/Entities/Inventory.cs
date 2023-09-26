using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class Inventory
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public Store Store { get; set; }
        public int StoreId { get; set; }
        public string BatchNo { get; set; }
        public int Qty { get; set; }
        public decimal CostPrice { get; set; }
        public decimal SellPrice { get; set; }
        public decimal Discount { get; set; }
        public DateTime ExpireDate { get; set; }

     
        
        
    }
}