using System;
using System.Collections.Generic;

namespace PierresBakeryMvc.Models
{
  public class Order
  {
    public string OrderTitle { get; set; }
    public string OrderPlacedBy { get; set; }
    public string OrderDescription { get; set; }
    public int OrderPrice { get; set; }
    public int Id { get; }
    public DateTime Date { get; private set; }

    // public bool Paid { get; set; }
    private static List<Order> _instances = new List<Order> { };

    public Order(string orderTitle, string orderPlacedBy, string orderDescription, int orderPrice)
    {
      OrderTitle = orderTitle.ToUpper();
      OrderPlacedBy = orderPlacedBy.ToUpper();
      OrderDescription = orderDescription.ToUpper();
      OrderPrice = orderPrice;
      _instances.Add(this);
      Id = _instances.Count;
      Date = DateTime.Today;
      // Paid = false;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static Order Find(int searchId)
    {
      return _instances[searchId-1];
    }

  }
}