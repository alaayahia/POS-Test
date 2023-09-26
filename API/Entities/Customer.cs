using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public bool HasGiftCard { get; set; }

        public ICollection<Transaction> Transactions { get; set; }
        
    }
}