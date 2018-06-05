using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrSnack
{
    public class Product
    {
        public string Name { get; private set; }
        public double Price { get; private set; }
        public ProductCategories Category { get; private set; }

        public Product(string name, double price, ProductCategories category)
        {
            Name = name;
            Price = price;
            Category = category;
        }
    }
}