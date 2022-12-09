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

      Console.ForegroundColor = ConsoleColor.Black;
      Console.BackgroundColor = ConsoleColor.DarkYellow;
      Console.Write("Welcome to Pierre's Bakery!");
      Console.ResetColor();
      Console.WriteLine("\n We have [Bread] and [Pastry]. Which one would you like to order?");
      Selection();

    }

    public static void Selection()
    {
      Console.WriteLine("Plese press [1] for Bread or [2] for Pastry:");
      ConsoleKeyInfo  x = Console.ReadKey();
      Bread bread = new Bread();
      Pastry pastry = new Pastry();

      switch(x.KeyChar)
      {
        case '1': 
        {     
          Console.Clear();     
          ViewCart(bread, pastry);
          Console.WriteLine();
          Console.WriteLine("How many loaves of bread would you like to order?");
          int userInput = int.Parse(Console.ReadLine());
          if(userInput != 0) {
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
          int userInput = int.Parse(Console.ReadLine());
          if(userInput != 0) {
            pastry.Qty = userInput;
            Console.WriteLine("That will be ${0} for {1} {2}.", pastry.GetTotalCost(), pastry.Qty, pastry.Qty > 1 ? "pastries":"pastry");
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
          Selection();
          break;
        }
      }
    }

    public static void ViewCart(Bread bread, Pastry pastry) {
      Console.WriteLine("");
      Console.ForegroundColor = ConsoleColor.Black;
      Console.BackgroundColor = ConsoleColor.Cyan;      
      Console.Write("[Your Cart]");
      Console.ResetColor();
      Console.WriteLine("");
      Console.WriteLine("Bread:  {0}   Current Cost: ${1}", bread.LoafQty, bread.GetCost());
      Console.WriteLine("Pastry: {0}   Current Cost: ${1}", pastry.Qty, pastry.GetTotalCost());
    }

  }
}