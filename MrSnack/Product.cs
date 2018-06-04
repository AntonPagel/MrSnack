using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrSnack
{
    public class Product
    {
        public string Name { get; }
        public double Price { get; }
        public ProductCategories Category { get; }

        public Product(string name, double price, ProductCategories category)
        {
            Name = name;
            Price = price;
            Category = category;
        }
    }
}