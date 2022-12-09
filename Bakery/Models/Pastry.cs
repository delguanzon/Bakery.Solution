using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bakery.Models
{
  public class Pastry
  {
    public int Qty { get; set; }

    public Pastry()
    {
      Qty = 0;
    }

    public Pastry(int userInput)
    {
      Qty = userInput;
    }

    

    public int GetNormalPrice(int qty)
    {
      return qty * 2;
    }

    public int GetDiscountPrice()
    {
      return (Qty / 3) * 5;
    }

    public int GetTotalCost()
    {
      return GetDiscountPrice() + GetNormalPrice(Qty%3);
    }
  }
}