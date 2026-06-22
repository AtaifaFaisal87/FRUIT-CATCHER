namespace FRUIT_CATCHER
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.birdTimer = new System.Windows.Forms.Timer(this.components);
            this.cloudTimer = new System.Windows.Forms.Timer(this.components);
            this.LeftMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.RightMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.FruitSpawnTimer = new System.Windows.Forms.Timer(this.components);
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.BombSpawnTimer = new System.Windows.Forms.Timer(this.components);
            this.scorelbl = new System.Windows.Forms.Label();
            this.levellbl = new System.Windows.Forms.Label();
            this.UpMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.DownMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.Basket = new System.Windows.Forms.PictureBox();
            this.bird2 = new System.Windows.Forms.PictureBox();
            this.bird3 = new System.Windows.Forms.PictureBox();
            this.bird1 = new System.Windows.Forms.PictureBox();
            this.RestartButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Basket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird1)).BeginInit();
            this.SuspendLayout();
            // 
            // birdTimer
            // 
            this.birdTimer.Enabled = true;
            this.birdTimer.Interval = 50;
            this.birdTimer.Tick += new System.EventHandler(this.birdTimer_Tick);
            // 
            // cloudTimer
            // 
            this.cloudTimer.Enabled = true;
            this.cloudTimer.Interval = 30;
            this.cloudTimer.Tick += new System.EventHandler(this.cloudTimer_Tick);
            // 
            // LeftMoveTimer
            // 
            this.LeftMoveTimer.Interval = 15;
            this.LeftMoveTimer.Tick += new System.EventHandler(this.LeftMoveTimer_Tick);
            // 
            // RightMoveTimer
            // 
            this.RightMoveTimer.Interval = 15;
            this.RightMoveTimer.Tick += new System.EventHandler(this.RightMoveTimer_Tick);
            // 
            // FruitSpawnTimer
            // 
            this.FruitSpawnTimer.Enabled = true;
            this.FruitSpawnTimer.Interval = 1000;
            this.FruitSpawnTimer.Tick += new System.EventHandler(this.spawnTimer_Tick);
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // BombSpawnTimer
            // 
            this.BombSpawnTimer.Enabled = true;
            this.BombSpawnTimer.Interval = 1500;
            this.BombSpawnTimer.Tick += new System.EventHandler(this.BombSpawnTimer_Tick);
            // 
            // scorelbl
            // 
            this.scorelbl.AutoSize = true;
            this.scorelbl.BackColor = System.Drawing.Color.Transparent;
            this.scorelbl.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scorelbl.ForeColor = System.Drawing.Color.Navy;
            this.scorelbl.Location = new System.Drawing.Point(-1, 9);
            this.scorelbl.Name = "scorelbl";
            this.scorelbl.Size = new System.Drawing.Size(94, 20);
            this.scorelbl.TabIndex = 6;
            this.scorelbl.Text = "SCORE : 0";
            this.scorelbl.Click += new System.EventHandler(this.scorelbl_Click);
            // 
            // levellbl
            // 
            this.levellbl.AutoSize = true;
            this.levellbl.BackColor = System.Drawing.Color.Transparent;
            this.levellbl.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levellbl.ForeColor = System.Drawing.Color.Navy;
            this.levellbl.Location = new System.Drawing.Point(381, 9);
            this.levellbl.Name = "levellbl";
            this.levellbl.Size = new System.Drawing.Size(91, 20);
            this.levellbl.TabIndex = 7;
            this.levellbl.Text = "LEVEL : 1";
            this.levellbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // UpMoveTimer
            // 
            this.UpMoveTimer.Interval = 15;
            this.UpMoveTimer.Tick += new System.EventHandler(this.UpMoveTimer_Tick);
            // 
            // DownMoveTimer
            // 
            this.DownMoveTimer.Interval = 15;
            this.DownMoveTimer.Tick += new System.EventHandler(this.DownMoveTimer_Tick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Press Start 2P", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(2, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(479, 88);
            this.label1.TabIndex = 9;
            this.label1.Text = "DISPLAY TEXT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.Yellow;
            this.StartButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StartButton.Location = new System.Drawing.Point(150, 314);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(149, 49);
            this.StartButton.TabIndex = 11;
            this.StartButton.Text = "START";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Visible = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Yellow;
            this.ExitButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ExitButton.Location = new System.Drawing.Point(150, 381);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(149, 49);
            this.ExitButton.TabIndex = 12;
            this.ExitButton.Text = "EXIT";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Visible = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Basket
            // 
            this.Basket.BackColor = System.Drawing.Color.Transparent;
            this.Basket.Image = global::FRUIT_CATCHER.Properties.Resources.basket2;
            this.Basket.Location = new System.Drawing.Point(183, 477);
            this.Basket.Name = "Basket";
            this.Basket.Size = new System.Drawing.Size(75, 46);
            this.Basket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Basket.TabIndex = 3;
            this.Basket.TabStop = false;
            this.Basket.Click += new System.EventHandler(this.Basket_Click);
            // 
            // bird2
            // 
            this.bird2.BackColor = System.Drawing.Color.Transparent;
            this.bird2.Image = global::FRUIT_CATCHER.Properties.Resources.bird__2_;
            this.bird2.Location = new System.Drawing.Point(300, 90);
            this.bird2.Name = "bird2";
            this.bird2.Size = new System.Drawing.Size(25, 17);
            this.bird2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird2.TabIndex = 2;
            this.bird2.TabStop = false;
            // 
            // bird3
            // 
            this.bird3.BackColor = System.Drawing.Color.Transparent;
            this.bird3.Image = global::FRUIT_CATCHER.Properties.Resources.bird__2_;
            this.bird3.Location = new System.Drawing.Point(150, 30);
            this.bird3.Name = "bird3";
            this.bird3.Size = new System.Drawing.Size(20, 14);
            this.bird3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird3.TabIndex = 1;
            this.bird3.TabStop = false;
            // 
            // bird1
            // 
            this.bird1.BackColor = System.Drawing.Color.Transparent;
            this.bird1.Image = global::FRUIT_CATCHER.Properties.Resources.bird__2_;
            this.bird1.Location = new System.Drawing.Point(50, 50);
            this.bird1.Name = "bird1";
            this.bird1.Size = new System.Drawing.Size(30, 20);
            this.bird1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird1.TabIndex = 0;
            this.bird1.TabStop = false;
            // 
            // RestartButton
            // 
            this.RestartButton.BackColor = System.Drawing.Color.Yellow;
            this.RestartButton.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestartButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RestartButton.Location = new System.Drawing.Point(150, 315);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(149, 49);
            this.RestartButton.TabIndex = 13;
            this.RestartButton.Text = "RESTART";
            this.RestartButton.UseVisualStyleBackColor = false;
            this.RestartButton.Visible = false;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(482, 553);
            this.Controls.Add(this.RestartButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.levellbl);
            this.Controls.Add(this.scorelbl);
            this.Controls.Add(this.Basket);
            this.Controls.Add(this.bird2);
            this.Controls.Add(this.bird3);
            this.Controls.Add(this.bird1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(215, 530);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 600);
            this.MinimumSize = new System.Drawing.Size(500, 600);
            this.Name = "Form1";
            this.Text = "FRUIT CATCHER";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Basket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bird1;
        private System.Windows.Forms.PictureBox bird3;
        private System.Windows.Forms.PictureBox bird2;
        private System.Windows.Forms.Timer birdTimer;
        private System.Windows.Forms.Timer cloudTimer;
        private System.Windows.Forms.PictureBox Basket;
        private System.Windows.Forms.Timer LeftMoveTimer;
        private System.Windows.Forms.Timer RightMoveTimer;
        private System.Windows.Forms.Timer FruitSpawnTimer;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Timer BombSpawnTimer;
        private System.Windows.Forms.Label scorelbl;
        private System.Windows.Forms.Label levellbl;
        private System.Windows.Forms.Timer UpMoveTimer;
        private System.Windows.Forms.Timer DownMoveTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button RestartButton;
    }
}