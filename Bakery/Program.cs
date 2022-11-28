using System;
using Bakery.Models;
public class Program
{
  public static void Main()
  {
    WelcomeGreeting();

    string userOrder = Console.ReadLine().ToLower();

    bool breadBool = userOrder == "bread";
    bool pastryBool = userOrder == "pastry";
    bool exitBool = userOrder == "exit";

    if (breadBool)
    {
      Console.WriteLine("------------------");
      Console.WriteLine("How many loaves of bread would you like?");
      string userQuantityString = Console.ReadLine();
      int userQuantityInt = Int32.Parse(userQuantityString);
      Bread breadOrder = new Bread(userQuantityInt);
      breadOrder.GetPrice();
      Console.WriteLine(breadOrder.Quantity + " loave(s) of bread will cost you $" + breadOrder.TotalPrice + ".");
      Console.WriteLine("------------------");
      Main();
    }
    else if (pastryBool)
    {
      Console.WriteLine("------------------");
      Console.WriteLine("How many pastries would you like?");
      string userQuantityString = Console.ReadLine();
      int userQuantityInt = Int32.Parse(userQuantityString);
      Pastry pastryOrder = new Pastry(userQuantityInt);
      pastryOrder.GetPrice();
      Console.WriteLine(pastryOrder.Quantity + " pastries will cost you $" + pastryOrder.TotalPrice + ".");
      Console.WriteLine("------------------");
      Main();
    }
    else if (exitBool)
    {
      Console.WriteLine("------------------");
      GoodBye();
    }
    else
    {
      Console.WriteLine("------------------------");
      Console.WriteLine("Oops! That is an invalid choice. Please grab another ticket and head to the back of the line.");
      Console.WriteLine("------------------------");
      Main();
    }
  }
  private static void WelcomeGreeting()
  {
    Console.WriteLine("------------------");
    Console.WriteLine("NEXT!!!");
    Console.WriteLine("Oh hello, and welcome back to Giancarlo's Bakery!");
    Console.WriteLine("We offer a fine selection of Bread and Pastries.");
    Console.WriteLine("Bread is $5 per loaf but if you LOVE bread we have a deal for you: Buy 2, and get 1 free.");
    Console.WriteLine("Pastries are $2 each or 3 for $5.");
    Console.WriteLine("What can I get ya?");
    Console.WriteLine("(Please enter; 'Bread' or 'Pastry' if you would like to purchase either bread or pastry respectively. Or if you are done enter the word 'Exit')");
  }
  private static void GoodBye()
  {
    Console.WriteLine("Thanks for visiting Giancarlo's Bakery!");
  }
}