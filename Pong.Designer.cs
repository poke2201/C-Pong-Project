namespace Pong
{
    partial class Pong
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pong));
            paddle_Player = new PictureBox();
            paddle_CPU = new PictureBox();
            ball = new PictureBox();
            score_Player = new Label();
            score_CPU = new Label();
            pongTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)paddle_Player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)paddle_CPU).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ball).BeginInit();
            SuspendLayout();
            // 
            // paddle_Player
            // 
            paddle_Player.BackColor = Color.FromArgb(255, 128, 0);
            paddle_Player.Location = new Point(12, 243);
            paddle_Player.Name = "paddle_Player";
            paddle_Player.Size = new Size(14, 158);
            paddle_Player.TabIndex = 0;
            paddle_Player.TabStop = false;
            // 
            // paddle_CPU
            // 
            paddle_CPU.BackColor = Color.Red;
            paddle_CPU.Location = new Point(982, 243);
            paddle_CPU.Name = "paddle_CPU";
            paddle_CPU.Size = new Size(14, 158);
            paddle_CPU.TabIndex = 1;
            paddle_CPU.TabStop = false;
            // 
            // ball
            // 
            ball.Location = new Point(446, 281);
            ball.Name = "ball";
            ball.Size = new Size(24, 24);
            ball.TabIndex = 2;
            ball.TabStop = false;
            // 
            // score_Player
            // 
            score_Player.BackColor = Color.Transparent;
            score_Player.Font = new Font("Cascadia Mono", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            score_Player.ForeColor = Color.DarkBlue;
            score_Player.Location = new Point(304, 49);
            score_Player.Name = "score_Player";
            score_Player.Size = new Size(54, 54);
            score_Player.TabIndex = 3;
            score_Player.Text = "0";
            score_Player.Click += label1_Click;
            // 
            // score_CPU
            // 
            score_CPU.BackColor = Color.Transparent;
            score_CPU.Font = new Font("Cascadia Mono", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            score_CPU.ForeColor = Color.Crimson;
            score_CPU.Location = new Point(634, 49);
            score_CPU.Name = "score_CPU";
            score_CPU.Size = new Size(54, 54);
            score_CPU.TabIndex = 4;
            score_CPU.Text = "0";
            // 
            // pongTimer
            // 
            pongTimer.Enabled = true;
            pongTimer.Tick += pongTimer_Tick;
            // 
            // Pong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1008, 729);
            Controls.Add(ball);
            Controls.Add(paddle_CPU);
            Controls.Add(paddle_Player);
            Controls.Add(score_CPU);
            Controls.Add(score_Player);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Pong";
            Text = "Pong";
            Load += Pong_Load;
            KeyDown += pong_KeyDown;
            KeyUp += pong_KeyUp;
            ((System.ComponentModel.ISupportInitialize)paddle_Player).EndInit();
            ((System.ComponentModel.ISupportInitialize)paddle_CPU).EndInit();
            ((System.ComponentModel.ISupportInitialize)ball).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox paddle_Player;
        private PictureBox paddle_CPU;
        private PictureBox ball;
        private Label score_Player;
        private Label score_CPU;
        private System.Windows.Forms.Timer pongTimer;
    }
}