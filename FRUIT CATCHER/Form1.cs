using System;
using System.Drawing;
using System.Reflection.Emit;
using System.Security.AccessControl;
using System.Windows.Forms;
using WMPLib;

namespace FRUIT_CATCHER
{
    public partial class Form1 : Form
    {
        //clouds for bg
        PictureBox[] clouds;
        Random cloudrnd;

        //fruits
        PictureBox[] fruits;
        Random fruitRnd;
        int fruitspeed;

        //bomb
        PictureBox[] bombs;
        int bombspeed;

        int score=0; // Variable to keep track of the player's score
        int level=1; // Variable to keep track of the current level of the game
        bool pause=false; // Variable to control whether the game is paused or not
        bool gameOver = false;

        //MUSIC
        WMPLib.WindowsMediaPlayer gameMedia;
        WMPLib.WindowsMediaPlayer catchMedia;
        WMPLib.WindowsMediaPlayer explosionMedia;

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //music addtion
            
            gameMedia = new WMPLib.WindowsMediaPlayer();
            catchMedia = new WMPLib.WindowsMediaPlayer();
            explosionMedia = new WMPLib.WindowsMediaPlayer();

            //LOAD MUSIC
            gameMedia.URL = @"D:\C#\FRUIT CATCHER\FRUIT CATCHER\bin\Debug\sound\game.mp3";
            catchMedia.settings.autoStart = false;
            catchMedia.URL = @"D:\C#\FRUIT CATCHER\FRUIT CATCHER\bin\Debug\sound\catch.mp3";
            explosionMedia.settings.autoStart=false;
            explosionMedia.URL = @"D:\C#\FRUIT CATCHER\FRUIT CATCHER\bin\Debug\sound\boom.mp3";

            

            //vol setup
            gameMedia.settings.setMode("loop", true); // Set the game music to loop continuously
            gameMedia.settings.volume = 10;
            catchMedia.settings.volume = 20; 
            explosionMedia.settings.volume = 6; 

            //to keep the birds behind the other controls on the form
            bird1.SendToBack();
            bird2.SendToBack();
            bird3.SendToBack();
         
            //  clouds for bg
            clouds = new PictureBox[15];
            cloudrnd = new Random();

            for (int i = 0; i < clouds.Length; i++)
            {
                PictureBox cloud = new PictureBox();

                string path = Application.StartupPath + "\\characters\\clouds.png";
                cloud.Image = Image.FromFile(path);

                cloud.SizeMode = PictureBoxSizeMode.StretchImage;
                cloud.BackColor = Color.Transparent;

                int size = cloudrnd.Next(30, 60);
                cloud.Width = size;
                cloud.Height = (int)(size * 0.6);

                int randomX = cloudrnd.Next(0, this.ClientSize.Width - size);
                int randomY = cloudrnd.Next(0, this.ClientSize.Height);
                cloud.Location = new Point(randomX, randomY);

                this.Controls.Add(cloud);
                cloud.SendToBack();

                clouds[i] = cloud;
            }

            //  fruits
            fruitRnd = new Random();
            fruitspeed = 3;
            fruits = new PictureBox[15];

            //load images
            Image Banana = Image.FromFile(Application.StartupPath + "\\characters\\banana.png");
            Image Apple = Image.FromFile(Application.StartupPath + "\\characters\\apple.png");
            Image Strawberry = Image.FromFile(Application.StartupPath + "\\characters\\strawberry.png");
            Image Kiwi = Image.FromFile(Application.StartupPath + "\\characters\\kiwi.png");
            Image Orange = Image.FromFile(Application.StartupPath + "\\characters\\orange.png");
            Image Grapes = Image.FromFile(Application.StartupPath + "\\characters\\grape.png");
            Image Pineapple = Image.FromFile(Application.StartupPath + "\\characters\\pineapple.png");


            int fruitWidth = 35;
            int fruitSpacing = 50;
            int totalFruitRowWidth = (fruits.Length * fruitWidth) + ((fruits.Length - 1) * (fruitSpacing - fruitWidth));
            int fruitStartX = (this.ClientSize.Width - totalFruitRowWidth) / 2;

