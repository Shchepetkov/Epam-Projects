using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIZZA_TIME
{
    class Order
    {
        public Order(Pizza pizza)
        {
            Pizza = pizza;
        }

        public int Number { get; }

        public Pizza Pizza { get; }

    }
}
