using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class TransactionType
    {
        public int Id { get; set; }
        public string TransTypeName { get; set; }
        public int TaxValue { get; set; }
        public int DeliveryFees { get; set; }

        public ICollection<Transaction> Transactions { get; set; }

        
    }
}