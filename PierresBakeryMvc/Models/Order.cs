using System;
using System.Collections.Generic;

namespace PierresBakeryMvc.Models
{
  public class Order
  {
    public string OrderPlacedBy { get; set; }
    public string OrderDescription { get; set; }
    // // public DateTime Date { get; }
    // public int OrderPrice { get; set; }
    // public int Id { get; }
    // private static List<Order> _instances = new List<Order> { };


    public Order(string orderPlacedBy, string orderDescription)
    {
      OrderPlacedBy = orderPlacedBy;
      OrderDescription = orderDescription;
      // OrderPrice = orderPrice;
    }

  }
}