
namespace FlappyBird
{
    partial class FlappyBird
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
            this.birdHitBox = new System.Windows.Forms.PictureBox();
            this.groundPicture = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.restartButton = new System.Windows.Forms.Button();
            this.pipeDown = new System.Windows.Forms.PictureBox();
            this.pipe = new System.Windows.Forms.PictureBox();
            this.pipeDown2 = new System.Windows.Forms.PictureBox();
            this.pipe2 = new System.Windows.Forms.PictureBox();
            this.pipeDown3 = new System.Windows.Forms.PictureBox();
            this.pipe3 = new System.Windows.Forms.PictureBox();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.checkCollisionTimer = new System.Windows.Forms.Timer(this.components);
            this.birdPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.birdHitBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groundPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birdPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // birdHitBox
            // 
            this.birdHitBox.Image = global::FlappyBird.Properties.Resources.bird;
            this.birdHitBox.ImageLocation = "";
            this.birdHitBox.Location = new System.Drawing.Point(50, 150);
            this.birdHitBox.Name = "birdHitBox";
            this.birdHitBox.Size = new System.Drawing.Size(30, 20);
            this.birdHitBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.birdHitBox.TabIndex = 0;
            this.birdHitBox.TabStop = false;
            // 
            // groundPicture
            // 
            this.groundPicture.Image = global::FlappyBird.Properties.Resources.ground;
            this.groundPicture.Location = new System.Drawing.Point(-2, 383);
            this.groundPicture.Name = "groundPicture";
            this.groundPicture.Size = new System.Drawing.Size(800, 150);
            this.groundPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.groundPicture.TabIndex = 1;
            this.groundPicture.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // restartButton
            // 
            this.restartButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.restartButton.CausesValidation = false;
            this.restartButton.Location = new System.Drawing.Point(300, 175);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(200, 50);
            this.restartButton.TabIndex = 2;
            this.restartButton.TabStop = false;
            this.restartButton.Text = "RESTART";
            this.restartButton.UseVisualStyleBackColor = false;
            this.restartButton.Visible = false;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            this.restartButton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.jump);
            // 
            // pipeDown
            // 
            this.pipeDown.Image = global::FlappyBird.Properties.Resources.pipedown;
            this.pipeDown.Location = new System.Drawing.Point(650, -100);
            this.pipeDown.Name = "pipeDown";
            this.pipeDown.Size = new System.Drawing.Size(100, 250);
            this.pipeDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeDown.TabIndex = 3;
            this.pipeDown.TabStop = false;
            // 
            // pipe
            // 
            this.pipe.Image = global::FlappyBird.Properties.Resources.pipe;
            this.pipe.Location = new System.Drawing.Point(650, 300);
            this.pipe.Name = "pipe";
            this.pipe.Size = new System.Drawing.Size(100, 250);
            this.pipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipe.TabIndex = 4;
            this.pipe.TabStop = false;
            // 
            // pipeDown2
            // 
            this.pipeDown2.Image = global::FlappyBird.Properties.Resources.pipedown;
            this.pipeDown2.Location = new System.Drawing.Point(450, -150);
            this.pipeDown2.Name = "pipeDown2";
            this.pipeDown2.Size = new System.Drawing.Size(100, 250);
            this.pipeDown2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeDown2.TabIndex = 5;
            this.pipeDown2.TabStop = false;
            // 
            // pipe2
            // 
            this.pipe2.Image = global::FlappyBird.Properties.Resources.pipe;
            this.pipe2.Location = new System.Drawing.Point(450, 250);
            this.pipe2.Name = "pipe2";
            this.pipe2.Size = new System.Drawing.Size(100, 250);
            this.pipe2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipe2.TabIndex = 6;
            this.pipe2.TabStop = false;
            // 
            // pipeDown3
            // 
            this.pipeDown3.Image = global::FlappyBird.Properties.Resources.pipedown;
            this.pipeDown3.Location = new System.Drawing.Point(850, 0);
            this.pipeDown3.Name = "pipeDown3";
            this.pipeDown3.Size = new System.Drawing.Size(100, 250);
            this.pipeDown3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeDown3.TabIndex = 7;
            this.pipeDown3.TabStop = false;
            // 
            // pipe3
            // 
            this.pipe3.Image = global::FlappyBird.Properties.Resources.pipe;
            this.pipe3.Location = new System.Drawing.Point(850, 400);
            this.pipe3.Name = "pipe3";
            this.pipe3.Size = new System.Drawing.Size(100, 250);
            this.pipe3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipe3.TabIndex = 8;
            this.pipe3.TabStop = false;
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.Color.Bisque;
            this.scoreLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.scoreLabel.Location = new System.Drawing.Point(350, 419);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(77, 25);
            this.scoreLabel.TabIndex = 11;
            this.scoreLabel.Text = "Score:";
            // 
            // checkCollisionTimer
            // 
            this.checkCollisionTimer.Enabled = true;
            this.checkCollisionTimer.Interval = 5;
            this.checkCollisionTimer.Tick += new System.EventHandler(this.checkEvent);
            // 
            // birdPicture
            // 
            this.birdPicture.Image = global::FlappyBird.Properties.Resources.bird;
            this.birdPicture.Location = new System.Drawing.Point(50, 150);
            this.birdPicture.Name = "birdPicture";
            this.birdPicture.Size = new System.Drawing.Size(40, 30);
            this.birdPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.birdPicture.TabIndex = 12;
            this.birdPicture.TabStop = false;
            // 
            // FlappyBird
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.birdPicture);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.groundPicture);
            this.Controls.Add(this.pipeDown3);
            this.Controls.Add(this.pipeDown2);
            this.Controls.Add(this.pipe);
            this.Controls.Add(this.pipeDown);
            this.Controls.Add(this.pipe2);
            this.Controls.Add(this.pipe3);
            this.Controls.Add(this.birdHitBox);
            this.Name = "FlappyBird";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flappy Bird";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.jump);
            ((System.ComponentModel.ISupportInitialize)(this.birdHitBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groundPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birdPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox birdHitBox;

        private PictureBox groundPicture;
        private System.Windows.Forms.Timer gameTimer;
        private Button restartButton;
        private PictureBox pipeDown;
        private PictureBox pipe;
        private PictureBox pipeDown2;
        private PictureBox pipe2;
        private PictureBox pipeDown3;
        private PictureBox pipe3;
        private Label scoreLabel;
        private System.Windows.Forms.Timer checkCollisionTimer;
        private PictureBox birdPicture;
    }
}