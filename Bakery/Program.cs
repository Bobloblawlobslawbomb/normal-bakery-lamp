using System;
using Bakery.Models;

public class Program
{
  public static void Main()
  {
    Console.WriteLine("Hello, and welcome to Giancarlo's Bakery!");
    Console.WriteLine("We offer a fine selection of Bread and Pastries.");
    Console.WriteLine("Bread is $5 per loaf but if you LOVE bread we have a deal for you: Buy 2, and get 1 free.");
    Console.WriteLine("Pastries are $2 each or 3 for $5.");
    Console.WriteLine("please enter 'Bread' or 'Pastry' if you would like to purchase either bread or pastry respectively.");

    string userOrder = Console.ReadLine();
    string userOrderLower = userOrder.ToLower();

    bool breadInput = userOrderLower == "bread";
    bool pastryInput = userOrderLower == "pastry";

    if (breadInput)
    {
      Console.WriteLine("How many loaves of bread would you like?");
    }
    else if (pastryInput)
    {
      Console.WriteLine("How many pastries would you like?");
    }

  }
}