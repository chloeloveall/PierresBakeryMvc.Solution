using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakeryMvc.Models;
using System.Collections.Generic;
using System;

namespace PierresBakeryMvc.Tests
{

  [TestClass]
  public class VendorTests : IDisposable
  {

    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("TEST VENDOR", "TEST DESCRIPTION", "TEST ADDRESS", "TEST ADDRESS 2", "TEST CITY", "TEST STATE", 98006);
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetVendorName_ReturnsVendorName_String()
    {
      string vendorName = "TEST VENDOR";
      string vendorDescription = "TEST DESCRIPTION";
      string vendorAddress = "TEST ADDRESS";
      string vendorAddress2 = "TEST ADDRESS 2";
      string vendorCity = "TEST CITY";
      string vendorState = "TEST STATE";
      int vendorZip = 98006;
      Vendor newVendor = new Vendor(vendorName, vendorDescription, vendorAddress, vendorAddress2, vendorCity, vendorState, vendorZip);

      string result = newVendor.VendorName;

      Assert.AreEqual(vendorName, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      string vendorName = "TEST VENDOR";
      string vendorDescription = "TEST DESCRIPTION";
      string vendorAddress = "TEST ADDRESS";
      string vendorAddress2 = "TEST ADDRESS 2";
      string vendorCity = "TEST CITY";
      string vendorState = "TEST STATE";
      int vendorZip = 98006;
      Vendor newVendor = new Vendor(vendorName, vendorDescription, vendorAddress, vendorAddress2, vendorCity, vendorState, vendorZip);

      int result = newVendor.Id;

      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string vendorName = "TEST VENDOR";
      string vendorDescription = "TEST DESCRIPTION";
      string vendorAddress = "TEST ADDRESS";
      string vendorAddress2 = "TEST ADDRESS 2";
      string vendorCity = "TEST CITY";
      string vendorState = "TEST STATE";
      int vendorZip = 98006;
      Vendor newVendor = new Vendor(vendorName, vendorDescription, vendorAddress, vendorAddress2, vendorCity, vendorState, vendorZip);

      string result = newVendor.VendorDescription;

      //Assert
      Assert.AreEqual(vendorDescription, result);
    }

    [TestMethod]
    public void GetVendorAddress_ReturnsVendorAddress_String()
    {
      string vendorName = "TEST VENDOR";
      string vendorDescription = "TEST DESCRIPTION";
      string vendorAddress = "TEST ADDRESS";
      string vendorAddress2 = "Test Address 2";
      string vendorCity = "TEST CITY";
      string vendorState = "TEST STATE";
      int vendorZip = 98006;
      Vendor newVendor = new Vendor(vendorName, vendorDescription, vendorAddress, vendorAddress2, vendorCity, vendorState, vendorZip);

      string result = newVendor.VendorAddress;

      Assert.AreEqual(vendorAddress, result);
    }

    [TestMethod]
    public void GetVendorAddress2_ReturnsVendorAddress2_String()
    {
      string vendorName = "TEST VENDOR";
      string vendorDescription = "TEST DESCRIPTION";
      string vendorAddress = "TEST ADDRESS";
      string vendorAddress2 = "TEST ADDRESS 2";
      string vendorCity = "TEST CITY";
      string vendorState = "TEST STATE";
      int vendorZip = 98006;
      Vendor newVendor = new Vendor(vendorName, vendorDescription, vendorAddress, vendorAddress2, vendorCity, vendorState, vendorZip);

      string result = newVendor.VendorAddress2;

      Assert.AreEqual(vendorAddress2, result);
    }

    [TestMethod]
    public void GetVendorCity_ReturnsVendorCity_String()
    {
      string vendorName = "TEST VENDOR";
      string vendorDescription = "TEST DESCRIPTION";
      string vendorAddress = "TEST ADDRESS";
      string vendorAddress2 = "TEST ADDRESS 2";
      string vendorCity = "TEST CITY";
      string vendorState = "TEST STATE";
      int vendorZip = 98006;
      Vendor newVendor = new Vendor(vendorName, vendorDescription, vendorAddress, vendorAddress2, vendorCity, vendorState, vendorZip);

      string result = newVendor.VendorCity;

      Assert.AreEqual(vendorCity, result);
    }

    [TestMethod]
    public void GetVendorState_ReturnsVendorState_String()
    {
      string vendorName = "TEST VENDOR";
      string vendorDescription = "TEST DESCRIPTION";
      string vendorAddress = "TEST ADDRESS";
      string vendorAddress2 = "TEST ADDRESS 2";
      string vendorCity = "TEST CITY";
      string vendorState = "TEST STATE";
      int vendorZip = 98006;
      Vendor newVendor = new Vendor(vendorName, vendorDescription, vendorAddress, vendorAddress2, vendorCity, vendorState, vendorZip);

      string result = newVendor.VendorState;

      Assert.AreEqual(vendorState, result);
    }

[TestMethod]
    public void GetVendorZip_ReturnsVendorZip_String()
    {
      string vendorName = "TEST VENDOR";
      string vendorDescription = "TEST DESCRIPTION";
      string vendorAddress = "TEST ADDRESS";
      string vendorAddress2 = "TEST ADDRESS 2";
      string vendorCity = "TEST CITY";
      string vendorState = "TEST STATE";
      int vendorZip = 98006;
      Vendor newVendor = new Vendor(vendorName, vendorDescription, vendorAddress, vendorAddress2, vendorCity, vendorState, vendorZip);

      int result = newVendor.VendorZip;

      Assert.AreEqual(vendorZip, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      string vendorName1 = "FLYING FISH COMPANY";
      string vendorDescription1 = "FLYING FISH COMPANY DESCRIPTION";
      string vendorAddress = "FLYING FISH ADDRESS";
      string vendorAddress2 = "FLYING FISH ADDRESS 2";
      string vendorCity = "FLYING FISH CITY";
      string vendorState = "FLYING FISH STATE";
      int vendorZip = 98006;
      string vendorName2 = "VIVIENNE";
      string vendorDescription2 = "VIVIENNE DESCRIPTION";
      string vendorAddressAlt = "VIVIENNE ADDRESS";
      string vendorAddressAlt2 = "VIVIENNE ADDRESS 2";
      string vendorCity2 = "VIVIENNE CITY";
      string vendorState2 = "VIVIENNE STATE";
      int vendorZip2 = 98006;
      Vendor newVendor1 = new Vendor(vendorName1, vendorDescription1, vendorAddress, vendorAddress2, vendorCity, vendorState, vendorZip);
      Vendor newVendor2 = new Vendor(vendorName2, vendorDescription2, vendorAddressAlt, vendorAddressAlt2, vendorCity2, vendorState2, vendorZip2);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };

      List<Vendor> result = Vendor.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      string vendorName1 = "FLYING FISH COMPANY";
      string vendorDescription1 = "FLYING FISH COMPANY DESCRIPTION";
      string vendorAddress = "FLYING FISH ADDRESS";
      string vendorAddress2 = "FLYING FISH ADDRESS 2";
      string vendorCity = "FLYING FISH CITY";
      string vendorState = "FLYING FISH STATE";
      int vendorZip = 98006;
      string vendorName2 = "VIVIENNE";
      string vendorDescription2 = "VIVIENNE DESCRIPTION";
      string vendorAddressAlt = "VIVIENNE ADDRESS";
      string vendorAddressAlt2 = "VIVIENNE ADDRESS 2";
      string vendorCity2 = "VIVIENNE CITY";
      string vendorState2 = "VIVIENNE STATE";
      int vendorZip2 = 98006;
      Vendor newVendor1 = new Vendor(vendorName1, vendorDescription1, vendorAddress, vendorAddress2, vendorCity, vendorState, vendorZip);
      Vendor newVendor2 = new Vendor(vendorName2, vendorDescription2, vendorAddressAlt, vendorAddressAlt2, vendorCity2, vendorState2, vendorZip2);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };

      Vendor result = Vendor.Find(2);

      Assert.AreEqual(newVendor2, result);
    }

    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      string vendorName = "FFLYING FISH COMPANY";
      string vendorDescription = "FLYING FISH COMPANY DESCRIPTION";
      string vendorAddress = "FLYING FISH ADDRESS";
      string vendorAddress2 = "FLYING FISH ADDRESS 2";
      string vendorCity = "FLYING FISH CITY";
      string vendorState = "FLYING FISH STATE";
      int vendorZip = 98006;
      string orderTitle = "FLYING FISH ORDER TITLE";
      string orderPlacedBy = "NAME OF ORDERER";
      string orderDescription = "DESCRIPTION OF ORDER";
      int orderPrice = 100;
      Order newOrder = new Order (orderTitle, orderPlacedBy, orderDescription, orderPrice);
      List<Order> newList = new List<Order> { newOrder };
      Vendor newVendor = new Vendor(vendorName, vendorDescription, vendorAddress, vendorAddress2, vendorCity, vendorState, vendorZip);
      newVendor.AddOrder(newOrder);

      List<Order> result = newVendor.Orders;

      CollectionAssert.AreEqual(newList, result);
    }

  }
}