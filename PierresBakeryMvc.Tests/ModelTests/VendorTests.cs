using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakeryMvc.Models;
// using System.Collections.Generic;
// using System;

namespace PierresBakeryMvc.Tests
{

  [TestClass]
  public class VendorTests
  {
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor();
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

  }
}