using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MagasinProduct.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string FromPrice { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
    }
}
