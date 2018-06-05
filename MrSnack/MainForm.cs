using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MrSnack
{
    public partial class MainForm : Form
    {
        Controller controller = new Controller();

        public MainForm()
        {
            InitializeComponent();
            productsTypesComboBox.DataSource = Enum.GetValues(typeof(ProductCategories));
            cartListBox.DataSource = controller.Cart;
        }

        private void ProductsTypesComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            productsListBox.DataSource = controller.Products(Enum.TryParse(productsTypesComboBox.Text, out ProductCategories productCategory) ? productCategory : ProductCategories.All);
        }

        private void AddToCartButtonClick(object sender, EventArgs e)
        {
            if (productsListBox.SelectedItem != null)
            {
                controller.AddCartItem((Product)productsListBox.SelectedItem);
            }
        }

        private void PlusButtonClick(object sender, EventArgs e)
        {
            if (cartListBox.SelectedItem != null)
            {
                controller.AddCartItem((Product)cartListBox.SelectedItem);
            }
        }

        private void MinusButtonClick(object sender, EventArgs e)
        {
            if (cartListBox.SelectedItem != null)
            {
                controller.RemoveCartItem(((CartItem)cartListBox.SelectedItem));
            }
        }

        private void PayButtonClick(object sender, EventArgs e)
        {
            if (controller.Cart.Count > 0)
            {
                controller.ClearCart();
            }
        }
    }
}
