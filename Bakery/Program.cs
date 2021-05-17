using System;
using Bakery.Models;
public class Program
{
  public static void Main()
  {
    WelcomeGreeting();

    string userOrder = Console.ReadLine();
    string userOrderLower = userOrder.ToLower();

    bool breadInput = userOrderLower == "bread";
    bool pastryInput = userOrderLower == "pastry";
    bool exitInput = userOrderLower == "exit";

    if (breadInput)
    {
      Console.WriteLine("------------------");
      Console.WriteLine("How many loaves of bread would you like?");
      string userQuantityString = Console.ReadLine();
      int userQuantityInt = Convert.ToInt32(userQuantityString);
      Bread breadOrder = new Bread(userQuantityInt);
      breadOrder.GetPrice();
      breadOrder.BreadDeal();
      Console.WriteLine(breadOrder.Quantity + " loaves of bread will cost you $" + breadOrder.TotalPrice + ".");
      Console.WriteLine("------------------");
      Main();
    }
    else if (pastryInput)
    {
      Console.WriteLine("------------------");
      Console.WriteLine("How many pastries would you like?");
      string userQuantityString = Console.ReadLine();
      int userQuantityInt = Convert.ToInt32(userQuantityString);
      Pastry pastryOrder = new Pastry(userQuantityInt);
      pastryOrder.GetPrice();
      Console.WriteLine(pastryOrder.Quantity + " pastries will cost you $" + pastryOrder.TotalPrice + ".");
      Console.WriteLine("------------------");
      Main();
    }
    else if (exitInput)
    {
      Console.WriteLine("------------------");
      GoodBye();
    }
    else
    {
      Console.WriteLine("------------------------");
      Console.WriteLine("Oops! That is an invalid choice. Please exit the store and Return when you want some tasty baked goods.");
      Console.WriteLine("------------------------");
      Main();
    }
  }
  private static void WelcomeGreeting()
  {
    Console.WriteLine("------------------");
    Console.WriteLine("Hello, and welcome back to Giancarlo's Bakery!");
    Console.WriteLine("We offer a fine selection of Bread and Pastries.");
    Console.WriteLine("Bread is $5 per loaf but if you LOVE bread we have a deal for you: Buy 2, and get 1 free.");
    Console.WriteLine("(Please note: You must accept the extra loaves of bread offered in our 2 for 1 bread deal.)");
    Console.WriteLine("Pastries are $2 each or 3 for $5.");
    Console.WriteLine("Please enter; 'Bread' or 'Pastry' if you would like to purchase either bread or pastry respectively. Or if you are done enter the word 'Exit'.");
  }
  private static void GoodBye()
  {
    Console.WriteLine("Thanks for visiting Giancarlo's Bakery!");
  }
}