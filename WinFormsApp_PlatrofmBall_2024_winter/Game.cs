using System;

namespace WinFormsApp_PlatrofmBall_2024_winter
{
    public partial class Game : Form
    {
        private System.Windows.Forms.Timer mainTimer = null;
        private Random rand = new Random();
        private List<Ball> allBalls = new List<Ball>();

        public Game()
        {
            InitializeComponent();
            InitializeGame();
            InitializeMainTimer();
        }

        public void InitializeGame()
        {
            this.DoubleBuffered = true;
            this.BackColor = Color.Black;
            this.Width = 400;
            this.Height = 400;
            this.Text = "Bouncing ball";

            //Ball.Width = 20;
            //Ball.Height = 20;
            //Ball.Left = 190;
            //Ball.Top = 190;
            //Ball.BackColor = Color.Red;

            SpawnBalls(10);
        }

        public void SpawnBalls(int number)
        {
            for (int i = 0; i < number; i++)
            {
                var newBall = new Ball();
                newBall.Left = 190;
                newBall.Top = 190;

                newBall.horVelocity = rand.Next(1, 10);
                newBall.verVelocity = rand.Next(1, 10);

                allBalls.Add(newBall);
                this.Controls.Add(newBall);
            }
        }

        // Collision detection
        // Timer
        // Vector calculations

        private void InitializeMainTimer()
        {
            mainTimer = new System.Windows.Forms.Timer();
            mainTimer.Interval = 20;
            mainTimer.Tick += MainTimer_Tick;
            mainTimer.Start();
        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            foreach(var ball in allBalls)
            {
                ball.Left += ball.horVelocity;
                ball.Top += ball.verVelocity;
            }
            BallBorderCollision();
        }

        private void BallBorderCollision()
        {
            foreach(var ball in allBalls)
            {
                if (ball.Left <= 0 || ball.Left + ball.Width >= ClientRectangle.Width)
                {
                    ball.horVelocity *= -1;
                }
                else if (ball.Top <= 0 || ball.Top + ball.Height >= ClientRectangle.Height)
                {
                    ball.verVelocity *= -1;
                }
            }           
          
        }

    }
}