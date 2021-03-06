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
      Order newOrder = new Order("Test Orderer", "Test Order Description", 100);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetOrderPlacedBy_ReturnsVendorName_String()
    {
      string orderPlacedBy = "Test Orderer";
      string orderDescription = "Test Order Description";
      int orderPrice = 100;

      Order newOrder = new Order(orderPlacedBy, orderDescription, orderPrice);
      string result = newOrder.OrderPlacedBy;

      Assert.AreEqual(orderPlacedBy, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string orderPlacedBy = "Test Orderer";
      string orderDescription = "Test Order Description";
      int orderPrice = 100;

      Order newOrder = new Order(orderPlacedBy, orderDescription, orderPrice);
      string result = newOrder.OrderDescription;

      Assert.AreEqual(orderDescription, result);
    }

    [TestMethod]
    public void GetOrderPrice_ReturnsOrderPrice_Int()
    {
      string orderPlacedBy = "Test Orderer";
      string orderDescription = "Test Order Description";
      int orderPrice = 100;

      Order newOrder = new Order(orderPlacedBy, orderDescription, orderPrice);
      int result = newOrder.OrderPrice;

      Assert.AreEqual(orderPrice, result);
    }


  }
}