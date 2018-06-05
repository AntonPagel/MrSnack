using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace MrSnack
{
    public class CartItem : Product, INotifyPropertyChanged
    {
        private int number;
        public int Number
        {
            get { return number; }
            set {
                number = value;
                NotifyPropertyChanged("Number");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public CartItem(Product product, int number) : base(product.Name, product.Price, product.Category)
        {
            Number = number;
        }

        private void NotifyPropertyChanged(String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public override string ToString()
        {
            return string.Join("  ", Name, "-", Number);
        }

        public override bool Equals(object obj)
        {
            if (obj is Product product)
            {
                return string.Equals(Name, product.Name) && Price.Equals(product.Price) && Category.Equals(product.Category);
            }
            else if (obj == null)
            {
                return false;
            }
            return Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}