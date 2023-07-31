
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
        public void Vendorname_ChecksName_Vendor()
        {
            string vendorName = "Vendor's name";
            Vendor newVendor = new Vendor(vendorName, "Description");
            Assert.AreEqual(vendorName, newVendor.Name);
        }

        [TestMethod]
        public void VendorDescription_CreateDescription_Vendor()
        {
            string vendorDescription = "Description";
            Vendor newVendor = new Vendor("Vendor's name", vendorDescription);
            Assert.AreEqual(vendorDescription, newVendor.Description);
        }

        [TestMethod]
        public void GetVendorId_RetunId_Int()
        {
            Vendor newVendor = new Vendor ("vendorName", "Description");
            int result = newVendor.Id;
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void GetAll_ReturnsAllVendors_List()
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
