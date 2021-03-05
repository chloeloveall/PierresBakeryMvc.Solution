// using System.Collections.Generic;

namespace PierresBakeryMvc.Models
{
  public class Vendor
  {
    public string VendorName { get; }
    // VendorDescription 
    // orderList

    public Vendor(string vendorName)
    {
      VendorName = vendorName;
    }

  }
}