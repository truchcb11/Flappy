namespace Flappy
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
            this.txt_Score = new System.Windows.Forms.Label();
            this.gametime = new System.Windows.Forms.Timer(this.components);
            this.RestartIm = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.RestartIm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Score
            // 
            this.txt_Score.AutoSize = true;
            this.txt_Score.BackColor = System.Drawing.Color.LightYellow;
            this.txt_Score.Font = new System.Drawing.Font("Arial", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Score.Location = new System.Drawing.Point(12, 705);
            this.txt_Score.Name = "txt_Score";
            this.txt_Score.Size = new System.Drawing.Size(192, 51);
            this.txt_Score.TabIndex = 4;
            this.txt_Score.Text = "Score: 0";
            // 
            // gametime
            // 
            this.gametime.Enabled = true;
            this.gametime.Interval = 20;
            this.gametime.Tick += new System.EventHandler(this.GameTimeEven);
            // 
            // RestartIm
            // 
            this.RestartIm.Image = global::Flappy.Properties.Resources.restart;
            this.RestartIm.Location = new System.Drawing.Point(341, 157);
            this.RestartIm.Name = "RestartIm";
            this.RestartIm.Size = new System.Drawing.Size(298, 279);
            this.RestartIm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RestartIm.TabIndex = 5;
            this.RestartIm.TabStop = false;
            this.RestartIm.Click += new System.EventHandler(this.RestartClickEvent);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Flappy.Properties.Resources.bird;
            this.pictureBox1.Location = new System.Drawing.Point(150, 317);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::Flappy.Properties.Resources.ground;
            this.pictureBox2.Location = new System.Drawing.Point(-7, 683);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(979, 73);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Flappy.Properties.Resources.pipe;
            this.pictureBox4.Location = new System.Drawing.Point(509, 456);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 289);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Flappy.Properties.Resources.pipedown;
            this.pictureBox3.Location = new System.Drawing.Point(831, -30);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 301);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(964, 757);
            this.Controls.Add(this.RestartIm);
            this.Controls.Add(this.txt_Score);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameKerisDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameKeyisUp);
            ((System.ComponentModel.ISupportInitialize)(this.RestartIm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label txt_Score;
        private System.Windows.Forms.Timer gametime;
        private System.Windows.Forms.PictureBox RestartIm;
    }
}

