namespace lmaoGameZZ
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
            this.spritePlayer = new System.Windows.Forms.PictureBox();
            this.playerLoc = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.wallRight = new System.Windows.Forms.PictureBox();
            this.wallTop = new System.Windows.Forms.PictureBox();
            this.wallLeft = new System.Windows.Forms.PictureBox();
            this.wallBottom = new System.Windows.Forms.PictureBox();
            this.consumable = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.spritePlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumable)).BeginInit();
            this.SuspendLayout();
            // 
            // spritePlayer
            // 
            this.spritePlayer.BackColor = System.Drawing.Color.Red;
            this.spritePlayer.Location = new System.Drawing.Point(128, 128);
            this.spritePlayer.Name = "spritePlayer";
            this.spritePlayer.Size = new System.Drawing.Size(64, 64);
            this.spritePlayer.TabIndex = 0;
            this.spritePlayer.TabStop = false;
            // 
            // playerLoc
            // 
            this.playerLoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.playerLoc.Location = new System.Drawing.Point(361, 427);
            this.playerLoc.Name = "playerLoc";
            this.playerLoc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.playerLoc.Size = new System.Drawing.Size(84, 21);
            this.playerLoc.TabIndex = 1;
            this.playerLoc.Text = "x: 512, y: 512";
            this.playerLoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // wallRight
            // 
            this.wallRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.wallRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.wallRight.Location = new System.Drawing.Point(448, 0);
            this.wallRight.Margin = new System.Windows.Forms.Padding(0);
            this.wallRight.Name = "wallRight";
            this.wallRight.Size = new System.Drawing.Size(64, 512);
            this.wallRight.TabIndex = 2;
            this.wallRight.TabStop = false;
            // 
            // wallTop
            // 
            this.wallTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.wallTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.wallTop.Location = new System.Drawing.Point(0, 0);
            this.wallTop.Margin = new System.Windows.Forms.Padding(0);
            this.wallTop.Name = "wallTop";
            this.wallTop.Size = new System.Drawing.Size(448, 64);
            this.wallTop.TabIndex = 3;
            this.wallTop.TabStop = false;
            // 
            // wallLeft
            // 
            this.wallLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.wallLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.wallLeft.Location = new System.Drawing.Point(0, 64);
            this.wallLeft.Margin = new System.Windows.Forms.Padding(0);
            this.wallLeft.Name = "wallLeft";
            this.wallLeft.Size = new System.Drawing.Size(64, 448);
            this.wallLeft.TabIndex = 4;
            this.wallLeft.TabStop = false;
            // 
            // wallBottom
            // 
            this.wallBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.wallBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.wallBottom.Location = new System.Drawing.Point(64, 448);
            this.wallBottom.Margin = new System.Windows.Forms.Padding(0);
            this.wallBottom.Name = "wallBottom";
            this.wallBottom.Size = new System.Drawing.Size(384, 64);
            this.wallBottom.TabIndex = 5;
            this.wallBottom.TabStop = false;
            // 
            // consumable
            // 
            this.consumable.BackColor = System.Drawing.Color.Lime;
            this.consumable.Location = new System.Drawing.Point(320, 320);
            this.consumable.Name = "consumable";
            this.consumable.Size = new System.Drawing.Size(64, 64);
            this.consumable.TabIndex = 6;
            this.consumable.TabStop = false;
            // 
            // lblScore
            // 
            this.lblScore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(23, 20);
            this.lblScore.Name = "lblScore";
            this.lblScore.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblScore.Size = new System.Drawing.Size(169, 30);
            this.lblScore.TabIndex = 7;
            this.lblScore.Text = "Score: 999999";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTimer
            // 
            this.lblTimer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblTimer.ForeColor = System.Drawing.Color.White;
            this.lblTimer.Location = new System.Drawing.Point(288, 20);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTimer.Size = new System.Drawing.Size(212, 30);
            this.lblTimer.TabIndex = 8;
            this.lblTimer.Text = "Time: 20.0";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(512, 512);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.spritePlayer);
            this.Controls.Add(this.consumable);
            this.Controls.Add(this.playerLoc);
            this.Controls.Add(this.wallBottom);
            this.Controls.Add(this.wallLeft);
            this.Controls.Add(this.wallTop);
            this.Controls.Add(this.wallRight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.spritePlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox spritePlayer;
        private System.Windows.Forms.Label playerLoc;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox wallRight;
        private System.Windows.Forms.PictureBox wallTop;
        private System.Windows.Forms.PictureBox wallLeft;
        private System.Windows.Forms.PictureBox wallBottom;
        private System.Windows.Forms.PictureBox consumable;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblTimer;
    }
}

