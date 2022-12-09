namespace Bakery.Models
{
  public class Bread
  {

    public int LoafQty {get;}
    public Bread(int userInput) {
      LoafQty = userInput;
    }

    public int GetCost() {
      int total = LoafQty * 5;
      return total;
    }
  }
}