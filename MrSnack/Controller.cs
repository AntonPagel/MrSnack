using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrSnack
{
    public class Controller
    {
        public List<CartItem> Cart { get; }
        List<Product> products = new List<Product>();

        public Controller()
        {
            Cart = new List<CartItem>();
            products.AddRange(new Product[] {
                new Product("Snickers", 1.60, ProductCategories.Sweet),
                new Product("Mars", 1.50, ProductCategories.Sweet),
                new Product("Cola", 2, ProductCategories.Beverage),
                new Product("Chips", 1.80, ProductCategories.Salty)
            });
        }

        public List<Product> Products(ProductCategories productCategory)
        {
            if (productCategory == ProductCategories.All)
            {
                return products;
            }
            return products.Where(x => x.Category == productCategory).ToList();
        }

        public void AddCartItem(Product product)
        {
            if (Cart.Exists(x => x.Product == product))
            {
                Cart.First(x => x.Product == product).Number++;
            }
            else
            {
                Cart.Add(new CartItem(product, 1));
            }
        }

        public void SubtractCartItem(Product product)
        {
            Cart.First(x => x.Product == product).Number--;
            if (Cart.First(x => x.Product == product).Number <= 0)
            {
                Cart.Remove(Cart.First(x => x.Product == product));
            }
        }

        public void ClearCart()
        {
            Cart.Clear();
        }
    }
}