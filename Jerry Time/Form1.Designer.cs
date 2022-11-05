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
            ((System.ComponentModel.ISupportInitialize)(this.myBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomSquare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopSquare)).BeginInit();
            this.SuspendLayout();
            // 
            // myBox
            // 
            this.myBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.myBox.Location = new System.Drawing.Point(42, 164);
            this.myBox.Name = "myBox";
            this.myBox.Size = new System.Drawing.Size(80, 80);
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
            this.BottomSquare.BackColor = System.Drawing.Color.Red;
            this.BottomSquare.Location = new System.Drawing.Point(700, 297);
            this.BottomSquare.Name = "BottomSquare";
            this.BottomSquare.Size = new System.Drawing.Size(100, 276);
            this.BottomSquare.TabIndex = 1;
            this.BottomSquare.TabStop = false;
            // 
            // TopSquare
            // 
            this.TopSquare.BackColor = System.Drawing.Color.Red;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.myBox);
            this.Controls.Add(this.TopSquare);
            this.Controls.Add(this.BottomSquare);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.myBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomSquare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopSquare)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox myBox;
        private System.Windows.Forms.Timer PipesTimer;
        private PictureBox BottomSquare;
        private PictureBox TopSquare;
        private System.Windows.Forms.Timer Collision;
    }
}