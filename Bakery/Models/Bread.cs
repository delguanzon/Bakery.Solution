namespace Bakery.Models
{
  public class Bread
  {

    public int LoafQty {get; set;}
    public Bread(int userInput) {
      LoafQty = userInput;
    }

    public int GetCost() {
      int total = LoafQty * 5;
      return total;
    }

    public int GetDiscount() {
      int discount = 5 * (LoafQty/3);
      return discount;
    }
  }
}