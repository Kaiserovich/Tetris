namespace WinFormsApp1
{
    partial class Tetris
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timerFalling = new System.Windows.Forms.Timer(this.components);
            this.linesLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.sizeFieldLabel = new System.Windows.Forms.Label();
            this.sizeFieldXLabel = new System.Windows.Forms.Label();
            this.sizeFieldYLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.sizeFieldXTextBox = new System.Windows.Forms.TextBox();
            this.sizeFieldYTextBox = new System.Windows.Forms.TextBox();
            this.stopButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // linesLabel
            // 
            this.linesLabel.AutoSize = true;
            this.linesLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linesLabel.Location = new System.Drawing.Point(12, 424);
            this.linesLabel.Name = "linesLabel";
            this.linesLabel.Size = new System.Drawing.Size(68, 32);
            this.linesLabel.TabIndex = 0;
            this.linesLabel.Text = "Lines";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scoreLabel.Location = new System.Drawing.Point(12, 379);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(73, 32);
            this.scoreLabel.TabIndex = 1;
            this.scoreLabel.Text = "Score";
            // 
            // sizeFieldLabel
            // 
            this.sizeFieldLabel.AutoSize = true;
            this.sizeFieldLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sizeFieldLabel.Location = new System.Drawing.Point(12, 9);
            this.sizeFieldLabel.Name = "sizeFieldLabel";
            this.sizeFieldLabel.Size = new System.Drawing.Size(112, 32);
            this.sizeFieldLabel.TabIndex = 3;
            this.sizeFieldLabel.Text = "Field size";
            // 
            // sizeFieldXLabel
            // 
            this.sizeFieldXLabel.AutoSize = true;
            this.sizeFieldXLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sizeFieldXLabel.Location = new System.Drawing.Point(24, 51);
            this.sizeFieldXLabel.Name = "sizeFieldXLabel";
            this.sizeFieldXLabel.Size = new System.Drawing.Size(33, 32);
            this.sizeFieldXLabel.TabIndex = 4;
            this.sizeFieldXLabel.Text = "X:";
            // 
            // sizeFieldYLabel
            // 
            this.sizeFieldYLabel.AutoSize = true;
            this.sizeFieldYLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sizeFieldYLabel.Location = new System.Drawing.Point(25, 94);
            this.sizeFieldYLabel.Name = "sizeFieldYLabel";
            this.sizeFieldYLabel.Size = new System.Drawing.Size(32, 32);
            this.sizeFieldYLabel.TabIndex = 5;
            this.sizeFieldYLabel.Text = "Y:";
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startButton.Location = new System.Drawing.Point(12, 143);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(112, 44);
            this.startButton.TabIndex = 6;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // sizeFieldXTextBox
            // 
            this.sizeFieldXTextBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sizeFieldXTextBox.Location = new System.Drawing.Point(57, 50);
            this.sizeFieldXTextBox.Name = "sizeFieldXTextBox";
            this.sizeFieldXTextBox.Size = new System.Drawing.Size(53, 39);
            this.sizeFieldXTextBox.TabIndex = 7;
            this.sizeFieldXTextBox.Text = "15";
            this.sizeFieldXTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SizeFieldXTextBox_KeyPress);
            // 
            // sizeFieldYTextBox
            // 
            this.sizeFieldYTextBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sizeFieldYTextBox.Location = new System.Drawing.Point(57, 92);
            this.sizeFieldYTextBox.Name = "sizeFieldYTextBox";
            this.sizeFieldYTextBox.Size = new System.Drawing.Size(53, 39);
            this.sizeFieldYTextBox.TabIndex = 8;
            this.sizeFieldYTextBox.Text = "20";
            this.sizeFieldYTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SizeFieldYTextBox_KeyPress);
            // 
            // stopButton
            // 
            this.stopButton.Enabled = false;
            this.stopButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stopButton.Location = new System.Drawing.Point(12, 193);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(112, 44);
            this.stopButton.TabIndex = 9;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(141, 133);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(219, 64);
            this.errorLabel.TabIndex = 10;
            this.errorLabel.Text = "Minimum field size\r\nX = 15 Y = 20";
            this.errorLabel.Visible = false;
            this.errorLabel.Click += new System.EventHandler(this.errorLabel_Click);
            // 
            // Tetris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 575);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.sizeFieldYTextBox);
            this.Controls.Add(this.sizeFieldXTextBox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.sizeFieldYLabel);
            this.Controls.Add(this.sizeFieldXLabel);
            this.Controls.Add(this.sizeFieldLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.linesLabel);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "Tetris";
            this.Text = "Tetris";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timerFalling;
        private Label linesLabel;
        private Label scoreLabel;
        private Label sizeFieldLabel;
        private Label sizeFieldXLabel;
        private Label sizeFieldYLabel;
        private Button startButton;
        private TextBox sizeFieldXTextBox;
        private TextBox sizeFieldYTextBox;
        private Button stopButton;
        private Label errorLabel;
    }
}