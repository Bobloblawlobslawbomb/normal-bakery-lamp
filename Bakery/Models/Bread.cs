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
      if (Quantity >= 3)
      {
        TotalPrice = (Quantity * _price) - ((Quantity / 3) * _price);
      }
      else
      {
        TotalPrice = Quantity * _price;
      }
      return TotalPrice;
    }
  }
}