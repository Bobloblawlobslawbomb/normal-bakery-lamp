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