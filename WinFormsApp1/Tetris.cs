using System.Drawing.Design;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection.Emit;
using System.Xml.Serialization;
using Microsoft.VisualBasic;

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
        int linesRemoved;
        int score;
        Figure currentFigure;

        int fallingSpeedNormal;
        int fallingSpeedFast;
        int fallingSpeedNormalLimit;
        int fallingSpeedNormalStepIncrease;
        public Tetris()
        {
            InitializeComponent();
            this.KeyUp += new KeyEventHandler(KeyFunc);

        }

        public void StartGame()
        {

            sizeSquare = 25;
            mapWidth = int.Parse(sizeFieldXTextBox.Text);
            mapHeight = int.Parse(sizeFieldYTextBox.Text);

            borderX = 200;
            borderY = 20;
            map = new int[mapWidth, mapHeight];
            linesRemoved = 0;
            score = 0;

            currentFigure = new Figure(mapWidth/2,0);


            StartTime();
            UpdateLabels();
            Invalidate();
        }
        public void StopGame()
        {
            ClearMap();
            timerFalling.Tick -= new EventHandler(Update);
            timerFalling.Stop();
        }

        public void StartTime()
        {
            fallingSpeedNormal = 500;
            fallingSpeedNormalLimit = 100;
            fallingSpeedNormalStepIncrease = 10;
            fallingSpeedFast = 40;

            timerFalling.Interval = fallingSpeedNormal;
            timerFalling.Tick += new EventHandler(Update);
            timerFalling.Start();

        }

        private void KeyFunc(object? sender, KeyEventArgs key)
        {
            ResetArea();

            switch (key.KeyCode)
            {
                case Keys.Right:
                    if (!Collide(key.KeyCode))
                        currentFigure.MoveRight();
                    break;
                case Keys.Left:
                    if (!Collide(key.KeyCode))
                        currentFigure.MoveLeft();
                    break;
                case Keys.Up:
                    if (!Collide(key.KeyCode))
                        currentFigure.Rorate();
                    break;
                case Keys.Down:
                    timerFalling.Interval = fallingSpeedFast;
                    break;
            }
            Merge();
            Invalidate();
        }

        private void Update(object? sender, EventArgs e)
        {
            ResetArea(); 
            if (!Collide())
                currentFigure.MoveDown();
            else
            {
                timerFalling.Interval = fallingSpeedNormal;
                Merge();
                SliceMap();
                currentFigure = new Figure(mapWidth / 2, 0);
                if (Collide())
                {
                    StopGame();
                    StartGame();
                }
            }
            Merge();
            Invalidate();
        }
        public void ClearMap()
        {
            for (int i = 0; i < mapWidth; i++)
                for (int j = 0; j < mapHeight; j++)
                    map[i, j] = 0;
        }



        public void Merge()
        {
            for (int i = currentFigure.x; i < currentFigure.x + currentFigure.sizeMatrix; i++)
                for (int j = currentFigure.y; j < currentFigure.y + currentFigure.sizeMatrix; j++)
                   if (currentFigure.matrix[ j - currentFigure.y, i - currentFigure.x] != 0)
                        map[i, j] = currentFigure.matrix[j - currentFigure.y,i - currentFigure.x];
        }
        public void ResetArea()
        {
            for (int i = currentFigure.x; i < currentFigure.x + currentFigure.sizeMatrix; i++)
                for (int j = currentFigure.y; j < currentFigure.y + currentFigure.sizeMatrix; j++)
                   if (i >= 0 && j >= 0 && i < mapWidth && j < mapHeight)
                        if (currentFigure.matrix[j - currentFigure.y, i - currentFigure.x] != 0)
                            map[i, j] = 0;
        }
        public bool Collide()
        {
            for (int i = currentFigure.x; i < currentFigure.x + currentFigure.sizeMatrix; i++)
                for (int j = currentFigure.y + currentFigure.sizeMatrix - 1; j >= currentFigure.y; j--) 
                    if (currentFigure.matrix[j - currentFigure.y, i - currentFigure.x] != 0)
                    {
                        if (j + 1 == mapHeight)
                            return true;

                        if (map[i, j+1] != 0)
                            return true;
                    }
                    
            return false;
        }

        public bool Collide(Keys keyCode)
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

        public void SliceMap()
        {
            int curLinesRemoved = 0;

            for (int i = 0, count = 0; i < mapHeight; i++, count = 0)
            {
                for (int j = 0; j < mapWidth; j++)
                {
                    if (map[j,i] != 0)
                        count++;
                }
                if (count == mapWidth)
                {
                    curLinesRemoved++;

                    for (int o = i; o > 0; o--)
                    {
                        for (int k = 0; k < mapWidth; k++)
                        {
                            map[k,o] = map[k,o-1];
                        }
                    }
                }
            }

            for (int i = 1; i <= curLinesRemoved; i++)
            {
                score += 10 * i; 
            }
            linesRemoved += curLinesRemoved;


            IncreaseSpeed();

            UpdateLabels();
        }
        public void IncreaseSpeed() 
        {
            if (fallingSpeedNormal > fallingSpeedNormalLimit)
                fallingSpeedNormal -= fallingSpeedNormalStepIncrease;
        }

        public void UpdateLabels()
        {
            scoreLabel.Text = $"Score: {score}";
            linesLabel.Text = $"Lines: {linesRemoved}";
        }

        public void DrawMap(Graphics graphics)
        {
            for (int i = 0; i < mapWidth; i++)
                for (int j = 0; j < mapHeight; j++) 
                    if (map[i, j] != 0)
                        graphics.FillRectangle(GetBrush(map[i, j]), new Rectangle(borderX + i * sizeSquare, borderY + j * sizeSquare, sizeSquare - 1, sizeSquare - 1));
        }
        public void DrawGrid(Graphics graphics)
        {
            for (int i = 0; i <= mapHeight; i++)
                graphics.DrawLine(Pens.Black, new Point(borderX, borderY + i * sizeSquare), new Point(borderX + mapWidth * sizeSquare, borderY + i * sizeSquare));

            for (int i = 0; i <= mapWidth ; i++)
                graphics.DrawLine(Pens.Black, new Point(borderX + i * sizeSquare, borderY), new Point(borderX + i * sizeSquare, borderY + mapHeight * sizeSquare));
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
           DrawGrid(e.Graphics);
            DrawMap(e.Graphics);
        }

        public Brush GetBrush(int code)
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


        private void SizeFieldXTextBox_KeyPress(object sender, KeyPressEventArgs e) =>
            IsNumber(e);

        private void SizeFieldYTextBox_KeyPress(object sender, KeyPressEventArgs e) =>
            IsNumber(e);
        private void IsNumber(KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
                e.Handled = true;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (CheckFieldSize())
            {
                ChangeStateStartAndStopButtons();
                StartGame();
            }
           
        }
        private bool CheckFieldSize()
        {
            int minSizeX = 15;
            int minSizeY = 20;

            if (int.Parse(sizeFieldXTextBox.Text) >= minSizeX && int.Parse(sizeFieldYTextBox.Text) >= minSizeY)
            {
                errorLabel.Visible = false;
                return true;
            }
            errorLabel.Visible = true;
            return false;
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            ChangeStateStartAndStopButtons();
            StopGame();
        }

        private void ChangeStateStartAndStopButtons()
        {
            stopButton.Enabled = !stopButton.Enabled;
            startButton.Enabled = !startButton.Enabled;
        }

        private void errorLabel_Click(object sender, EventArgs e)
        {

        }
    }
}