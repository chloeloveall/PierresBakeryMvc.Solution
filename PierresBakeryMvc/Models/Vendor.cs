using System.Collections.Generic;

namespace PierresBakeryMvc.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> {};
    public string VendorName { get; set; }
    public string VendorDescription { get; set; } 
    public string VendorAddress { get; set; }
    public string VendorAddress2 { get; set; }
    public string VendorCity { get; set; }
    public string VendorState { get; set; }
    public int VendorZip { get; set; }

    public int Id { get; }
    public List<Order> Orders { get; set; }

    public Vendor(string vendorName, string vendorDescription, string vendorAddress, string vendorAddress2, string vendorCity, string vendorState, int vendorZip)
    {
      VendorName = vendorName;
      VendorDescription = vendorDescription;
      // VendorAddress = vendorAddress;
      // VendorAddress2 = vendorAddress2;
      // VendorCity = vendorCity;
      // VendorState = vendorState;
      // VendorZip = vendorZip;
      _instances.Add(this);
      Id = _instances.Count;
      Orders = new List<Order>{};
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Vendor> GetAll()
    {
      return _instances;
    }

    public static Vendor Find(int searchId)
    {
      return _instances[searchId-1];
    }

    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }

  }
}