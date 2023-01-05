using System.Drawing.Design;

namespace WinFormsApp1
{
    public partial class Tetris : Form
    {
        int sizeSquare;

        int mapWidth;
        int mapHeight;

        int borderX;
        int borderY;

        int[,] map;

        Figure currentFigure;

        public Tetris()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            sizeSquare = 25;

            mapWidth = 8;
            mapHeight = 16;

            borderX = 50;
            borderY = 20;
            
            map = new int[mapWidth,   mapHeight];

            currentFigure = new Figure(3,0);

            this.KeyUp += new KeyEventHandler(keyFunc);

            timer1.Interval = 100;
            timer1.Tick += new EventHandler(update);
            timer1.Start();


            Invalidate();
        }

        private void keyFunc(object? sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right:
                    ResetArea();
                    currentFigure.MoveRight();
                    Merge();
                    Invalidate();
                    break;
                case Keys.Left:
                    ResetArea();

                    currentFigure.MoveLeft();
                    Merge();
                    Invalidate();
                    break;
            }
        }

        private void update(object? sender, EventArgs e)
        {
            ResetArea();
            if (!Collide())
            {
                currentFigure.MoveDown();

            }
            else
            {
                Merge();
                currentFigure = new Figure(3, 0);
            }
            Merge();
            Invalidate();
        }

        public void Merge()
        {
            for (int i = currentFigure.x; i < currentFigure.x + currentFigure.sizeMatrix; i++)
            {
                for(int j = currentFigure.y; j < currentFigure.y + currentFigure.sizeMatrix; j++)
                {
                    if (currentFigure.matrix[i - currentFigure.x, j - currentFigure.y] !=0)
                    map[i, j] = currentFigure.matrix[i - currentFigure.x, j - currentFigure.y];
                }
            }
        }
        public void ResetArea()
        {
            for (int i = currentFigure.x; i < currentFigure.x + currentFigure.sizeMatrix; i++)
            {
                for (int j = currentFigure.y; j < currentFigure.y + currentFigure.sizeMatrix; j++)
                {
                   if (i >= 0 && j >= 0 && i < mapWidth && j < mapHeight)
                        map[i, j] = 0;
                }
            }
        }
        public bool Collide()
        {
            for (int i = currentFigure.x ; i < currentFigure.x + currentFigure.sizeMatrix; i++)
            {
                for (int j = currentFigure.y + currentFigure.sizeMatrix - 1; j >= currentFigure.y + currentFigure.x; j-- )
                {
                    if (currentFigure.matrix[i - currentFigure.x, j - currentFigure.y] != 0)
                    {
                        if (j + 1 == mapHeight)
                            return true;
                        if (map[i, j] != 0)
                            return true;
                    }
                }
            }
            return false;
        }

        public void DrawMap(Graphics e)
        {
            for (int i = 0; i < mapWidth; i++)
            {
                for (int j = 0; j <  mapHeight ; j++)
                {
                    if (map[i, j] == 1)
                    {
                        e.FillRectangle(Brushes.Red, new Rectangle(borderX + i * sizeSquare, borderY + j * sizeSquare, sizeSquare - 1, sizeSquare - 1));
                    }
                }
            }
        }
        public void DrawGrid(Graphics g)
        {
            for (int i = 0; i <= mapHeight; i++)
            {
                g.DrawLine(Pens.Black, new Point(borderX, borderY + i * sizeSquare), new Point(borderX + mapWidth * sizeSquare, borderY + i * sizeSquare));
            }
            for (int i = 0; i <= mapWidth ; i++)
            {
                g.DrawLine(Pens.Black, new Point(borderX + i * sizeSquare, borderY), new Point(borderX + i * sizeSquare, borderY + mapHeight * sizeSquare));

            }
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            DrawGrid(e.Graphics);
            DrawMap(e.Graphics);
        }
    }
}