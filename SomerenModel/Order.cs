using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Order
    {
        public int OrderId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DrinkName { get; set; }
        public string DrinkType { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }
        public DateTime DateTime { get; set; }
        public int Sales { get; set; }
    }
}
