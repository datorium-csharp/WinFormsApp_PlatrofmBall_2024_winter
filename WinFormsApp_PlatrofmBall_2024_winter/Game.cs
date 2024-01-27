namespace WinFormsApp_PlatrofmBall_2024_winter
{
    public partial class Game : Form
    {
        private System.Windows.Forms.Timer mainTimer = null;
        private int horVelocity = 2;
        private int verVelocity = 2;

        public Game()
        {
            InitializeComponent();
            InitializeGame();
            InitializeMainTimer();
        }

        public void InitializeGame()
        {
            this.BackColor = Color.Black;
            this.Width = 400;
            this.Height = 400;
            this.Text = "Bouncing ball";

            Ball.Width = 20;
            Ball.Height = 20;
            Ball.Left = 190;
            Ball.Top = 190;
            Ball.BackColor = Color.Red;
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
            Ball.Left += horVelocity;
            Ball.Top += verVelocity;
        }

    }
}