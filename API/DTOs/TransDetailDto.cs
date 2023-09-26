using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
    public class TransDetailDto
    {
        public int Id { get; set; }
        public DateTime TransDate { get; set; }
        public int TransactionId { get; set; }
        public string ProductName { get; set; }
        public int ProductId { get; set; }
        public string StoreName { get; set; }
        public int StoreId { get; set; }
        public string BatchNo { get; set; }
        public int QtyIn { get; set; }
        public int QtyOut { get; set; }
        public decimal CostPrice { get; set; }
        public decimal SellPrice { get; set; }
        public decimal TotalCost { get; set; }
        public decimal TotalSell { get; set; }
        public decimal TotalDiscount { get; set; }
        
    }
}