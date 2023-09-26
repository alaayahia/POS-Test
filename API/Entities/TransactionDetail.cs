using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class TransactionDetail
    {
        public int Id { get; set; }
        public Transaction Transaction { get; set; }
        public int TransactionId { get; set; }
        public string PaymentStatus { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public Store Store { get; set; }
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