            for (int i = 0; i < fruits.Length; i++)
            {
                fruits[i] = new PictureBox();
                fruits[i].Size = new Size(fruitWidth, fruitWidth);
                fruits[i].SizeMode = PictureBoxSizeMode.Zoom;
                fruits[i].BorderStyle = BorderStyle.None;
                fruits[i].BackColor = Color.Transparent;
                fruits[i].Visible = false;
                this.Controls.Add(fruits[i]);
                fruits[i].Location = new Point(fruitStartX + (i * fruitSpacing), -50);
            }

            fruits[0].Image = Banana;
            fruits[1].Image = Apple;
            fruits[2].Image = Strawberry;
            fruits[3].Image = Kiwi;
            fruits[4].Image = Orange;
            fruits[5].Image = Grapes;
            fruits[6].Image = Pineapple;
            fruits[7].Image = Banana;
            fruits[8].Image = Apple;
            fruits[9].Image = Strawberry;
            fruits[10].Image = Kiwi;
            fruits[11].Image = Orange;
            fruits[12].Image = Grapes;
            fruits[13].Image = Pineapple;
            fruits[14].Image = Banana;

            for (int i = 0; i < fruits.Length; i++)
            {
                fruits[i].BringToFront();
            }

            // bombs
            bombspeed = 3;
            bombs = new PictureBox[5];

            Image Bomb = Image.FromFile(Application.StartupPath + "\\characters\\bomb.png");

            int bombWidth = 35;
            int bombSpacing = 50;
            int totalBombRowWidth = (bombs.Length * bombWidth) + ((bombs.Length - 1) * (bombSpacing - bombWidth));
            int bombStartX = (this.ClientSize.Width - totalBombRowWidth) / 2;

            for (int i = 0; i < bombs.Length; i++)
            {
                bombs[i] = new PictureBox();
                bombs[i].Size = new Size(bombWidth, bombWidth);
                bombs[i].SizeMode = PictureBoxSizeMode.Zoom;
                bombs[i].BorderStyle = BorderStyle.None;
                bombs[i].BackColor = Color.Transparent;
                bombs[i].Visible = false;
                bombs[i].Image = Bomb;
                this.Controls.Add(bombs[i]);
                bombs[i].Location = new Point(bombStartX + (i * bombSpacing), -50);
            }

            for (int i = 0; i < bombs.Length; i++)
            {
                bombs[i].BringToFront();
            }

            scorelbl.BringToFront();
            levellbl.BringToFront();
           
            // Stop all game timers until Start is pressed
            gameTimer.Stop();
            FruitSpawnTimer.Stop();
            BombSpawnTimer.Stop();
            birdTimer.Stop();
            cloudTimer.Stop();

            // Show the Start button
            StartButton.Visible = true;
            StartButton.BringToFront();

        }

    


        /*to move the birds across the screen */
        private void birdTimer_Tick(object sender, EventArgs e)
        {
            //clientsize.width is the width of the form, so when the bird goes past the right edge of the form, it will reappear on the left edge
            bird1.Left += 2;
            if(bird1.Left > this.ClientSize.Width)
            {
                bird1.Left = -40;
            }

            bird2.Left += 1;
            if (bird2.Left > this.ClientSize.Width)
            {
                bird2.Left = -40;
            }

            bird3.Left += 3;
            if (bird3.Left > this.ClientSize.Width)
            {
                bird3.Left = -40;
            }
        }

