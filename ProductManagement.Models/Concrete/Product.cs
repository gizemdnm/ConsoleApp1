using ProductManagement.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.Models.Concrete
{
    public class Product : BaseEntity
    {
        public string ProductName { get; set; }
        public int Stock { get; set;}
        public decimal ProductPrice { get; set;}

    }
}
