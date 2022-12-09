using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Threading.Tasks;
using Bakery.Models;

namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      Console.Clear();
      Console.ForegroundColor = ConsoleColor.Black;
      Console.BackgroundColor = ConsoleColor.DarkYellow;
      Console.Write(" Welcome to Pierre's Bakery! ");
      Console.ResetColor();
      Console.WriteLine("\nWe have [Bread] and [Pastry]. Which one would you like to order?");      
      Bread bread = new Bread();
      Pastry pastry = new Pastry();
      Selection(bread, pastry);

    }

    public static void Selection(Bread bread, Pastry pastry)
    {
      int userInput;

      Console.WriteLine("\nPlease press [1] for Bread or [2] for Pastry:");
      ConsoleKeyInfo  x = Console.ReadKey();
      switch(x.KeyChar)
      {
        case '1': 
        {     
          Console.Clear();     
          ViewCart(bread, pastry);
          Console.WriteLine();
          Console.WriteLine("How many loaves of bread would you like to order?");
          

          while(!int.TryParse(Console.ReadLine(), out userInput))
          {
            Console.WriteLine("Please enter a valid number");
            Console.WriteLine("How many loaves of bread would you like to order?");
          }

          if(userInput > 0) {
            bread.LoafQty = userInput;
            Console.Clear(); 
            Console.WriteLine("That will be ${0} for {1} {2} of bread.", bread.GetCost(), bread.LoafQty, bread.LoafQty > 1 ? "loaves":"loaf");
            ViewCart(bread, pastry);
          }
          else {
            Console.WriteLine("Cancelling Order.");
            Main();
          }
          break;
        }
        case '2': 
        {
          Console.Clear();
          ViewCart(bread, pastry);
          Console.WriteLine();
          Console.WriteLine("How many pastries would you like to order?");
          while(!int.TryParse(Console.ReadLine(), out userInput))
          {
            Console.WriteLine("Please enter a valid number");
            Console.WriteLine("How many pastries would you like to order?");
          }
          if(userInput > 0) {
            pastry.Qty = userInput;
            Console.Clear(); 
            Console.WriteLine("That will be ${0} for {1} {2}.", pastry.GetTotalCost(), pastry.Qty, pastry.Qty > 1 ? "pastries":"pastry");
            ViewCart(bread, pastry);
          }
          else {
            Console.WriteLine("Cancelling Order.");
            Main();
          }
          break;
        }
        default:
        {
          Console.Clear();
          ViewCart(bread, pastry);
          Console.WriteLine("You have entered an invalid selection.");
          Selection(bread,pastry);
          break;
        }
      }

      Console.WriteLine("Press [1] to Update your order or any key to proceed with Checkout");
      char option = Console.ReadKey().KeyChar;
      switch (option) {
        case '1': {
          Selection(bread,pastry);
          break;
        }
        default:
          Checkout(bread, pastry);
          break;
      }
    }

    public static void ViewCart(Bread bread, Pastry pastry) {
      
      Console.Clear();

      Console.ForegroundColor = ConsoleColor.Black;
      Console.BackgroundColor = ConsoleColor.DarkYellow;
      Console.Write(" Welcome to Pierre's Bakery! ");
      Console.ResetColor();
      Console.WriteLine("");
      Console.ForegroundColor = ConsoleColor.Black;
      Console.BackgroundColor = ConsoleColor.Cyan;      
      Console.Write("[Your Cart]");
      Console.ResetColor();
      Console.WriteLine("------------------");
      Console.WriteLine("    Bread:  {0}   Cost: ${1}", bread.LoafQty, bread.GetCost());
      Console.WriteLine("    Pastry: {0}   Cost: ${1}", pastry.Qty, pastry.GetTotalCost());
      Console.WriteLine("-----------------------------");
    }

    public static void Checkout(Bread bread, Pastry pastry) {
      Console.Clear();
      ViewCart(bread, pastry);
      Console.Write("\nYour Total is: ");
      Console.ForegroundColor = ConsoleColor.White;
      Console.BackgroundColor = ConsoleColor.DarkGreen;
      Console.WriteLine("  ${0}  ", bread.GetCost() + pastry.GetTotalCost());
      Console.ResetColor();
      Console.WriteLine("\nThank You for your Order! Have an Amazing Day!");
      Environment.Exit(0);
    }

    

  }
}