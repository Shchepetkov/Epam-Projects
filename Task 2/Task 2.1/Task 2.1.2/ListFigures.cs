using System;
using System.Collections.Generic;

namespace Epam.Task_2.Task_2_1.Task_2_1_2
{
    public class ListFigures
    {
        private List<Figure> list = new List<Figure>();
        public void ClearList()
        {
            list.Clear();
        }
        public List<Figure> GetList() => list;
        
        public void AddToList(Figure figure)
        {
            list.Add(figure);
        }
    }
}