using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrSnack
{
    public class CartItem
    {
        public Product Product { get; }
        public int Number { get; set; }
        public string Display { get { return $"{Product.Name}  -  {Number}"; } }

        public CartItem(Product product, int number)
        {
            Product = product;
            Number = number;
        }
    }
}