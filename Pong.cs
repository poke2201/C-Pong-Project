namespace Pong
{
    public partial class Pong : Form
    {
        //Location Variables
        int cpuDirection = 15;
        int ballXCoordinate = 10;
        int ballYCoordinate = 10;

        //Score Variables
        int playerScore = 0;
        int cpuScore = 0;

        //Size Variables
        int bottomBoundary;
        int topBoundary;
        int centerPoint;
        int xMidpoint;
        int yMidpoint;

        // Detection Variables
        bool playerDetectedUp;
        bool playerDetectedDown;

        //special keys
        int spacebarClicked = 0;

        public Pong()
        {
            InitializeComponent();
            bottomBoundary = ClientSize.Height - paddle_Player.Height;
            xMidpoint = ClientSize.Width / 2;
            yMidpoint = ClientSize.Height / 2;

        }


        private void Pong_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pongTimer_Tick(object sender, EventArgs e)
        {
            Random newBallSpot = new Random();
            int newSpot = newBallSpot.Next(100, ClientSize.Height - 100);

            //adjust where the ball is
            ball.Top -= ballYCoordinate;
            ball.Left -= ballXCoordinate;

            // Make CPU move
            paddle_CPU.Top += cpuDirection;
            // Check if CPU has reached top or bottom
            if (paddle_CPU.Top < 0 || paddle_CPU.Top > bottomBoundary) { cpuDirection = -cpuDirection; }

            // check if ball has exited left side of screen
            if (ball.Left < 0)
            {
                ball.Left = xMidpoint;
                ball.Top = newSpot;
                ballXCoordinate = -ballXCoordinate;
                cpuScore++;
                score_CPU.Text = cpuScore.ToString();
            }

            // check if ball has exited right side of screen
            if (ball.Left + ball.Width > ClientSize.Width)
            {
                ball.Left = xMidpoint;
                ball.Top = newSpot;
                ballXCoordinate = -ballXCoordinate;
                playerScore++;
                score_Player.Text = playerScore.ToString();
            }

            // Keep ball within the screen
            if (ball.Top < 0 || ball.Top + ball.Height > ClientSize.Height) { ballYCoordinate = -ballYCoordinate; }

            // Check if ball hits paddle
            if (ball.Bounds.IntersectsWith(paddle_Player.Bounds) || ball.Bounds.IntersectsWith(paddle_CPU.Bounds)) { ballXCoordinate = -ballXCoordinate; }

            // Move player up
            if (playerDetectedUp == true && paddle_Player.Top > 0) { paddle_Player.Top -= 15; }
            // Move player down
            if (playerDetectedDown == true && paddle_Player.Top < bottomBoundary) { paddle_Player.Top += 15; }

            // Check for winner
            if (playerScore >= 10 || cpuScore >= 10) { pongTimer.Stop(); }

        }

        private void pong_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) { playerDetectedUp = false; }
            if (e.KeyCode == Keys.Down) { playerDetectedDown = false; }
        }

        private void pong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) { playerDetectedUp = true; }
            if (e.KeyCode == Keys.Down) { playerDetectedDown = true; }

            if (e.KeyCode == Keys.Space)
            {
                if (spacebarClicked % 2 == 0)
                {
                    pongTimer.Stop();
                }

                else
                {
                    pongTimer.Start();
                }
            }

            spacebarClicked++;
        }

    }

}