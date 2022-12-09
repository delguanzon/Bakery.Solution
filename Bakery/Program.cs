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
      Console.WriteLine("We have [Bread] and [Pastry]. Which one would you like to order?");
      Console.WriteLine("Press [1] for Bread or [2] for Pastry:");
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
          Console.WriteLine("How many loaves of bread would you like to order?");
          string userInput = Console.ReadLine();
          bread.LoafQty = int.Parse(userInput);
          break;
        }
        case '2': 
        {
          Console.WriteLine("How many pastries would you like to order?");
          string userInput = Console.ReadLine();
          pastry.Qty = int.Parse(userInput);
          break;
        }
        default:
        {
          Console.WriteLine("You have entered an invalid selection.");
          Selection();
          break;
        }
      }
    }
  }
}