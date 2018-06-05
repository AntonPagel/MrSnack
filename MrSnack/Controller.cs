using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace MrSnack
{
    public class Controller
    {
        public BindingList<CartItem> Cart { get; private set; }
        private List<Product> products = new List<Product>();

        public Controller()
        {
            Cart = new BindingList<CartItem>();
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
            CartItem cartItem = Cart.FirstOrDefault(x => x.Equals(product));
            if (cartItem != null)
            {
                cartItem.Number++;
            }
            else
            {
                Cart.Add(new CartItem(product, 1));
            }
        }

        public void RemoveCartItem(CartItem cartItem)
        {
            if (Cart.Contains(cartItem))
            {
                cartItem.Number--;
                if (cartItem.Number <= 0)
                {
                    Cart.Remove(cartItem);
                }
            }
        }

        public void ClearCart()
        {
            Cart.Clear();
        }
    }
}