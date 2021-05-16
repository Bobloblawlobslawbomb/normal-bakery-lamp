using System;
using System.Collections.Generic; //if I want to list out the order
using Bakery.Models;
//dont for get to do the outputtype.exe
public class Program
{
  public static void Main()
  {
    public static WelcomeGreeting()
    {
    Console.WriteLine("Hello, and welcome to Giancarlo's Bakery!");
    Console.WriteLine("We offer a fine selection of Bread and Pastries.");
    Console.WriteLine("Bread is $5 per loaf but if you LOVE bread we have a deal for you: Buy 2, and get 1 free.");
    Console.WriteLine("Pastries are $2 each or 3 for $5.");
    Console.WriteLine("please enter: 'Bread' or 'Pastry' if you would like to purchase either bread or pastry respectively.");
    Console.WriteLine("Or simply type 'Exit' to exit the order taking process.");
    }

    public static ContinueOrder()
    {
      Console.WriteLine("Great choice!");
      Console.WriteLine("Would you like to order some more baked goods?");
      Console.WriteLine("please enter: 'Bread' or 'Pastry' to order more. Or if you are done enter: 'Exit'.");
    }

    public static GoodBye()
    {
      Console.WriteLine("Thanks for visiting Giancarlo's Bakery!");
    }
    
    WelcomeGreeting();
    string userOrder = Console.ReadLine();
    string userOrderLower = userOrder.ToLower();

    bool breadInput = userOrderLower == "bread";
    bool pastryInput = userOrderLower == "pastry";
    bool exitInput = userOrderLower == "exit";

    if (breadInput)
    {
      Console.WriteLine("How many loaves of bread would you like?");
      string userQuantityString = Console.ReadLine();
      int userQuantityInt = Convert.ToInt32(userQuantityString);
      Bread breadOrder = new Bread(userQuantityInt);
      ContinueOrder();
    }
    else if (pastryInput)
    {
      Console.WriteLine("How many pastries would you like?");
      string userQuantityString = Console.ReadLine();
      int userQuantityInt = Convert.ToInt32(userQuantityString);
      Pastry pastryOrder = new Pastry(userQuantityInt);
      ContinueOrder();
    }

  }
}