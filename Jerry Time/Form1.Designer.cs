namespace Jerry_Time
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.Gravity = new System.Windows.Forms.Timer(this.components);
            this.lblControls = new System.Windows.Forms.Label();
            this.lblHighScore = new System.Windows.Forms.Label();
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
            this.myBox.InitialImage = null;
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
            this.BottomSquare.BackColor = System.Drawing.Color.Transparent;
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
            this.TopSquare.BackColor = System.Drawing.Color.Transparent;
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
            this.lblDistance.BackColor = System.Drawing.Color.Transparent;
            this.lblDistance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDistance.Location = new System.Drawing.Point(371, 368);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(19, 21);
            this.lblDistance.TabIndex = 3;
            this.lblDistance.Text = "0";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblScore.Location = new System.Drawing.Point(357, 389);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(65, 21);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "Score: 0";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStart.Location = new System.Drawing.Point(200, 135);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(373, 169);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.Transparent;
            this.btnRestart.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRestart.Location = new System.Drawing.Point(12, 12);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(197, 81);
            this.btnRestart.TabIndex = 6;
            this.btnRestart.Text = "Restart?";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // Gravity
            // 
            this.Gravity.Tick += new System.EventHandler(this.Gravity_Tick);
            // 
            // lblControls
            // 
            this.lblControls.AutoSize = true;
            this.lblControls.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblControls.Location = new System.Drawing.Point(303, 307);
            this.lblControls.Name = "lblControls";
            this.lblControls.Size = new System.Drawing.Size(185, 21);
            this.lblControls.TabIndex = 7;
            this.lblControls.Text = "Space Is the Only Control";
            // 
            // lblHighScore
            // 
            this.lblHighScore.AutoSize = true;
            this.lblHighScore.BackColor = System.Drawing.Color.Transparent;
            this.lblHighScore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHighScore.Location = new System.Drawing.Point(338, 410);
            this.lblHighScore.Name = "lblHighScore";
            this.lblHighScore.Size = new System.Drawing.Size(102, 21);
            this.lblHighScore.TabIndex = 8;
            this.lblHighScore.Text = "High Score: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 440);
            this.Controls.Add(this.lblHighScore);
            this.Controls.Add(this.lblControls);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.myBox);
            this.Controls.Add(this.TopSquare);
            this.Controls.Add(this.BottomSquare);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
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
        private Button btnStart;
        private Button btnRestart;
        private System.Windows.Forms.Timer Gravity;
        private Label lblControls;
        private Label lblHighScore;
    }
}