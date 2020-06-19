﻿using System.ComponentModel;

namespace IArkanoid
{
    partial class NewGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(NewGame));
            this.lblLives = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.player = new System.Windows.Forms.PictureBox();
            this.Ball = new System.Windows.Forms.PictureBox();
            this.heart3 = new System.Windows.Forms.PictureBox();
            this.heart2 = new System.Windows.Forms.PictureBox();
            this.heart1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblEnter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.Ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.heart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.heart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.heart1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLives
            // 
            this.lblLives.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (0)))),
                ((int) (((byte) (64)))));
            this.lblLives.Font = new System.Drawing.Font("Impact", 18F,
                ((System.Drawing.FontStyle) ((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))),
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblLives.ForeColor = System.Drawing.Color.White;
            this.lblLives.Location = new System.Drawing.Point(-1, 0);
            this.lblLives.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLives.Name = "lblLives";
            this.lblLives.Size = new System.Drawing.Size(247, 57);
            this.lblLives.TabIndex = 0;
            this.lblLives.Text = "LIVES:";
            this.lblLives.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picLogo
            // 
            this.picLogo.Anchor =
                ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.picLogo.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (0)))),
                ((int) (((byte) (64)))));
            this.picLogo.Image = ((System.Drawing.Image) (resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(240, 0);
            this.picLogo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(387, 57);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // lblScore
            // 
            this.lblScore.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.lblScore.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (0)))),
                ((int) (((byte) (64)))));
            this.lblScore.Font = new System.Drawing.Font("Impact", 18F,
                ((System.Drawing.FontStyle) ((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))),
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(625, 0);
            this.lblScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(238, 57);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "SCORE:";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // player
            // 
            this.player.Image = global::IArkanoid.Properties.Resources.player;
            this.player.Location = new System.Drawing.Point(296, 450);
            this.player.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(162, 37);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 3;
            this.player.TabStop = false;
            // 
            // Ball
            // 
            this.Ball.BackColor = System.Drawing.Color.Transparent;
            this.Ball.Image = global::IArkanoid.Properties.Resources.circle_cropped;
            this.Ball.Location = new System.Drawing.Point(362, 411);
            this.Ball.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(34, 33);
            this.Ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ball.TabIndex = 4;
            this.Ball.TabStop = false;
            // 
            // heart3
            // 
            this.heart3.BackColor = System.Drawing.Color.Transparent;
            this.heart3.Image = global::IArkanoid.Properties.Resources.corazon;
            this.heart3.Location = new System.Drawing.Point(79, 180);
            this.heart3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.heart3.Name = "heart3";
            this.heart3.Size = new System.Drawing.Size(34, 33);
            this.heart3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.heart3.TabIndex = 5;
            this.heart3.TabStop = false;
            // 
            // heart2
            // 
            this.heart2.BackColor = System.Drawing.Color.Transparent;
            this.heart2.Image = global::IArkanoid.Properties.Resources.corazon;
            this.heart2.Location = new System.Drawing.Point(40, 180);
            this.heart2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.heart2.Name = "heart2";
            this.heart2.Size = new System.Drawing.Size(34, 33);
            this.heart2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.heart2.TabIndex = 6;
            this.heart2.TabStop = false;
            // 
            // heart1
            // 
            this.heart1.BackColor = System.Drawing.Color.Transparent;
            this.heart1.Image = global::IArkanoid.Properties.Resources.corazon;
            this.heart1.Location = new System.Drawing.Point(0, 180);
            this.heart1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.heart1.Name = "heart1";
            this.heart1.Size = new System.Drawing.Size(34, 33);
            this.heart1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.heart1.TabIndex = 7;
            this.heart1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblEnter
            // 
            this.lblEnter.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (0)))),
                ((int) (((byte) (64)))));
            this.lblEnter.Font = new System.Drawing.Font("Impact", 26.25F,
                ((System.Drawing.FontStyle) ((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))),
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblEnter.ForeColor = System.Drawing.Color.White;
            this.lblEnter.Location = new System.Drawing.Point(285, 180);
            this.lblEnter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(345, 108);
            this.lblEnter.TabIndex = 8;
            this.lblEnter.Text = "PRESS ENTER TO START";
            this.lblEnter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(862, 510);
            this.Controls.Add(this.lblEnter);
            this.Controls.Add(this.heart1);
            this.Controls.Add(this.heart2);
            this.Controls.Add(this.heart3);
            this.Controls.Add(this.Ball);
            this.Controls.Add(this.player);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.lblLives);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "NewGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewGame";
            this.Load += new System.EventHandler(this.NewGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NewGame_KeyDown);
            ((System.ComponentModel.ISupportInitialize) (this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.Ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.heart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.heart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.heart1)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblLives;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox Ball;
        private System.Windows.Forms.PictureBox heart1;
        private System.Windows.Forms.PictureBox heart2;
        private System.Windows.Forms.PictureBox heart3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblEnter;
        private System.Windows.Forms.PictureBox picLogo;
    }
}