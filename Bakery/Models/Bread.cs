using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
    private int _price;
    public int Quantity { get; set; }

    public Bread(int quantity)
    {
      _price = 5;
      Quantity = quantity;
    }

    public int GetPrice()
    {
      return _price;
    }
  }
  public class Pastry
  {
    private int _price;
    public int Quantity { get; set; }

    public Pastry(int quantity)
    {
      _price = 2;
      Quantity = quantity;
    }

    public int GetPrice()
    {
      return _price;
    }

  }
}

/*

public int GetPrice()
{
  if (Bread.Quantity == 1)
  {
    return _price;
  }
  else if (Bread.Quantity == 2)
  {
    _price = _price * Quantity;
    Quantity = 3;
    return _price;
  }
  else if (Bread.Quantity % 2 == 0)
  {
    _price = _price * Quantity;
    Quantity = Quantity + (Quantity/2);
    return _price;
  }
  else
  {
    _price = _price * Quantity;
    Quantity = Quantity + ((Quantity-1)/2);
    return _price;
  }
}

public int GetPrice()
{
  if (Pastry.Quantity == 1)
  {
    return _price;
  }
  else if (Pastry.Quantity == 2)
  {
    _price = _price * Quantity;
    return _price;
  }
  else if (Pastry.Quantity % 3 == 0)
  {
    _price = (Quantity/3)*5;
    return _price;
  }
  else if (Pastry.Quantity == 4 || Pastry.Quantity == 7 || Pastry.Quantity == 10 || Pastry.Quantity == 13)
  {
    _price = ((Quantity-1)/3) * 5) + _price;
    return _price;
  }
  else if (Pastry.Quantity == 5 || Pastry.Quantity == 8 || Pastry.Quantity == 11 || Pastry.Quantity == 14)
  {
    _price = ((Quantity-2)/3) * 5 + (2 * _price));
    return _price;
  }
  else
  {
    _price = 1000000;
    return _price;
  }
}

*/