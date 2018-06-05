using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MrSnack;

namespace MrSnack.UnitTestProject
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Product snickers = new Product("Snickers", 1.60, ProductCategories.Sweet);
            Product mars = new Product("Mars", 1.50, ProductCategories.Sweet);
            CartItem cartItem = new CartItem(snickers, 3);
            Assert.IsTrue(cartItem.Equals(snickers));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Controller controller = new Controller();
            Product snickers = new Product("Snickers", 1.60, ProductCategories.Sweet);
            Product mars = new Product("Mars", 1.50, ProductCategories.Sweet);
            controller.AddCartItem(snickers);
            controller.AddCartItem(mars);
            controller.AddCartItem(snickers);
            Assert.AreEqual(2, controller.Cart[0].Number);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Controller controller = new Controller();
            Product snickers = new Product("Snickers", 1.60, ProductCategories.Sweet);
            Product mars = new Product("Mars", 1.50, ProductCategories.Sweet);
            controller.AddCartItem(snickers);
            controller.AddCartItem(mars);
            controller.AddCartItem(snickers);
            controller.AddCartItem(mars);
            controller.RemoveCartItem(snickers);
            Assert.AreEqual(1, controller.Cart[0].Number);
        }
    }
}