using System;

namespace Epam.Task_2.Task_2_1.Task_2_1_2
{
    public abstract class Figure
    {
        protected string name;
        public override string ToString()
        {
            return name;
        }
        public void CreatedOk()
        {
            Console.WriteLine($"Фигура {name} успешно созданна!");
        }
    }
}