// using System.Collections.Generic;

namespace PierresBakeryMvc.Models
{
  public class Order
  {
    public string VendorName { get; set; }

    public Order(string vendorName)
    {
      VendorName = vendorName;
    }

  }
}