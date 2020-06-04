using System.ComponentModel;

namespace IArkanoid
{
    partial class Game
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.lblLives = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.ptbLogo = new System.Windows.Forms.PictureBox();
            this.heart1 = new System.Windows.Forms.PictureBox();
            this.heart3 = new System.Windows.Forms.PictureBox();
            this.heart2 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            this.Ball = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize) (this.ptbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.heart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.heart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.heart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.Ball)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLives
            // 
            this.lblLives.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (0)))),
                ((int) (((byte) (64)))));
            this.lblLives.Font = new System.Drawing.Font("Impact", 20.25F,
                ((System.Drawing.FontStyle) ((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))),
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblLives.ForeColor = System.Drawing.Color.White;
            this.lblLives.Location = new System.Drawing.Point(0, 0);
            this.lblLives.Name = "lblLives";
            this.lblLives.Size = new System.Drawing.Size(234, 72);
            this.lblLives.TabIndex = 0;
            this.lblLives.Text = "LIVES:";
            this.lblLives.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblScore
            // 
            this.lblScore.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (0)))),
                ((int) (((byte) (64)))));
            this.lblScore.Font = new System.Drawing.Font("Impact", 20.25F,
                ((System.Drawing.FontStyle) ((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))),
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(607, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(229, 72);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "SCORE:";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ptbLogo
            // 
            this.ptbLogo.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (0)))),
                ((int) (((byte) (64)))));
            this.ptbLogo.Image = ((System.Drawing.Image) (resources.GetObject("ptbLogo.Image")));
            this.ptbLogo.Location = new System.Drawing.Point(233, 0);
            this.ptbLogo.Name = "ptbLogo";
            this.ptbLogo.Size = new System.Drawing.Size(378, 72);
            this.ptbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbLogo.TabIndex = 2;
            this.ptbLogo.TabStop = false;
            // 
            // heart1
            // 
            this.heart1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (0)))),
                ((int) (((byte) (64)))));
            this.heart1.Image = ((System.Drawing.Image) (resources.GetObject("heart1.Image")));
            this.heart1.Location = new System.Drawing.Point(98, 20);
            this.heart1.Name = "heart1";
            this.heart1.Size = new System.Drawing.Size(33, 33);
            this.heart1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.heart1.TabIndex = 3;
            this.heart1.TabStop = false;
            // 
            // heart3
            // 
            this.heart3.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (0)))),
                ((int) (((byte) (64)))));
            this.heart3.Image = ((System.Drawing.Image) (resources.GetObject("heart3.Image")));
            this.heart3.Location = new System.Drawing.Point(194, 20);
            this.heart3.Name = "heart3";
            this.heart3.Size = new System.Drawing.Size(33, 33);
            this.heart3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.heart3.TabIndex = 4;
            this.heart3.TabStop = false;
            // 
            // heart2
            // 
            this.heart2.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (0)))),
                ((int) (((byte) (64)))));
            this.heart2.Image = ((System.Drawing.Image) (resources.GetObject("heart2.Image")));
            this.heart2.Location = new System.Drawing.Point(146, 20);
            this.heart2.Name = "heart2";
            this.heart2.Size = new System.Drawing.Size(33, 33);
            this.heart2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.heart2.TabIndex = 5;
            this.heart2.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (0)))),
                ((int) (((byte) (64)))));
            this.pictureBox12.Image = global::IArkanoid.Properties.Resources.bloque_cafe;
            this.pictureBox12.Location = new System.Drawing.Point(717, 138);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(117, 42);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 33;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Tag = "block";
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (0)))),
                ((int) (((byte) (64)))));
            this.pictureBox13.Image = global::IArkanoid.Properties.Resources.bloque_rojo;
            this.pictureBox13.Location = new System.Drawing.Point(576, 138);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(147, 42);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox13.TabIndex = 32;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.Tag = "block";
            // 
            // pictureBox14
            // 
            this.pictureBox14.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (0)))),
                ((int) (((byte) (64)))));
            this.pictureBox14.Image = global::IArkanoid.Properties.Resources.bloque_cafe;
            this.pictureBox14.Location = new System.Drawing.Point(486, 138);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(93, 42);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox14.TabIndex = 31;
            this.pictureBox14.TabStop = false;
            this.pictureBox14.Tag = "block";
            // 
            // pictureBox15
            // 
            this.pictureBox15.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (0)))),
                ((int) (((byte) (64)))));
            this.pictureBox15.Image = global::IArkanoid.Properties.Resources.bloque_rojo;
            this.pictureBox15.Location = new System.Drawing.Point(348, 138);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(139, 42);
            this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox15.TabIndex = 30;
            this.pictureBox15.TabStop = false;
            this.pictureBox15.Tag = "block";
            // 
            // pictureBox16
            // 
            this.pictureBox16.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (0)))),
                ((int) (((byte) (64)))));
            this.pictureBox16.Image = global::IArkanoid.Properties.Resources.bloque_cafe;
            this.pictureBox16.Location = new System.Drawing.Point(258, 138);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(93, 42);
            this.pictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox16.TabIndex = 29;
            this.pictureBox16.TabStop = false;
            this.pictureBox16.Tag = "block";
            // 
            // pictureBox17
            // 
            this.pictureBox17.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (0)))),
                ((int) (((byte) (64)))));
            this.pictureBox17.Image = global::IArkanoid.Properties.Resources.bloque_rojo;
            this.pictureBox17.Location = new System.Drawing.Point(114, 138);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(147, 42);
            this.pictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox17.TabIndex = 28;
            this.pictureBox17.TabStop = false;
            this.pictureBox17.Tag = "block";
            // 
            // pictureBox18
            // 
            this.pictureBox18.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (0)))),
                ((int) (((byte) (64)))));
            this.pictureBox18.Image = global::IArkanoid.Properties.Resources.bloque_cafe;
            this.pictureBox18.Location = new System.Drawing.Point(0, 138);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(117, 42);
            this.pictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox18.TabIndex = 27;
            this.pictureBox18.TabStop = false;
            this.pictureBox18.Tag = "block";
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (0)))),
                ((int) (((byte) (64)))));
            this.pictureBox11.Image = global::IArkanoid.Properties.Resources.bloque_amarillo;
            this.pictureBox11.Location = new System.Drawing.Point(717, 100);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(117, 42);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 26;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Tag = "block";
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (0)))),
                ((int) (((byte) (64)))));
            this.pictureBox10.Image = global::IArkanoid.Properties.Resources.bloque_naranja;
            this.pictureBox10.Location = new System.Drawing.Point(576, 100);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(147, 42);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 25;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Tag = "block";
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (0)))),
                ((int) (((byte) (64)))));
            this.pictureBox9.Image = global::IArkanoid.Properties.Resources.bloque_amarillo;
            this.pictureBox9.Location = new System.Drawing.Point(486, 100);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(93, 42);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 24;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Tag = "block";
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (0)))),
                ((int) (((byte) (64)))));
            this.pictureBox8.Image = global::IArkanoid.Properties.Resources.bloque_naranja;
            this.pictureBox8.Location = new System.Drawing.Point(348, 100);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(139, 42);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 23;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Tag = "block";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (0)))),
                ((int) (((byte) (64)))));
            this.pictureBox7.Image = global::IArkanoid.Properties.Resources.bloque_amarillo;
            this.pictureBox7.Location = new System.Drawing.Point(258, 100);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(93, 42);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 22;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "block";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (0)))),
                ((int) (((byte) (64)))));
            this.pictureBox6.Image = global::IArkanoid.Properties.Resources.bloque_naranja;
            this.pictureBox6.Location = new System.Drawing.Point(114, 100);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(147, 42);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 21;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "block";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (0)))),
                ((int) (((byte) (64)))));
            this.pictureBox5.Image = global::IArkanoid.Properties.Resources.bloque_amarillo;
            this.pictureBox5.Location = new System.Drawing.Point(0, 100);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(117, 42);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 20;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "block";
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (0)))),
                ((int) (((byte) (64)))));
            this.Player.Image = global::IArkanoid.Properties.Resources.player;
            this.Player.Location = new System.Drawing.Point(352, 636);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(135, 42);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player.TabIndex = 34;
            this.Player.TabStop = false;
            this.Player.Tag = "";
            // 
            // Ball
            // 
            this.Ball.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (0)))),
                ((int) (((byte) (64)))));
            this.Ball.Image = global::IArkanoid.Properties.Resources.circle_cropped;
            this.Ball.Location = new System.Drawing.Point(402, 597);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(33, 33);
            this.Ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ball.TabIndex = 35;
            this.Ball.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 5;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.Ball);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.pictureBox14);
            this.Controls.Add(this.pictureBox15);
            this.Controls.Add(this.pictureBox16);
            this.Controls.Add(this.pictureBox17);
            this.Controls.Add(this.pictureBox18);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.heart2);
            this.Controls.Add(this.heart3);
            this.Controls.Add(this.heart1);
            this.Controls.Add(this.ptbLogo);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblLives);
            this.DoubleBuffered = true;
            this.Name = "Game";
            this.Size = new System.Drawing.Size(835, 707);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            ((System.ComponentModel.ISupportInitialize) (this.ptbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.heart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.heart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.heart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.Ball)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox18;
        private System.Windows.Forms.PictureBox pictureBox17;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox heart2;
        private System.Windows.Forms.PictureBox heart3;
        private System.Windows.Forms.PictureBox heart1;
        private System.Windows.Forms.PictureBox Ball;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox ptbLogo;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblLives;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}