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
      Vendor newVendor = new Vendor("Test Vendor", "Test Description", "Test Address", "Test Address 2", "Test City", "Test State", 98006);
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetVendorName_ReturnsVendorName_String()
    {
      string vendorName = "Test Vendor";
      string vendorDescription = "Test Description";
      string vendorAddress = "Test Address";
      string vendorAddress2 = "Test Address 2";
      string vendorCity = "Test City";
      string vendorState = "Test State";
      int vendorZip = 98006;
      Vendor newVendor = new Vendor(vendorName, vendorDescription, vendorAddress, vendorAddress2, vendorCity, vendorState, vendorZip);

      string result = newVendor.VendorName;

      Assert.AreEqual(vendorName, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      string vendorName = "Test Vendor";
      string vendorDescription = "Test Description";
      string vendorAddress = "Test Address";
      string vendorAddress2 = "Test Address 2";
      string vendorCity = "Test City";
      string vendorState = "Test State";
      int vendorZip = 98006;
      Vendor newVendor = new Vendor(vendorName, vendorDescription, vendorAddress, vendorAddress2, vendorCity, vendorState, vendorZip);

      int result = newVendor.Id;

      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string vendorName = "Test Vendor";
      string vendorDescription = "Test Description";
      string vendorAddress = "Test Address";
      string vendorAddress2 = "Test Address 2";
      string vendorCity = "Test City";
      string vendorState = "Test State";
      int vendorZip = 98006;
      Vendor newVendor = new Vendor(vendorName, vendorDescription, vendorAddress, vendorAddress2, vendorCity, vendorState, vendorZip);

      string result = newVendor.VendorDescription;

      //Assert
      Assert.AreEqual(vendorDescription, result);
    }

    [TestMethod]
    public void GetVendorAddress_ReturnsVendorAddress_String()
    {
      string vendorName = "Test Vendor";
      string vendorDescription = "Test Description";
      string vendorAddress = "Test Address";
      string vendorAddress2 = "Test Address 2";
      string vendorCity = "Test City";
      string vendorState = "Test State";
      int vendorZip = 98006;
      Vendor newVendor = new Vendor(vendorName, vendorDescription, vendorAddress, vendorAddress2, vendorCity, vendorState, vendorZip);

      string result = newVendor.VendorAddress;

      Assert.AreEqual(vendorAddress, result);
    }

    [TestMethod]
    public void GetVendorAddress2_ReturnsVendorAddress2_String()
    {
      string vendorName = "Test Vendor";
      string vendorDescription = "Test Description";
      string vendorAddress = "Test Address";
      string vendorAddress2 = "Test Address 2";
      string vendorCity = "Test City";
      string vendorState = "Test State";
      int vendorZip = 98006;
      Vendor newVendor = new Vendor(vendorName, vendorDescription, vendorAddress, vendorAddress2, vendorCity, vendorState, vendorZip);

      string result = newVendor.VendorAddress2;

      Assert.AreEqual(vendorAddress2, result);
    }

    [TestMethod]
    public void GetVendorCity_ReturnsVendorCity_String()
    {
      string vendorName = "Test Vendor";
      string vendorDescription = "Test Description";
      string vendorAddress = "Test Address";
      string vendorAddress2 = "Test Address 2";
      string vendorCity = "Test City";
      string vendorState = "Test State";
      int vendorZip = 98006;
      Vendor newVendor = new Vendor(vendorName, vendorDescription, vendorAddress, vendorAddress2, vendorCity, vendorState, vendorZip);

      string result = newVendor.VendorCity;

      Assert.AreEqual(vendorCity, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      string vendorName1 = "Flying Fish Company";
      string vendorDescription1 = "Flying Fish Company Description";
      string vendorAddress = "Flying Fish Address";
      string vendorAddress2 = "Flying Fish Address 2";
      string vendorCity = "Flying Fish City";
      string vendorState = "Flying Fish State";
      int vendorZip = 98006;
      string vendorName2 = "Vivienne";
      string vendorDescription2 = "Vivienne Description";
      string vendorAddressAlt = "Vivienne Address";
      string vendorAddressAlt2 = "Vivienne Address 2";
      string vendorCity2 = "Vivienne City";
      string vendorState2 = "Vivienne State";
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
      string vendorName1 = "Flying Fish Company";
      string vendorDescription1 = "Flying Fish Company Description";
      string vendorAddress = "Flying Fish Address";
      string vendorAddress2 = "Flying Fish Address 2";
      string vendorCity = "Flying Fish City";
      string vendorState = "Flying Fish State";
      int vendorZip = 98006;
      string vendorName2 = "Vivienne";
      string vendorDescription2 = "Vivienne Description";
      string vendorAddressAlt = "Vivienne Address";
      string vendorAddressAlt2 = "Vivienne Address 2";
      string vendorCity2 = "Vivienne City";
      string vendorState2 = "Vivienne State";
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
      string vendorName = "Flying Fish Company";
      string vendorDescription = "Flying Fish Company Description";
      string vendorAddress = "Flying Fish Address";
      string vendorAddress2 = "Flying Fish Address 2";
      string vendorCity = "Flying Fish City";
      string vendorState = "Flying Fish State";
      int vendorZip = 98006;
      string orderTitle = "Flying Fish Order Title";
      string orderPlacedBy = "Name of Orderer";
      string orderDescription = "Description of Order";
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