using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class Transaction
    {
        public int Id { get; set; }
        public DateTime TransDate { get; set; }
        public Customer Customer { get; set; }
        public int CustomerId { get; set; } 
        public int TransTypeId { get; set; }
        public int PaymentTypeId { get; set; }
        public decimal TotalCost { get; set; }
        public decimal TotalSell { get; set; }
        public decimal TotalDiscount { get; set; }

        public ICollection<TransactionDetail> TransactionDetails { get; set; }

        
        
    }
}