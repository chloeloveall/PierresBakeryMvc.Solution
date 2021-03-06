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
      Order newOrder = new Order("TEST TITLE", "TEST ORDERER", "TEST ORDER DESCRIPTION", 100);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetOrderPlacedBy_ReturnsVendorName_String()
    {
      string orderTitle = "TEST TITLE";
      string orderPlacedBy = "TEST ORDERER";
      string orderDescription = "TEST ORDER DESCRIPTION";
      int orderPrice = 100;

      Order newOrder = new Order(orderTitle, orderPlacedBy, orderDescription, orderPrice);
      string result = newOrder.OrderPlacedBy;

      Assert.AreEqual(orderPlacedBy, result);
    }

    public void GetOrderTitle_ReturnsOrderTitle_String()
    {
      string orderTitle = "TEST TITLE";
      string orderPlacedBy = "TEST ORDERER";
      string orderDescription = "TEST ORDER DESCRIPTION";
      int orderPrice = 100;

      Order newOrder = new Order(orderTitle, orderPlacedBy, orderDescription, orderPrice);
      string result = newOrder.OrderTitle;

      Assert.AreEqual(orderTitle, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string orderTitle = "TEST TITLE";
      string orderPlacedBy = "TEST ORDERER";
      string orderDescription = "TEST ORDER DESCRIPTION";
      int orderPrice = 100;

      Order newOrder = new Order(orderTitle, orderPlacedBy, orderDescription, orderPrice);
      string result = newOrder.OrderDescription;

      Assert.AreEqual(orderDescription, result);
    }

    [TestMethod]
    public void GetOrderPrice_ReturnsOrderPrice_Int()
    {
      string orderTitle = "TEST TITLE";
      string orderPlacedBy = "TEST ORDERER";
      string orderDescription = "TEST ORDER DESCRIPTION";
      int orderPrice = 100;

      Order newOrder = new Order(orderTitle, orderPlacedBy, orderDescription, orderPrice);
      int result = newOrder.OrderPrice;

      Assert.AreEqual(orderPrice, result);
    }

    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      string orderTitle1 = "TEST TITLE 1";
      string orderPlacedBy1 = "TEST ORDERER 1";
      string orderDescription1 = "TEST ORDER DESCRIPTION 1";
      int orderPrice1 = 100;
      string orderTitle2 = "TEST TITLE 2";
      string orderPlacedBy2 = "TEST ORDERER 2";
      string orderDescription2 = "TEST ORDER DESCRIPTION 2";
      int orderPrice2 = 150;
      Order newOrder1 = new Order(orderTitle1, orderPlacedBy1, orderDescription1, orderPrice1);
      Order newOrder2 = new Order(orderTitle2, orderPlacedBy2, orderDescription2, orderPrice2);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };

      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_ReturnsOrderId_Int()
    {
      string orderTitle = "TEST TITLE";
      string orderPlacedBy = "TEST ORDERER";
      string orderDescription = "TEST ORDER DESCRIPTION";
      int orderPrice = 100;

      Order newOrder = new Order(orderTitle, orderPlacedBy, orderDescription, orderPrice);
      int result = newOrder.Id;

      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetDate_ReturnsOrderDate_DateTime()
    {
      string orderTitle = "TEST TITLE";
      string orderPlacedBy = "TEST ORDERER";
      string orderDescription = "TEST ORDER DESCRIPTION";
      int orderPrice = 100;

      Order newOrder = new Order(orderTitle, orderPlacedBy, orderDescription, orderPrice);
      DateTime result = newOrder.Date;

      Assert.AreEqual(DateTime.Today, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      string orderTitle1 = "TEST TITLE 1";
      string orderPlacedBy1 = "TEST ORDERER 1";
      string orderDescription1 = "TEST ORDER DESCRIPTION 1";
      int orderPrice1 = 100;
      string orderTitle2 = "TEST TITLE 2";
      string orderPlacedBy2 = "TEST ORDERER 2";
      string orderDescription2 = "TEST ORDER DESCRIPTION 2";
      int orderPrice2 = 150;
      Order newOrder1 = new Order(orderTitle1, orderPlacedBy1, orderDescription1, orderPrice1);
      Order newOrder2 = new Order(orderTitle2, orderPlacedBy2, orderDescription2, orderPrice2);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };

      Order result = Order.Find(2);

      Assert.AreEqual(newOrder2, result);
    }

  }
}