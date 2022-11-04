using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class Order :BaseEntity
    {
        public int OrderId { get; set; }

        public string? Receipt { get; set; }

        public string? Address { get; set; }
        public Product? OrderedProduct { get; set; }
    }
}
