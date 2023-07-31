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
            Order newOrder = new Order("Order Test", "Order Description");
            Assert.AreEqual(typeof(Order), newOrder.GetType());
        }
        [TestMethod]
        public void OrderDescription_CheckForOrderDescription_string()
        {
            string orderDescription = "Order Description";
            Order newOrder = new Order ("Order Test", orderDescription);
            Assert.AreEqual(orderDescription, newOrder.Description);
        }
         public void GetAll_ReturnsAllVendors_List()
        {
            string OrderNumber1 = "Order1";
            string OrderNumber2 = "Order2";
            Order newOrder1 = new Order (OrderNumber1, "Order Test");
            Order newOrder2 = new Order (OrderNumber2, "Order Test");
            List<Order> newOrderList = new List<Order> { newOrder1, newOrder2 };

            List<Order> result = Order.GetAll();
            
            CollectionAssert.AreEqual(newOrderList, result);
        }
    }
}