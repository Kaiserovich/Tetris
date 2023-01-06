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
            this.createNewBlockButton = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.checkBox14 = new System.Windows.Forms.CheckBox();
            this.checkBox15 = new System.Windows.Forms.CheckBox();
            this.checkBox16 = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rulesLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // linesLabel
            // 
            this.linesLabel.AutoSize = true;
            this.linesLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linesLabel.Location = new System.Drawing.Point(12, 181);
            this.linesLabel.Name = "linesLabel";
            this.linesLabel.Size = new System.Drawing.Size(68, 32);
            this.linesLabel.TabIndex = 0;
            this.linesLabel.Text = "Lines";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scoreLabel.Location = new System.Drawing.Point(12, 147);
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
            this.startButton.Location = new System.Drawing.Point(141, 12);
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
            this.stopButton.Location = new System.Drawing.Point(268, 12);
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
            this.errorLabel.Location = new System.Drawing.Point(148, 67);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(219, 64);
            this.errorLabel.TabIndex = 10;
            this.errorLabel.Text = "Minimum field size\r\nX = 15 Y = 20";
            this.errorLabel.Visible = false;
            // 
            // createNewBlockButton
            // 
            this.createNewBlockButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createNewBlockButton.Location = new System.Drawing.Point(389, 17);
            this.createNewBlockButton.Name = "createNewBlockButton";
            this.createNewBlockButton.Size = new System.Drawing.Size(112, 65);
            this.createNewBlockButton.TabIndex = 11;
            this.createNewBlockButton.Text = "Create new block";
            this.createNewBlockButton.UseVisualStyleBackColor = true;
            this.createNewBlockButton.Click += new System.EventHandler(this.CreateNewBlockButton_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.Location = new System.Drawing.Point(400, 22);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 34;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox2.Location = new System.Drawing.Point(421, 22);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 35;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox3.Location = new System.Drawing.Point(442, 22);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 36;
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox4.Location = new System.Drawing.Point(463, 22);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(15, 14);
            this.checkBox4.TabIndex = 37;
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox5.Location = new System.Drawing.Point(12, 35);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(15, 14);
            this.checkBox5.TabIndex = 41;
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox6.Location = new System.Drawing.Point(33, 35);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(15, 14);
            this.checkBox6.TabIndex = 40;
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox7.Location = new System.Drawing.Point(54, 35);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(15, 14);
            this.checkBox7.TabIndex = 39;
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox8.Location = new System.Drawing.Point(75, 35);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(15, 14);
            this.checkBox8.TabIndex = 38;
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox9.Location = new System.Drawing.Point(12, 55);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(15, 14);
            this.checkBox9.TabIndex = 45;
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox10.Location = new System.Drawing.Point(33, 55);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(15, 14);
            this.checkBox10.TabIndex = 44;
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox11.Location = new System.Drawing.Point(54, 55);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(15, 14);
            this.checkBox11.TabIndex = 43;
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox12.Location = new System.Drawing.Point(75, 55);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(15, 14);
            this.checkBox12.TabIndex = 42;
            this.checkBox12.UseVisualStyleBackColor = true;
            // 
            // checkBox13
            // 
            this.checkBox13.AutoSize = true;
            this.checkBox13.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox13.Location = new System.Drawing.Point(12, 75);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(15, 14);
            this.checkBox13.TabIndex = 49;
            this.checkBox13.UseVisualStyleBackColor = true;
            // 
            // checkBox14
            // 
            this.checkBox14.AutoSize = true;
            this.checkBox14.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox14.Location = new System.Drawing.Point(33, 75);
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Size = new System.Drawing.Size(15, 14);
            this.checkBox14.TabIndex = 48;
            this.checkBox14.UseVisualStyleBackColor = true;
            // 
            // checkBox15
            // 
            this.checkBox15.AutoSize = true;
            this.checkBox15.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox15.Location = new System.Drawing.Point(54, 75);
            this.checkBox15.Name = "checkBox15";
            this.checkBox15.Size = new System.Drawing.Size(15, 14);
            this.checkBox15.TabIndex = 47;
            this.checkBox15.UseVisualStyleBackColor = true;
            // 
            // checkBox16
            // 
            this.checkBox16.AutoSize = true;
            this.checkBox16.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox16.Location = new System.Drawing.Point(75, 75);
            this.checkBox16.Name = "checkBox16";
            this.checkBox16.Size = new System.Drawing.Size(15, 14);
            this.checkBox16.TabIndex = 46;
            this.checkBox16.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBox13);
            this.panel1.Controls.Add(this.createNewBlockButton);
            this.panel1.Controls.Add(this.checkBox14);
            this.panel1.Controls.Add(this.rulesLabel);
            this.panel1.Controls.Add(this.checkBox15);
            this.panel1.Controls.Add(this.checkBox9);
            this.panel1.Controls.Add(this.checkBox16);
            this.panel1.Controls.Add(this.checkBox8);
            this.panel1.Controls.Add(this.checkBox7);
            this.panel1.Controls.Add(this.checkBox10);
            this.panel1.Controls.Add(this.checkBox6);
            this.panel1.Controls.Add(this.checkBox11);
            this.panel1.Controls.Add(this.checkBox5);
            this.panel1.Controls.Add(this.checkBox12);
            this.panel1.Location = new System.Drawing.Point(388, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 98);
            this.panel1.TabIndex = 50;
            // 
            // rulesLabel
            // 
            this.rulesLabel.AutoSize = true;
            this.rulesLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rulesLabel.ForeColor = System.Drawing.Color.Black;
            this.rulesLabel.Location = new System.Drawing.Point(96, 16);
            this.rulesLabel.Name = "rulesLabel";
            this.rulesLabel.Size = new System.Drawing.Size(299, 63);
            this.rulesLabel.TabIndex = 51;
            this.rulesLabel.Text = "Rules: no more than eight cells in a block. \r\nEach cell in a block must have \r\nan" +
    " adjacent cell along the X or Y axis.";
            // 
            // Tetris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 718);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
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
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "Tetris";
            this.Text = "Tetris";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private Button createNewBlockButton;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private CheckBox checkBox7;
        private CheckBox checkBox8;
        private CheckBox checkBox9;
        private CheckBox checkBox10;
        private CheckBox checkBox11;
        private CheckBox checkBox12;
        private CheckBox checkBox13;
        private CheckBox checkBox14;
        private CheckBox checkBox15;
        private CheckBox checkBox16;
        private Panel panel1;
        private Label rulesLabel;
    }
}