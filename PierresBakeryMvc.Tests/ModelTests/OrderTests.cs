using Microsoft.VisualStudio.TestTools.UnitTesting;
// using System.Collections.Generic;
using PierresBakeryMvc.Models;
// using System;

namespace PierresBakeryMvc.Tests
{
  [TestClass]
  public class OrderTest
  {

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("Test Vendor");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetVendorName_ReturnsVendorName_String()
    {
      string vendorName = "Test Vendor";

      Order newOrder = new Order(vendorName);
      string result = newOrder.VendorName;

      Assert.AreEqual(vendorName, result);
    }

  }
}