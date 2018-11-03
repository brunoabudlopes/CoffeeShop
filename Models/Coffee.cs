using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCoffeeShop.Models
{
    public class Coffee
    {
        public int CoffeeID { get; set; }
        public string CoffeeName { get; set; }
        public DateTime AvailableDate { get; set; }
        public decimal Price { get; set; }
    }
}
