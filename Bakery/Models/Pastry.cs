using System;
using System.Collections.Generic;


  namespace Bakery.Models
  {
    public class Pastry
    {
      private int _price;
      public int Quantity { get; set; }

      public Pastry(int quantity)
      {
        _price = 2;
        Quantity = quantity;
      }

      // public int GetPrice()
      // {
      //   if (Quantity == 2)
      //   {
      //     _price = 3;
      //     return _price;
      //   }
      //   else
      //   {
      //     return _price;
      //   }
      // }

      public int GetTotalPrice();
      {
        TotalPrice -= (Quantity/3);
      }
    }
  }