        //to move the clouds down the screen
        private void cloudTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < clouds.Length; i++)
            {
                clouds[i].Top += 1;//clouds move down the screen by 1 pixel every tick

                if (clouds[i].Top > this.ClientSize.Height)//when the cloud goes past the bottom edge of the form, it will reappear at the top edge
                {
                    clouds[i].Top = -clouds[i].Height;//cloud reappears at the top edge of the form, just above the visible area
                    clouds[i].Left = cloudrnd.Next(0, this.ClientSize.Width - clouds[i].Width);//random x position for the cloud when it reappears at the top
                }
            }
        }


        private void Basket_Click(object sender, EventArgs e)
        {

        }

        // not one-press-one-step ... while key stays held down, basket moves 5px every 15ms automatically,
        // on repeat, tied to the timer ticking, not tied to how many times you press

        // key pressed down ... start moving in that direction
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (!pause)
            {
                if (e.KeyCode == Keys.Left && !LeftMoveTimer.Enabled)
                {
                    LeftMoveTimer.Start();
                }

                if (e.KeyCode == Keys.Right && !RightMoveTimer.Enabled)
                {
                    RightMoveTimer.Start();
                }

                if (e.KeyCode == Keys.Up && !UpMoveTimer.Enabled)
                {
                    UpMoveTimer.Start();
                }

                if (e.KeyCode == Keys.Down && !DownMoveTimer.Enabled)
                {
                    DownMoveTimer.Start();
                }
            }
        }

        // key released ... stop moving
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            RightMoveTimer.Stop();
            LeftMoveTimer.Stop();
            DownMoveTimer.Stop();
            UpMoveTimer.Stop();

            if (e.KeyCode == Keys.Space)
            {
                if (!gameOver)
                {
                    if (pause)
                    {
                        gameMedia.controls.play(); // Resume playing the game music when the pause key is released
                        StartTimer(); // Call the StartTimer method to resume all timers in the game when the pause key is released
                        label1.Visible = false;
                        pause = false; // Set the pause variable to false to indicate that the game is no longer paused

                    }
                    else
                    {
                        gameMedia.controls.pause(); // Pause the game music when the pause key is released
                        label1.Left = (this.ClientSize.Width / 2) - (label1.Width / 2);
                        label1.Top = (this.ClientSize.Height / 2) - (label1.Height / 2);
                        label1.Text = "PAUSED";
                        label1.Visible = true;
                        StopTimer();
                        pause = true; // Set the pause variable to true to indicate that the game is paused
                    }
                }
            }
        }

        // moves basket left 5px every tick (every 15ms) while LeftMoveTimer is running
        private void LeftMoveTimer_Tick(object sender, EventArgs e)
        {
            if (Basket.Left > 0)
            {
                Basket.Left -= 5;
            }
        }

        // moves basket right 5px every tick (every 15ms) while RightMoveTimer is running
        private void RightMoveTimer_Tick(object sender, EventArgs e)
        {
            if (Basket.Left < this.ClientSize.Width - Basket.Width)
            {
                Basket.Left += 5;
            }
        }

        // MOVES basket upward
        private void UpMoveTimer_Tick(object sender, EventArgs e)
        {
            if (Basket.Top > 0)
            {
                Basket.Top -= 5; 
            }
        }

        private void DownMoveTimer_Tick(object sender, EventArgs e)
        {
            if (Basket.Top < this.ClientSize.Height - Basket.Height)
            {
                Basket.Top += 5;
            }
        }


        private bool IsPositionClear(int x, int width)
        {
            int minGap = 20; // minimum horizontal gap allowed between items

            foreach (PictureBox fruit in fruits)
            {
                if (fruit.Visible && fruit.Top < 100) // only check items still near the top (freshly spawned)
                {
                    if (Math.Abs(fruit.Left - x) < (width + minGap))
                    {
                        return false;
                    }
                }
            }

            foreach (PictureBox bomb in bombs)
            {
                if (bomb.Visible && bomb.Top < 100)
                {
                    if (Math.Abs(bomb.Left - x) < (width + minGap))
                    {
                        return false;
                    }
                }
            }

            return true; // no conflicts found, safe to spawn here
        }

        private void spawnTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < fruits.Length; i++)
            {
                if (fruits[i].Visible == false)
                {
                    int randomX = fruitRnd.Next(0, this.ClientSize.Width - fruits[i].Width);

                    // try a few times to find a clear spot
                    int attempts = 0;
                    while (!IsPositionClear(randomX, fruits[i].Width) && attempts < 10)
                    {
                        randomX = fruitRnd.Next(0, this.ClientSize.Width - fruits[i].Width);
                        attempts++;
                    }

                    fruits[i].Location = new Point(randomX, -50);
                    fruits[i].Visible = true;

                    break;
                }
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
       
            for (int i = 0; i < fruits.Length; i++)
            {
                if (fruits[i].Visible == true)
                {
                    fruits[i].Top += fruitspeed;

                    FruitCollision(fruits[i]);
                }
            }

            for (int i = 0; i < bombs.Length; i++)
            {
                if (bombs[i].Visible == true)
                {
                    bombs[i].Top += bombspeed;
                    BombCollision(bombs[i]);
                }
            }

        }

        private void BombCollision(PictureBox bomb)
        {
            if (bomb.Bounds.IntersectsWith(Basket.Bounds))
            {
                bomb.Visible = false;
                explosionMedia.controls.play();
                GameControl("GAME OVER");
            }
            else if (bomb.Top > this.ClientSize.Height)
            {
                bomb.Visible = false; // missed bomb, no penalty for now
            }
        }

        private void FruitCollision(PictureBox fruit)
        {
            if (fruit.Bounds.IntersectsWith(Basket.Bounds))
            {
                fruit.Visible = false; // caught, hide it
                score += 1;
                scorelbl.Text = "SCORE: " + score;
                catchMedia.controls.play();

                if (score % 10 == 0)
                {
                    level += 1;
                    levellbl.Text = "LEVEL: " + level;

                    // increase speed only when leveling up
                    fruitspeed += 1;
                    bombspeed += 1;
                }

                if (level >= 10)
                {
                    GameControl("YOU WON!");
                }

                
            }
            else if (fruit.Top > this.ClientSize.Height)
            {
                fruit.Visible = false; // missed, fell off screen
            }
        }

        private void BombSpawnTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < bombs.Length; i++)
            {
                if (bombs[i].Visible == false)
                {
                    int randomX = fruitRnd.Next(0, this.ClientSize.Width - bombs[i].Width);

                    int attempts = 0;
                    while (!IsPositionClear(randomX, bombs[i].Width) && attempts < 10)
                    {
                        randomX = fruitRnd.Next(0, this.ClientSize.Width - bombs[i].Width);
                        attempts++;
                    }

                    bombs[i].Location = new Point(randomX, -50);
                    bombs[i].Visible = true;

                    break;
                }
            }
        }

        private void GameControl(string msg)
        {
            gameOver = true;

            Basket.Visible = false;

            for (int i = 0; i < bombs.Length; i++)
            {
                bombs[i].Visible = false;
            }

            for (int i = 0; i < fruits.Length; i++)
            {
                fruits[i].Visible = false;
            }
            gameTimer.Stop();
            FruitSpawnTimer.Stop();
            BombSpawnTimer.Stop();
            LeftMoveTimer.Stop();
            RightMoveTimer.Stop();
            cloudTimer.Stop();
            gameMedia.controls.stop();

            label1.Visible = true;
            label1.BringToFront();
            label1.Text = msg;

            label1.Left = (this.ClientSize.Width / 2) - (label1.Width / 2);
            label1.Top = (this.ClientSize.Height / 2) - (label1.Height / 2);

            RestartButton.Visible = true;
            RestartButton.BringToFront();
            ExitButton.Visible = true;
            ExitButton.BringToFront();

        }

        private void StopTimer()
        {
            gameTimer.Stop();
            FruitSpawnTimer.Stop();
            BombSpawnTimer.Stop();
            LeftMoveTimer.Stop();
            RightMoveTimer.Stop();
            UpMoveTimer.Stop();
            DownMoveTimer.Stop();
            birdTimer.Stop();
            cloudTimer.Stop();
        }

        private void StartTimer()
        {
            gameTimer.Start();
            FruitSpawnTimer.Start();
            BombSpawnTimer.Start();
            birdTimer.Start();
            cloudTimer.Start();
           
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
         
            // bring basket back
            Basket.Visible = true;
            StartButton.Visible = false;// hide the button
            ExitButton.Visible = false;
            StartTimer();                  // start all game timers
            gameMedia.controls.play();     // start music
            this.ActiveControl = null;

        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            // reset game state
            score = 0;
            level = 1;
            fruitspeed = 3;
            bombspeed = 3;
            gameOver = false;
            scorelbl.Text = "SCORE: 0";
            levellbl.Text = "LEVEL: 1";

            // hide UI
            RestartButton.Visible = false;
            ExitButton.Visible = false;
            label1.Visible = false;

            // bring basket back
            Basket.Location = new Point(160, 350);  //reset to original position
            Basket.Visible = true;
            Basket.BringToFront();

            StartTimer();
            gameMedia.controls.play();
            this.ActiveControl = null;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }


        private void scorelbl_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

 
    }
}
