using System;
using System.Collections.Generic;

namespace PierresBakeryMvc.Models
{
  public class Order
  {
    public string VendorName { get; set; }
    // public string Description { get; set; }
    // // public DateTime Date { get; }
    // public int OrderPrice { get; set; }
    // public int Id { get; }
    // private static List<Order> _instances = new List<Order> { };


    public Order(string vendorName)
    {
      VendorName = vendorName;
      // Description = description;
      // OrderPrice = orderPrice;
    }

  }
}