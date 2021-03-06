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
      Order newOrder = new Order("Test Orderer", "Test Order Description");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetOrderPlacedBy_ReturnsVendorName_String()
    {
      string orderPlacedBy = "Test Orderer";
      string orderDescription = "Test Order Description";

      Order newOrder = new Order(orderPlacedBy, orderDescription);
      string result = newOrder.OrderPlacedBy;

      Assert.AreEqual(orderPlacedBy, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string orderPlacedBy = "Test Orderer";
      string orderDescription = "Test Order Description";

      Order newOrder = new Order(orderPlacedBy, orderDescription);
      string result = newOrder.OrderDescription;

      Assert.AreEqual(orderDescription, result);
    }


  }
}