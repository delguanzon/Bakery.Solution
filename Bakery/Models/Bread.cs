namespace Bakery.Models
{
  public class Bread
  {

    public int LoafQty {get; set;}
    
    public Bread()
    {
      LoafQty = 0;
    }

    public Bread(int userInput) {
      LoafQty = userInput;
    }

    

    public int GetCost() {
      int total = (LoafQty * 5) - GetDiscount();
      return total;
    }

    public int GetDiscount() {
      int discount = 5 * (LoafQty/3);
      return discount;
    }
  }
}