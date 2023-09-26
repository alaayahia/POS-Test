using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductDesc { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public string Barcode { get; set; }
        public int PayOff { get; set; }

        
        public ICollection<Inventory> Inventories { get; set; }
        public ICollection<Photo> Photos { get; set; }
        public ICollection<TransactionDetail> TransactionDetails { get; set; }


        

    }
}