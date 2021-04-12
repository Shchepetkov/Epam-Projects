using System;

namespace PIZZA_TIME
{
    class Program
    {
        static void Main(string[] args)
        {
            Action("Petro");
            Action("Vano");
            Action("Sergo");
        }

        private static void Action(string userName)
        {
            User user = new User() { Name = userName };
            RestorPizza r = new RestorPizza();

            r.OnCreated += (user) => Console.WriteLine($"Пицца для юзера {user.Name}");

            var order = r.CreatePizza("Peperoni", user);
        }
    }
}
