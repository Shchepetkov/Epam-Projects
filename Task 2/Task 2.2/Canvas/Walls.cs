using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using game.Abstract;

namespace game.Canvas
{
    public class Walls
    {
         List<GameObj> wallList;
         public Walls(int mapWidth, int mapHeight)
        {
            wallList = new List<GameObj>();

            //Отрисовка рамочки
            HorizontalLine upLine = new HorizontalLine(0, mapWidth - 2, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, mapWidth - 2, mapHeight - 1, '+');
            VerticalLine leftLine = new VerticalLine(0, mapHeight - 1, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, mapHeight - 1, mapWidth - 2, '+');

            wallList.Add(upLine);
            wallList.Add(downLine);
            wallList.Add(leftLine);
            wallList.Add(rightLine);
        }

        public void Draw()
        {
            foreach (var wall in wallList)
            {
                wall.Draw();
            }
        }
    }
}
