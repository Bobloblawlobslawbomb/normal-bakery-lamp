namespace Bakery.Models
{
  public class Bread
  {
    private int _price;
    public int Quantity { get; set; }
    public int TotalPrice { get; set; }

    public Bread(int quantity)
    {
      _price = 5;
      Quantity = quantity;
      TotalPrice = 5;
    }

    public int GetPrice()
    {
      return TotalPrice = Quantity * _price;
    }

    public int BreadDeal()
    {
      if (Quantity > 1)
      {
        return Quantity += (Quantity / 2);
      }
      return Quantity;
    }
  }
}