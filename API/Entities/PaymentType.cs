using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class PaymentType
    {
        public int Id { get; set; }
        public string PaymentTypeName { get; set; }
        public bool IsMain { get; set; }

        public ICollection<Transaction> Transactions { get; set; }
        
        
    }
}