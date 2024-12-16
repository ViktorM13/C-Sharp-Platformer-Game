namespace Platformer
{
    partial class Window
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
            this.scoreText = new System.Windows.Forms.Label();
            this.ground2 = new System.Windows.Forms.PictureBox();
            this.ground1 = new System.Windows.Forms.PictureBox();
            this.stone1 = new System.Windows.Forms.PictureBox();
            this.stone2 = new System.Windows.Forms.PictureBox();
            this.stone3 = new System.Windows.Forms.PictureBox();
            this.horizontalMovingStone = new System.Windows.Forms.PictureBox();
            this.stone4 = new System.Windows.Forms.PictureBox();
            this.stone5 = new System.Windows.Forms.PictureBox();
            this.stone7 = new System.Windows.Forms.PictureBox();
            this.verticalMovingStone = new System.Windows.Forms.PictureBox();
            this.stone6 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.pointer = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.enemy2 = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.enemy1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ground2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stone1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stone2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stone3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horizontalMovingStone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stone4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stone5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stone7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verticalMovingStone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stone6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreText
            // 
            this.scoreText.BackColor = System.Drawing.Color.Transparent;
            this.scoreText.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scoreText.Location = new System.Drawing.Point(660, 9);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(212, 78);
            this.scoreText.TabIndex = 0;
            this.scoreText.Text = "Score:0";
            this.scoreText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ground2
            // 
            this.ground2.Image = ((System.Drawing.Image)(resources.GetObject("ground2.Image")));
            this.ground2.Location = new System.Drawing.Point(585, 510);
            this.ground2.Name = "ground2";
            this.ground2.Size = new System.Drawing.Size(300, 50);
            this.ground2.TabIndex = 4;
            this.ground2.TabStop = false;
            this.ground2.Tag = "platform";
            // 
            // ground1
            // 
            this.ground1.Image = ((System.Drawing.Image)(resources.GetObject("ground1.Image")));
            this.ground1.Location = new System.Drawing.Point(0, 510);
            this.ground1.Name = "ground1";
            this.ground1.Size = new System.Drawing.Size(300, 50);
            this.ground1.TabIndex = 5;
            this.ground1.TabStop = false;
            this.ground1.Tag = "platform";
            // 
            // stone1
            // 
            this.stone1.Image = ((System.Drawing.Image)(resources.GetObject("stone1.Image")));
            this.stone1.Location = new System.Drawing.Point(255, 430);
            this.stone1.Name = "stone1";
            this.stone1.Size = new System.Drawing.Size(100, 20);
            this.stone1.TabIndex = 7;
            this.stone1.TabStop = false;
            this.stone1.Tag = "platform";
            // 
            // stone2
            // 
            this.stone2.Image = ((System.Drawing.Image)(resources.GetObject("stone2.Image")));
            this.stone2.Location = new System.Drawing.Point(56, 370);
            this.stone2.Name = "stone2";
            this.stone2.Size = new System.Drawing.Size(100, 20);
            this.stone2.TabIndex = 8;
            this.stone2.TabStop = false;
            this.stone2.Tag = "platform";
            // 
            // stone3
            // 
            this.stone3.Image = ((System.Drawing.Image)(resources.GetObject("stone3.Image")));
            this.stone3.Location = new System.Drawing.Point(215, 314);
            this.stone3.Name = "stone3";
            this.stone3.Size = new System.Drawing.Size(100, 20);
            this.stone3.TabIndex = 9;
            this.stone3.TabStop = false;
            this.stone3.Tag = "platform";
            // 
            // horizontalMovingStone
            // 
            this.horizontalMovingStone.Image = ((System.Drawing.Image)(resources.GetObject("horizontalMovingStone.Image")));
            this.horizontalMovingStone.Location = new System.Drawing.Point(340, 265);
            this.horizontalMovingStone.Name = "horizontalMovingStone";
            this.horizontalMovingStone.Size = new System.Drawing.Size(100, 20);
            this.horizontalMovingStone.TabIndex = 10;
            this.horizontalMovingStone.TabStop = false;
            this.horizontalMovingStone.Tag = "horizontalPlatform";
            // 
            // stone4
            // 
            this.stone4.Image = ((System.Drawing.Image)(resources.GetObject("stone4.Image")));
            this.stone4.Location = new System.Drawing.Point(68, 249);
            this.stone4.Name = "stone4";
            this.stone4.Size = new System.Drawing.Size(100, 20);
            this.stone4.TabIndex = 11;
            this.stone4.TabStop = false;
            this.stone4.Tag = "platform";
            // 
            // stone5
            // 
            this.stone5.Image = ((System.Drawing.Image)(resources.GetObject("stone5.Image")));
            this.stone5.Location = new System.Drawing.Point(562, 350);
            this.stone5.Name = "stone5";
            this.stone5.Size = new System.Drawing.Size(100, 20);
            this.stone5.TabIndex = 12;
            this.stone5.TabStop = false;
            this.stone5.Tag = "platform";
            // 
            // stone7
            // 
            this.stone7.Image = ((System.Drawing.Image)(resources.GetObject("stone7.Image")));
            this.stone7.Location = new System.Drawing.Point(693, 420);
            this.stone7.Name = "stone7";
            this.stone7.Size = new System.Drawing.Size(100, 20);
            this.stone7.TabIndex = 13;
            this.stone7.TabStop = false;
            this.stone7.Tag = "platform";
            // 
            // verticalMovingStone
            // 
            this.verticalMovingStone.Image = ((System.Drawing.Image)(resources.GetObject("verticalMovingStone.Image")));
            this.verticalMovingStone.Location = new System.Drawing.Point(760, 190);
            this.verticalMovingStone.Name = "verticalMovingStone";
            this.verticalMovingStone.Size = new System.Drawing.Size(100, 20);
            this.verticalMovingStone.TabIndex = 14;
            this.verticalMovingStone.TabStop = false;
            this.verticalMovingStone.Tag = "verticalPlatform";
            // 
            // stone6
            // 
            this.stone6.Image = ((System.Drawing.Image)(resources.GetObject("stone6.Image")));
            this.stone6.Location = new System.Drawing.Point(609, 158);
            this.stone6.Name = "stone6";
            this.stone6.Size = new System.Drawing.Size(100, 20);
            this.stone6.TabIndex = 15;
            this.stone6.TabStop = false;
            this.stone6.Tag = "platform";
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = ((System.Drawing.Image)(resources.GetObject("player.Image")));
            this.player.Location = new System.Drawing.Point(55, 460);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(35, 50);
            this.player.TabIndex = 16;
            this.player.TabStop = false;
            this.player.Tag = "player";
            // 
            // pointer
            // 
            this.pointer.BackColor = System.Drawing.Color.Transparent;
            this.pointer.Image = ((System.Drawing.Image)(resources.GetObject("pointer.Image")));
            this.pointer.Location = new System.Drawing.Point(830, 470);
            this.pointer.Name = "pointer";
            this.pointer.Size = new System.Drawing.Size(45, 40);
            this.pointer.TabIndex = 17;
            this.pointer.TabStop = false;
            this.pointer.Tag = "pointer";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(174, 479);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "coin";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(205, 479);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "coin";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(236, 479);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.TabIndex = 33;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "coin";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(267, 479);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 25);
            this.pictureBox4.TabIndex = 34;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "coin";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(119, 218);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(25, 25);
            this.pictureBox5.TabIndex = 36;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "coin";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(88, 218);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(25, 25);
            this.pictureBox6.TabIndex = 35;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "coin";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(663, 127);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(25, 25);
            this.pictureBox7.TabIndex = 38;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "coin";
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(632, 127);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(25, 25);
            this.pictureBox8.TabIndex = 37;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Tag = "coin";
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(632, 479);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(25, 25);
            this.pictureBox9.TabIndex = 40;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Tag = "coin";
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(601, 479);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(25, 25);
            this.pictureBox10.TabIndex = 39;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Tag = "coin";
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(693, 479);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(25, 25);
            this.pictureBox11.TabIndex = 42;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Tag = "coin";
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.Location = new System.Drawing.Point(662, 479);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(25, 25);
            this.pictureBox12.TabIndex = 41;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Tag = "coin";
            // 
            // enemy2
            // 
            this.enemy2.BackColor = System.Drawing.Color.Transparent;
            this.enemy2.Image = ((System.Drawing.Image)(resources.GetObject("enemy2.Image")));
            this.enemy2.Location = new System.Drawing.Point(630, 325);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(25, 25);
            this.enemy2.TabIndex = 43;
            this.enemy2.TabStop = false;
            this.enemy2.Tag = "enemy";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tag = "timer";
            this.gameTimer.Tick += new System.EventHandler(this.MainGameTimerEvent);
            // 
            // enemy1
            // 
            this.enemy1.BackColor = System.Drawing.Color.Transparent;
            this.enemy1.Image = ((System.Drawing.Image)(resources.GetObject("enemy1.Image")));
            this.enemy1.Location = new System.Drawing.Point(267, 405);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(25, 25);
            this.enemy1.TabIndex = 44;
            this.enemy1.TabStop = false;
            this.enemy1.Tag = "enemy";
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.enemy1);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pointer);
            this.Controls.Add(this.player);
            this.Controls.Add(this.stone6);
            this.Controls.Add(this.verticalMovingStone);
            this.Controls.Add(this.stone7);
            this.Controls.Add(this.stone5);
            this.Controls.Add(this.stone4);
            this.Controls.Add(this.horizontalMovingStone);
            this.Controls.Add(this.stone3);
            this.Controls.Add(this.stone2);
            this.Controls.Add(this.stone1);
            this.Controls.Add(this.ground1);
            this.Controls.Add(this.ground2);
            this.Controls.Add(this.scoreText);
            this.Name = "Window";
            this.Text = "Platformer";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.ground2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stone1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stone2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stone3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horizontalMovingStone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stone4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stone5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stone7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verticalMovingStone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stone6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.PictureBox ground2;
        private System.Windows.Forms.PictureBox ground1;
        private System.Windows.Forms.PictureBox stone1;
        private System.Windows.Forms.PictureBox stone2;
        private System.Windows.Forms.PictureBox stone3;
        private System.Windows.Forms.PictureBox horizontalMovingStone;
        private System.Windows.Forms.PictureBox stone4;
        private System.Windows.Forms.PictureBox stone5;
        private System.Windows.Forms.PictureBox stone7;
        private System.Windows.Forms.PictureBox verticalMovingStone;
        private System.Windows.Forms.PictureBox stone6;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox pointer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox enemy2;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox enemy1;
    }
}

