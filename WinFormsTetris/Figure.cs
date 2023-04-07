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


        public static List<int[,]> listTypeFigures = FillingOfList();

        public Figure(int x, int y)
        {
            this.x = x;
            this.y = y;
            matrix = GenerateMatrix();
            sizeMatrix = (int)Math.Sqrt(matrix.Length); ;
        }

        private static List<int[,]> FillingOfList()
        {
            listTypeFigures = new List<int[,]>();

            int[,] tetr1 = new int[4, 4]{
                { 0,0,1,0 },
                { 0,0,1,0 },
                { 0,0,1,0 },
                { 0,0,1,0 },
            };

            int[,] tetr2 = new int[3, 3]{
                { 0,2,0 },
                { 0,2,2 },
                { 0,0,2 },
            };

            int[,] tetr3 = new int[3, 3]{
                { 0,0,0 },
                { 3,3,3 },
                { 0,3,0 },
            };

            int[,] tetr4 = new int[3, 3]{
                { 4,0,0 },
                { 4,0,0 },
                { 4,4,0 },
            };
            int[,] tetr5 = new int[2, 2]{
                { 5,5 },
                { 5,5 },
            };

            listTypeFigures.Add(tetr1);
            listTypeFigures.Add(tetr2);
            listTypeFigures.Add(tetr3);
            listTypeFigures.Add(tetr4);
            listTypeFigures.Add(tetr5);

            return listTypeFigures;
        }
        public int[,] GenerateMatrix()
        {
            Random r = new Random();
            int[,] _matrix; ;
            return _matrix = listTypeFigures[r.Next(0, listTypeFigures.Count)];
        }



        public void MoveDown() => y++;
        public void MoveRight() => x++;
        public void MoveLeft() => x--;
        public void Rorate()
        {
            int[,] tempMatrix = new int[sizeMatrix, sizeMatrix];
            for (int i = 0; i < sizeMatrix; i++)
                for (int j = 0; j < sizeMatrix; j++)
                    tempMatrix[i, j] = matrix[j, (sizeMatrix - 1) - i];

            matrix = tempMatrix;
        }
    }
}
