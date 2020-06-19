using System.ComponentModel;

namespace IArkanoid
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.lbluser = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnContinue = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize) (this.picLogo)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbluser
            // 
            this.lbluser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbluser.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Italic,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbluser.ForeColor = System.Drawing.Color.White;
            this.lbluser.Location = new System.Drawing.Point(126, 253);
            this.lbluser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(157, 110);
            this.lbluser.TabIndex = 1;
            this.lbluser.Text = "USUARIO:";
            this.lbluser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picLogo
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.picLogo, 4);
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picLogo.Image = ((System.Drawing.Image) (resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(2, 3);
            this.picLogo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.picLogo.Name = "picLogo";
            this.tableLayoutPanel1.SetRowSpan(this.picLogo, 2);
            this.picLogo.Size = new System.Drawing.Size(830, 247);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))),
                ((int) (((byte) (0)))), ((int) (((byte) (67)))));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.86811F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.30456F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.64748F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnContinue, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.picLogo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbluser, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtUser, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.76375F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.56958F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(834, 661);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnContinue
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnContinue, 4);
            this.btnContinue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnContinue.FlatAppearance.BorderSize = 0;
            this.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinue.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Italic,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnContinue.ForeColor = System.Drawing.Color.Yellow;
            this.btnContinue.Location = new System.Drawing.Point(2, 442);
            this.btnContinue.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(830, 104);
            this.btnContinue.TabIndex = 3;
            this.btnContinue.Text = "CONTINUAR";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // txtUser
            // 
            this.txtUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUser.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Italic,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtUser.Location = new System.Drawing.Point(287, 284);
            this.txtUser.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(334, 47);
            this.txtUser.TabIndex = 2;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(834, 661);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize) (this.picLogo)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lbluser;
    }
}