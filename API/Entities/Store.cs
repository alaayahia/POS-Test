using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class Store
    {
        public int Id { get; set; }
        public string StoreName { get; set; }
        public bool IsShowRoom { get; set; }

        public ICollection<Inventory> Inventories { get; set; }
        public ICollection<TransactionDetail> TransactionDetails { get; set; }

        
    }
}