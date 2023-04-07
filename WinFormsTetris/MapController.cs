using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    internal static class MapController
    {
        public static int sizeSquare;

        public static int mapWidth;
        public static int mapHeight;

        public static int borderX;
        public static int borderY;

        public static int[,] map;
        public static int linesRemoved;
        public static int score;
        public static Figure currentFigure;

        public static int fallingSpeedNormal;
        public static int fallingSpeedFast;
        public static int fallingSpeedNormalLimit;
        public static int fallingSpeedNormalStepIncrease;

        

        public static void ClearMap()
        {
            for (int i = 0; i < mapWidth; i++)
                for (int j = 0; j < mapHeight; j++)
                    map[i, j] = 0;
        }

        public static void Merge()
        {
            for (int i = currentFigure.x; i < currentFigure.x + currentFigure.sizeMatrix; i++)
                for (int j = currentFigure.y; j < currentFigure.y + currentFigure.sizeMatrix; j++)
                    if (currentFigure.matrix[j - currentFigure.y, i - currentFigure.x] != 0)
                        map[i, j] = currentFigure.matrix[j - currentFigure.y, i - currentFigure.x];
        }
        public static void ResetArea()
        {
            for (int i = currentFigure.x; i < currentFigure.x + currentFigure.sizeMatrix; i++)
                for (int j = currentFigure.y; j < currentFigure.y + currentFigure.sizeMatrix; j++)
                    if (i >= 0 && j >= 0 && i < mapWidth && j < mapHeight)
                        if (currentFigure.matrix[j - currentFigure.y, i - currentFigure.x] != 0)
                            map[i, j] = 0;
        }
        public static bool Collide()
        {
            for (int i = currentFigure.x; i < currentFigure.x + currentFigure.sizeMatrix; i++)
                for (int j = currentFigure.y + currentFigure.sizeMatrix - 1; j >= currentFigure.y; j--)
                    if (currentFigure.matrix[j - currentFigure.y, i - currentFigure.x] != 0)
                    {
                        if (j + 1 == mapHeight)
                            return true;

                        if (map[i, j + 1] != 0)
                            return true;
                    }
            return false;
        }

        public static bool Collide(Keys keyCode)
        {
            for (int i = currentFigure.x; i < currentFigure.x + currentFigure.sizeMatrix; i++)
                for (int j = currentFigure.y; j < currentFigure.y + currentFigure.sizeMatrix; j++)
                    try
                    {
                        if (currentFigure.matrix[j - currentFigure.y, i - currentFigure.x] != 0)
                        {
                            if (keyCode == Keys.Left && i == 0)
                                return true;

                            if (keyCode == Keys.Right && i == mapWidth - 1)
                                return true;
                        }
                        else if (keyCode == Keys.Up && (i < 0 || i >= mapWidth || map[i, j] != currentFigure.matrix[j - currentFigure.y, i - currentFigure.x]))
                        {
                            return true;
                        }
                    }
                    catch { }
            return false;
        }

        public static void SliceMap()
        {
            int curLinesRemoved = 0;

            for (int i = 0, count; i < mapHeight; i++, count = 0)
            {

                count = CountingFilledCells(i);
                
                if (count == mapWidth)
                {
                    curLinesRemoved++;

                    OffsetMapToEmptyLine(i);
                }
            }

           CountingScore(curLinesRemoved);
           IncreaseSpeed();

        }
        private static void OffsetMapToEmptyLine(int numberEpmtyLine)
        {
            for (int o = numberEpmtyLine; o > 0; o--)
            {
                for (int k = 0; k < mapWidth; k++)
                {
                    map[k, o] = map[k, o - 1];
                }

            }
        }
        private static int CountingFilledCells(int lineNumber)
        {
            int count = 0;
            for (int j = 0; j < mapWidth; j++)
            {
                if (map[j, lineNumber] != 0)
                    count++;
            }
            return count;
        }

        public static void DrawMap(Graphics graphics)
        {
            for (int i = 0; i < mapWidth; i++)
                for (int j = 0; j < mapHeight; j++)
                    if (map[i, j] != 0)
                        graphics.FillRectangle(GetBrush(map[i, j]), new Rectangle(borderX + i * sizeSquare, borderY + j * sizeSquare, sizeSquare - 1, sizeSquare - 1));
        }
        public static void DrawGrid(Graphics graphics)
        {
            for (int i = 0; i <= mapHeight; i++)
                graphics.DrawLine(Pens.Black, new Point(borderX, borderY + i * sizeSquare), new Point(borderX + mapWidth * sizeSquare, borderY + i * sizeSquare));

            for (int i = 0; i <= mapWidth; i++)
                graphics.DrawLine(Pens.Black, new Point(borderX + i * sizeSquare, borderY), new Point(borderX + i * sizeSquare, borderY + mapHeight * sizeSquare));
        }

        private static void CountingScore(int curLinesRemoved)
        {
            for (int i = 1; i <= curLinesRemoved; i++)
            {
                score += 10 * i;
            }
            linesRemoved += curLinesRemoved;
        }

        private static void IncreaseSpeed()
        {
            if (fallingSpeedNormal > fallingSpeedNormalLimit)
                fallingSpeedNormal -= fallingSpeedNormalStepIncrease;
        }

        private static Brush GetBrush(int code)
        {
            switch (code)
            {
                case 1: return Brushes.Red;
                case 2: return Brushes.Yellow;
                case 3: return Brushes.Green;
                case 4: return Brushes.Blue;
                case 5: return Brushes.Purple;
                default: return Brushes.Brown;
            }
        }
    }
    
}
