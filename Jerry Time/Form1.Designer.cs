﻿namespace Jerry_Time
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.myBox = new System.Windows.Forms.PictureBox();
            this.PipesTimer = new System.Windows.Forms.Timer(this.components);
            this.BottomSquare = new System.Windows.Forms.PictureBox();
            this.TopSquare = new System.Windows.Forms.PictureBox();
            this.Collision = new System.Windows.Forms.Timer(this.components);
            this.lblDistance = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.myBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomSquare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopSquare)).BeginInit();
            this.SuspendLayout();
            // 
            // myBox
            // 
            this.myBox.BackColor = System.Drawing.Color.Transparent;
            this.myBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.myBox.Image = global::Jerry_Time.Properties.Resources.Smiley;
            this.myBox.Location = new System.Drawing.Point(357, 203);
            this.myBox.Name = "myBox";
            this.myBox.Size = new System.Drawing.Size(60, 60);
            this.myBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.myBox.TabIndex = 0;
            this.myBox.TabStop = false;
            this.myBox.Click += new System.EventHandler(this.myBox_Click);
            // 
            // PipesTimer
            // 
            this.PipesTimer.Tick += new System.EventHandler(this.PipesTimer_Tick);
            // 
            // BottomSquare
            // 
            this.BottomSquare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BottomSquare.BackgroundImage = global::Jerry_Time.Properties.Resources.Pipe;
            this.BottomSquare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BottomSquare.Location = new System.Drawing.Point(700, 295);
            this.BottomSquare.Name = "BottomSquare";
            this.BottomSquare.Size = new System.Drawing.Size(100, 153);
            this.BottomSquare.TabIndex = 1;
            this.BottomSquare.TabStop = false;
            // 
            // TopSquare
            // 
            this.TopSquare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TopSquare.BackgroundImage = global::Jerry_Time.Properties.Resources.UpsideDown_Pipe;
            this.TopSquare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TopSquare.Location = new System.Drawing.Point(700, 0);
            this.TopSquare.Name = "TopSquare";
            this.TopSquare.Size = new System.Drawing.Size(100, 153);
            this.TopSquare.TabIndex = 2;
            this.TopSquare.TabStop = false;
            // 
            // Collision
            // 
            this.Collision.Tick += new System.EventHandler(this.Collision_Tick);
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDistance.Location = new System.Drawing.Point(370, 389);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(19, 21);
            this.lblDistance.TabIndex = 3;
            this.lblDistance.Text = "0";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblScore.Location = new System.Drawing.Point(356, 410);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(65, 21);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "Score: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 440);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.myBox);
            this.Controls.Add(this.TopSquare);
            this.Controls.Add(this.BottomSquare);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomSquare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopSquare)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox myBox;
        private System.Windows.Forms.Timer PipesTimer;
        private PictureBox BottomSquare;
        private PictureBox TopSquare;
        private System.Windows.Forms.Timer Collision;
        private Label lblDistance;
        private Label lblScore;
    }
}