using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Figure
    {
        public int x;
        public int y;
        public int[,] matrix;
        public int sizeMatrix;

        int mapWidth = 8;
        int mapHeight = 16;

        public Figure(int _x, int _y)
        {
            x = _x;
            y = _y;
            matrix = new int[3,3]
            {
                { 0, 1, 0},
                { 0, 1, 1},
                { 0, 0, 1},
            };
            sizeMatrix = 3;
        }

        public void MoveDown() 
        {
            if (y < mapHeight - sizeMatrix)
                y++;
        }
            

        public void MoveRight()
        {
            if (x < mapWidth - sizeMatrix)
                x++;
        }
        public void MoveLeft()
        {
            if (x > 0)
                x--;
        }
    }
}
