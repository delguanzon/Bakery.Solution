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
    }
}