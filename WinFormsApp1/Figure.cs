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


        public int[,] tetr1 = new int[4, 4]{
            {0,0,1,0  },
            {0,0,1,0  },
            {0,0,1,0  },
            {0,0,1,0  },
        };

        public int[,] tetr2 = new int[3, 3]{
            {0,2,0  },
            {0,2,2 },
            {0,0,2 },
        };

        public int[,] tetr3 = new int[3, 3]{
            {0,0,0  },
            {3,3,3 },
            {0,3,0 },
        };

        public int[,] tetr4 = new int[3, 3]{
            { 4,0,0  },
            {4,0,0 },
            {4,4,0 },
        };
        public int[,] tetr5 = new int[2, 2]{
            { 5,5  },
            {5,5 },
        };
        public Figure(int x, int y)
        {
            this.x = x;
            this.y = y;
            matrix = GenerateMatrix();
            sizeMatrix = (int)Math.Sqrt(matrix.Length);
        }
        public int[,] GenerateMatrix()
        {
            int[,] matrix = tetr1;
            Random r = new Random();
            switch (r.Next(1, 6))
            {
                case 1:
                    matrix = tetr1;
                    break;
                case 2:
                    matrix = tetr2;
                    break;
                case 3:
                    matrix = tetr3;
                    break;
                case 4:
                    matrix = tetr4;
                    break;
                case 5:
                    matrix = tetr5;
                    break;
            }
            return matrix;
        }



        public void MoveDown() => y++;
        public void MoveRight() => x++;
        public void MoveLeft() => x--;
        public void Rorate()
        {
            int[,] tempMatrix = new int[sizeMatrix, sizeMatrix];
            for (int i = 0; i < sizeMatrix; i++)
            {
                for (int j = 0; j < sizeMatrix; j++)
                {
                    tempMatrix[i, j] = matrix[j, (sizeMatrix - 1) - i];
                }
            }
            matrix = tempMatrix;
        }
    }
}
