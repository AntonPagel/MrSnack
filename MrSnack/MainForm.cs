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
            cartListBox.DataSource = controller.Cart;
        }

        private void MainFormLoad(object sender, EventArgs e)
        {
            productsTypesComboBox.DataSource = Enum.GetValues(typeof(ProductCategories));
        }

        private void productsTypesComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            productsListBox.DataSource = controller.Products(Enum.TryParse(productsTypesComboBox.Text, out ProductCategories productCategory) ? productCategory : ProductCategories.All);
        }

        private void addToCartButtonClick(object sender, EventArgs e)
        {
            if (productsListBox.SelectedItem != null)
            {
                controller.AddCartItem((Product)productsListBox.SelectedItem);
                cartListBox.DataSource = null;
                cartListBox.DataSource = controller.Cart;
                cartListBox.DisplayMember = "Display";
            }
        }

        private void plusButtonClick(object sender, EventArgs e)
        {
            if (cartListBox.SelectedItem != null)
            {
                controller.AddCartItem((Product)productsListBox.SelectedItem);
                cartListBox.DataSource = null;
                cartListBox.DataSource = controller.Cart;
                cartListBox.DisplayMember = "Display";
            }
        }

        private void minusButtonClick(object sender, EventArgs e)
        {
            if (cartListBox.SelectedItem != null)
            {
                controller.SubtractCartItem(((CartItem)cartListBox.SelectedItem).Product);
                cartListBox.DataSource = null;
                cartListBox.DataSource = controller.Cart;
                cartListBox.DisplayMember = "Display";
            }
        }

        private void payButtonClick(object sender, EventArgs e)
        {
            if (controller.Cart.Count > 0)
            {
                controller.ClearCart();
                cartListBox.DataSource = null;
                cartListBox.DataSource = controller.Cart;
                cartListBox.DisplayMember = "Display";
            }
        }
    }
}
