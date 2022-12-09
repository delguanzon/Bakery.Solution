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
      return (LoafQty * 5) - GetDiscount();;
    }

    public int GetDiscount() {
      return 5 * (LoafQty/3);
    }
  }
}