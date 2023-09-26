using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
    public class InventoryDto
    {
        // public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductBarcode { get; set; }
        public int ProductId { get; set; }
        public string StoreName { get; set; }
        public int StoreId { get; set; }
        public string BatchNo { get; set; }
        public int Qty { get; set; }
        public decimal CostPrice { get; set; }
        public decimal SellPrice { get; set; }
        public decimal Discount { get; set; }
        public DateTime ExpireDate { get; set; }
    }
}