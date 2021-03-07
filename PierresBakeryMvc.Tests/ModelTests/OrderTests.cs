using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakeryMvc.Models;
using System;
using System.Collections.Generic;

namespace PierresBakeryMvc.Tests
{
  [TestClass]
  public class OrderTest : IDisposable
  {

    public void Dispose()
    {
      Order.ClearAll();
    }

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

    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      string orderPlacedBy1 = "Test Orderer 1";
      string orderDescription1 = "Test Order Description 1";
      int orderPrice1 = 100;
      string orderPlacedBy2 = "Test Orderer 2";
      string orderDescription2 = "Test Order Description 2";
      int orderPrice2 = 150;
      Order newOrder1 = new Order(orderPlacedBy1, orderDescription1, orderPrice1);
      Order newOrder2 = new Order(orderPlacedBy2, orderDescription2, orderPrice2);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };

      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_ReturnsOrderId_Int()
    {
      string orderPlacedBy = "Test Orderer";
      string orderDescription = "Test Order Description";
      int orderPrice = 100;

      Order newOrder = new Order(orderPlacedBy, orderDescription, orderPrice);
      int result = newOrder.Id;

      Assert.AreEqual(1001, result);
    }

    [TestMethod]
    public void GetDate_ReturnsOrderDate_DateTime()
    {
      string orderPlacedBy = "Test Orderer";
      string orderDescription = "Test Order Description";
      int orderPrice = 100;

      Order newOrder = new Order(orderPlacedBy, orderDescription, orderPrice);
      DateTime result = newOrder.Date;

      Assert.AreEqual(DateTime.Today, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      string orderPlacedBy1 = "Test Orderer 1";
      string orderDescription1 = "Test Order Description 1";
      int orderPrice1 = 100;
      string orderPlacedBy2 = "Test Orderer 2";
      string orderDescription2 = "Test Order Description 2";
      int orderPrice2 = 150;
      Order newOrder1 = new Order(orderPlacedBy1, orderDescription1, orderPrice1);
      Order newOrder2 = new Order(orderPlacedBy2, orderDescription2, orderPrice2);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };

      Order result = Order.Find(2);

      Assert.AreEqual(newOrder2, result);
    }

  }
}