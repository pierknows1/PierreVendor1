using System.Collections.Generic;
using PierreVendor.Models;
using System;

namespace PierreVendor.Tests
{
    [TestClass]
    public class OrderTests : IDisposable
    {
        public void Dispose()
        {
            Order.ClearAll();
        }
        [TestMethod]
        public void OrderConstructor_CreatesInstanceOfOrder_Order()
        {
            Order newOrder = new Order("Order", "Order", "Order", "Order");
            Assert.AreEqual(typeof(Order), newOrder.GetType());
        }

        [TestMethod]
        public void OrderProperties_ChecksOrderTitle_String()
        {
        string orderTitle = "Test Title";
        Order newOrder = new Order(orderTitle, "Order", "Order", "Order");
        Assert.AreEqual(orderTitle, newOrder.Title);
        }

        [TestMethod]
        public void OrderDescription_CheckForOrderDescription_String()
        {
            string orderDescription = "Order Description";
            Order newOrder = new Order ("Order", orderDescription, "Order", "Order");
            Assert.AreEqual(orderDescription, newOrder.Description);
        }

        [TestMethod]
        public void OrderDescription_ChecksOrderPrice_String()
        {
            string orderPrice = "Order Price";
            Order newOrder = new Order("Order", "Order", orderPrice, "Order");
            Assert.AreEqual(orderPrice, newOrder.Price);
        }

         [TestMethod]
        public void OrderProperties_ChecksOrderDate_String()
        {
            string orderDate = "Test Date";
            Order newOrder = new Order("Order", "Order", "Order", orderDate);
            Assert.AreEqual(orderDate, newOrder.Date);
        }

        [TestMethod]
         public void GetAll_ReturnsAllVendors_List()
        {
            string OrderNumber1 = "Order1";
            string OrderNumber2 = "Order2";
            Order newOrder1 = new Order (OrderNumber1, "Order", "Order", "Order");
            Order newOrder2 = new Order (OrderNumber2, "Order", "Order", "Order");
            List<Order> newOrderList = new List<Order> { newOrder1, newOrder2 };

            List<Order> result = Order.GetAll();
            CollectionAssert.AreEqual(newOrderList, result);
        }
    }
}