
using System.Collections.Generic;
using PierreVendor.Models;
using System;

namespace PierreVendor.Tests
{
     [TestClass]
    public class VendorTests : IDisposable
    {
        public void Dispose()
        {
            Vendor.ClearAll();

        }
        [TestMethod]
        public void VendorConstructor_CreateInstanceOfVendor_Vendor()
        {
            Vendor newVendor = new Vendor("name", "description");
            Assert.AreEqual(typeof(Vendor), newVendor.GetType());
        }
    
        [TestMethod]
        public void VendorName_ChecksNameVendor_String()
        {
            string vendorName = "Vendor's name";
            Vendor newVendor = new Vendor(vendorName, "Description");
            Assert.AreEqual(vendorName, newVendor.Name);
        }

        [TestMethod]
        public void VendorDescription_CreateDescriptionOfVendor_String()
        {
            string vendorDescription = "Describe Vendor";
            Vendor newVendor = new Vendor("Vendor's name", vendorDescription);
            Assert.AreEqual(vendorDescription, newVendor.Description);
        }

        [TestMethod]
        public void GetVendorId_ReturnId_Int()
        {
            Vendor newVendor = new Vendor ("vendorName", "vendorDescription");
            int result = newVendor.Id;
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Find_ReturnsOrder_Order()
        {
            Vendor newVendor1 = new Vendor("VendorName1", "VendorDescription1");
            Vendor newVendor2 = new Vendor("VendorName2", "VendorDescription2");
            Assert.AreEqual(newVendor2, Vendor.Find(2));
        }

        [TestMethod]
        public void AddOrder_AddOrderToVendorsList_List()
        {
            Order newOrder = new Order("today", "unpaid", "Order", "Order");
            Vendor newVendor = new Vendor("two", "strings");
            newVendor.AddOrder(newOrder);
            Assert.IsTrue(newVendor.Orders.Contains(newOrder));
        }    


        [TestMethod]
        public void GetAll_ReturnsAllVendorsItems_List()
        {
            string vendor1 = "Vendor1";
            string vendor2 = "Vendor2";
            Vendor newVendor1 = new Vendor (vendor1, "description");
            Vendor newVendor2 = new Vendor (vendor2, "description");
            List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };

            List<Vendor> result = Vendor.GetAll();
            
            CollectionAssert.AreEqual(newList, result);
        }
    }
}