using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIZZA_TIME
{
    class RestorPizza
    {

        public event Action<User> OnCreated;
        public Order CreatePizza(string pizzaName, User user)
        {
            var order = new Order(new Pizza { Name = pizzaName, Price = 450 });

            OnCreated(user);
            
            return order;
        }
    }
}
