namespace Bakery.Models
{
  public class Pastry
  {
    private int _price;
    public int Quantity { get; set; }
    public int TotalPrice { get; set; }

    public Pastry(int quantity)
    {
      _price = 2;
      Quantity = quantity;
      TotalPrice = 0;
    }

    public int GetPrice()
    {
      if (Quantity <= 2)
      {
        return TotalPrice = Quantity * _price;
      }
      else
      {
        TotalPrice = Quantity * _price;
        return TotalPrice -= (Quantity / 3);
      }
    }
  }
}