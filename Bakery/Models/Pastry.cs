using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bakery.Models
{
    public class Pastry
    {   
        public int Qty {get; set;}
        public Pastry(int userInput) {
            Qty = userInput;
        }

        public int GetNormalPrice() {
            return Qty * 2;
        }

        public int GetDiscountPrice() {
            return (Qty / 3 ) * 5;
        }
    }
}