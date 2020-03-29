using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lmaoGameZZ
{
    public partial class Form1 : Form
    {
        //bool move;
        int playerX, playerY, playerNX, playerNY;
        int cellSize = 64;
        int score;
        float timeLeft = 30.0f;
        private void Restart()
        {
            BackColor = SystemColors.ControlDark;
            score = 0;
            playerX = 128;
            playerY = 128;
            playerNX = playerX;
            playerNY = playerY;
            timeLeft = 30.0f;
            spritePlayer.Location = new Point(playerX, playerY);
            lblScore.Text = $"Score: {score}";
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft <= 0)
            {
                timer1.Stop();
                DialogResult dr = MessageBox.Show($"Time's up!\nFinal Score: {score}\n\nPlay Again?", "Game Over", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                    Restart();
                else
                    Application.Exit();
            }
            Random rng = new Random();
            int randX = ((rng.Next(1, 6) * 64) + 64);
            int randY = ((rng.Next(1, 6) * 64) + 64);

            playerLoc.Text = $"x: {playerX}, y: {playerY}";
            if (playerX == consumable.Location.X && playerY == consumable.Location.Y)
            {
                score++;
                lblScore.Text = $"Score: {score}";
                while (randX == playerX && randY == playerY)
                {
                    randX = ((rng.Next(1, 6) * 64) + 64);
                    randY = ((rng.Next(1, 6) * 64) + 64);
                }
                consumable.Location = new Point(randX, randY);
            }
            timeLeft -= 0.1f;
            string timeFormatted = String.Format("{0:0.0}", timeLeft);
            lblTimer.Text = "Time: " + timeFormatted;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    playerNX -= cellSize;
                    if (playerNX != wallLeft.Location.X) //Collision
                        playerX = playerNX;
                    else
                        playerNX = playerX;
                    spritePlayer.Location = new Point(playerX, playerY);
                    break;
                case Keys.Right:
                    playerNX += cellSize;
                    if (playerNX != wallRight.Location.X) //Collision
                        playerX = playerNX;
                    else
                        playerNX = playerX;
                    spritePlayer.Location = new Point(playerX, playerY);
                    break;
                case Keys.Up:
                    playerNY -= cellSize;
                    if (playerNY != wallTop.Location.Y) //Collision
                        playerY = playerNY;
                    else
                        playerNY = playerY;
                    spritePlayer.Location = new Point(playerX, playerY);
                    break;
                case Keys.Down:
                    playerNY += cellSize;
                    if (playerNY != wallBottom.Location.Y) //Collision
                        playerY = playerNY;
                    else
                        playerNY = playerY;
                    spritePlayer.Location = new Point(playerX, playerY);
                    break;
            }
        }

        public Form1()
        {
            InitializeComponent();
            Restart();
        }
    }
}
