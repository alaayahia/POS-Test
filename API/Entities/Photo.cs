using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class Photo
    {
        public int Id { get; set; }
        public bool IsMain { get; set; }
        public string PhotoUrl { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }

       
        
    }
}