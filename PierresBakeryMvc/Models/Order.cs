// using System;
using System.Collections.Generic;

namespace PierresBakeryMvc.Models
{
  public class Order
  {
    public string OrderPlacedBy { get; set; }
    public string OrderDescription { get; set; }
    public int OrderPrice { get; set; }
    public int Id { get; }
    private static List<Order> _instances = new List<Order> { };

    // // public DateTime Date { get; }


    public Order(string orderPlacedBy, string orderDescription, int orderPrice)
    {
      OrderPlacedBy = orderPlacedBy;
      OrderDescription = orderDescription;
      OrderPrice = orderPrice;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

  }
}