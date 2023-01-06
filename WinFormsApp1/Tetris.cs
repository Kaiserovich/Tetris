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
using System.Diagnostics;
using static System.Formats.Asn1.AsnWriter;

namespace WinFormsApp1
{
    public partial class Tetris : Form
    {
        
        public Tetris()
        {
            InitializeComponent();
            this.KeyUp += new KeyEventHandler(KeyFunc);

        }

        private void StartGame()
        {
            MapController.sizeSquare = 25;
            MapController.mapWidth = int.Parse(sizeFieldXTextBox.Text);
            MapController.mapHeight = int.Parse(sizeFieldYTextBox.Text);

            MapController.borderX = 200;
            MapController.borderY = 150;
            MapController.map = new int[MapController.mapWidth, MapController.mapHeight];
            MapController.linesRemoved = 0;
            MapController.score = 0;

            MapController.currentFigure = new Figure(MapController.mapWidth / 2, 0);

            MapController.fallingSpeedNormal = 500;
            MapController.fallingSpeedNormalLimit = 100;
            MapController.fallingSpeedNormalStepIncrease = 10;
            MapController.fallingSpeedFast = 40;

            StartTime();
            UpdateLabels();
            Invalidate();
        }
        private void StopGame()
        {
            MapController.ClearMap();
            StopTime();
        }

        private void StartTime()
        {
            timerFalling.Interval = MapController.fallingSpeedNormal;
            timerFalling.Tick += new EventHandler(Update);
            timerFalling.Start();
        }
        private void StopTime()
        {
            timerFalling.Tick -= new EventHandler(Update);
            timerFalling.Stop();
        }
        private void KeyFunc(object? sender, KeyEventArgs key)
        {
            MapController.ResetArea();

            switch (key.KeyCode)
            {
                case Keys.Right:
                    if (!MapController.Collide(key.KeyCode))
                        MapController.currentFigure.MoveRight();
                    break;
                case Keys.Left:
                    if (!MapController.Collide(key.KeyCode))
                        MapController.currentFigure.MoveLeft();
                    break;
                case Keys.Up:
                    if (!MapController.Collide(key.KeyCode))
                        MapController.currentFigure.Rorate();
                    break;
                case Keys.Down:
                    timerFalling.Interval = MapController.fallingSpeedFast;
                    break;
            }
            MapController.Merge();
            Invalidate();
        }
        private void Update(object? sender, EventArgs e)
        {
            MapController.ResetArea();
            if (!MapController.Collide())
                MapController.currentFigure.MoveDown();
            else
            {
                timerFalling.Interval = MapController.fallingSpeedNormal;
                MapController.Merge();
                MapController.SliceMap();
                UpdateLabels();
                MapController.currentFigure = new Figure(MapController.mapWidth / 2, 0);
                if (MapController.Collide())
                {
                    StopGame();
                    StartGame();
                }
            }
            MapController.Merge();
            Invalidate();
        }
        private void UpdateLabels()
        {
            scoreLabel.Text = $"Score: {MapController.score}";
            linesLabel.Text = $"Lines: {MapController.linesRemoved}";
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            MapController.DrawGrid(e.Graphics);
            MapController.DrawMap(e.Graphics);
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
        private void CreateNewBlockButton_Click(object sender, EventArgs e)
        {
            CreateKindOfFigere();
        }
        private void ChangeStateStartAndStopButtons()
        {
            stopButton.Enabled = !stopButton.Enabled;
            startButton.Enabled = !startButton.Enabled;
        }

        private void CreateKindOfFigere()
        {

            int[,] matrix = new int[4, 4]{
                { Convert.ToInt32(checkBox1.Checked),Convert.ToInt32(checkBox2.Checked),Convert.ToInt32(checkBox3.Checked), Convert.ToInt32(checkBox4.Checked) },
                { Convert.ToInt32(checkBox5.Checked),Convert.ToInt32(checkBox6.Checked),Convert.ToInt32(checkBox7.Checked),Convert.ToInt32(checkBox8.Checked) },
                { Convert.ToInt32(checkBox9.Checked),Convert.ToInt32(checkBox10.Checked),Convert.ToInt32(checkBox11.Checked),Convert.ToInt32(checkBox12.Checked) },
                { Convert.ToInt32(checkBox13.Checked),Convert.ToInt32(checkBox14.Checked),Convert.ToInt32(checkBox15.Checked),Convert.ToInt32(checkBox16.Checked) },
            };
            if (IsCorrectMatrix(matrix))
            {
                Figure.listTypeFigures.Add(matrix);
                rulesLabel.ForeColor = Color.Black;
            }
            else
            {
                rulesLabel.ForeColor = Color.Red;
            }
        }
        private bool IsCorrectMatrix(int[,] matrix)
        {
            int countActiveElements = 0;
            int sizeMatrix = (int)Math.Sqrt(matrix.Length);

            for (int i = 0; i < sizeMatrix; i++)
                for (int j = 0; j < sizeMatrix; j++)
                {
                    if (matrix[i, j] != 0)
                    {
                        if (i != 0 && matrix[i - 1, j] != 0)
                            matrix[i, j]++;
                        if (j != 0 && matrix[i, j - 1] != 0)
                            matrix[i, j]++;
                        if (i != sizeMatrix - 1 && matrix[i + 1, j] != 0)
                            matrix[i, j]++;
                        if (j != sizeMatrix - 1 && matrix[i, j + 1] != 0)
                            matrix[i, j]++;
                    }
                }

            for (int i = 0; i < sizeMatrix; i++)
                for (int j = 0; j < sizeMatrix; j++)
                {
                    if (matrix[i, j] == 1)
                        return false;
                    if (matrix[i, j] != 0)
                        countActiveElements++;
                }
            if (countActiveElements > 8)
                return false;

            return true;
          
        }


    }
}