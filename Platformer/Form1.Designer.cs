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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
            this.Score = new System.Windows.Forms.Label();
            this.Ground_2 = new System.Windows.Forms.PictureBox();
            this.Ground_1 = new System.Windows.Forms.PictureBox();
            this.stone_1 = new System.Windows.Forms.PictureBox();
            this.stone_2 = new System.Windows.Forms.PictureBox();
            this.stone_3 = new System.Windows.Forms.PictureBox();
            this.moving_Stone_1 = new System.Windows.Forms.PictureBox();
            this.stone_4 = new System.Windows.Forms.PictureBox();
            this.stone_5 = new System.Windows.Forms.PictureBox();
            this.stone_7 = new System.Windows.Forms.PictureBox();
            this.moving_Stone_2 = new System.Windows.Forms.PictureBox();
            this.stone_6 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.pointer = new System.Windows.Forms.PictureBox();
            this.money_2 = new System.Windows.Forms.PictureBox();
            this.enemy_1 = new System.Windows.Forms.PictureBox();
            this.money_4 = new System.Windows.Forms.PictureBox();
            this.money_1 = new System.Windows.Forms.PictureBox();
            this.money_5 = new System.Windows.Forms.PictureBox();
            this.money_6 = new System.Windows.Forms.PictureBox();
            this.money_8 = new System.Windows.Forms.PictureBox();
            this.money_9 = new System.Windows.Forms.PictureBox();
            this.money_10 = new System.Windows.Forms.PictureBox();
            this.money_11 = new System.Windows.Forms.PictureBox();
            this.money_12 = new System.Windows.Forms.PictureBox();
            this.money_3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Ground_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stone_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stone_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stone_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moving_Stone_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stone_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stone_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stone_7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moving_Stone_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stone_6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.money_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.money_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.money_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.money_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.money_6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.money_8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.money_9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.money_10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.money_11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.money_12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.money_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Score
            // 
            this.Score.BackColor = System.Drawing.Color.Transparent;
            this.Score.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Score.Location = new System.Drawing.Point(660, 9);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(212, 78);
            this.Score.TabIndex = 0;
            this.Score.Text = "Score:0";
            this.Score.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.Score.Click += new System.EventHandler(this.label1_Click);
            // 
            // Ground_2
            // 
            this.Ground_2.Image = ((System.Drawing.Image)(resources.GetObject("Ground_2.Image")));
            this.Ground_2.Location = new System.Drawing.Point(584, 510);
            this.Ground_2.Name = "Ground_2";
            this.Ground_2.Size = new System.Drawing.Size(300, 50);
            this.Ground_2.TabIndex = 4;
            this.Ground_2.TabStop = false;
            this.Ground_2.Tag = "Ground";
            // 
            // Ground_1
            // 
            this.Ground_1.Image = ((System.Drawing.Image)(resources.GetObject("Ground_1.Image")));
            this.Ground_1.Location = new System.Drawing.Point(1, 510);
            this.Ground_1.Name = "Ground_1";
            this.Ground_1.Size = new System.Drawing.Size(300, 50);
            this.Ground_1.TabIndex = 5;
            this.Ground_1.TabStop = false;
            this.Ground_1.Tag = "Ground";
            // 
            // stone_1
            // 
            this.stone_1.Image = ((System.Drawing.Image)(resources.GetObject("stone_1.Image")));
            this.stone_1.Location = new System.Drawing.Point(255, 433);
            this.stone_1.Name = "stone_1";
            this.stone_1.Size = new System.Drawing.Size(100, 20);
            this.stone_1.TabIndex = 7;
            this.stone_1.TabStop = false;
            this.stone_1.Tag = "Stone";
            // 
            // stone_2
            // 
            this.stone_2.Image = ((System.Drawing.Image)(resources.GetObject("stone_2.Image")));
            this.stone_2.Location = new System.Drawing.Point(56, 370);
            this.stone_2.Name = "stone_2";
            this.stone_2.Size = new System.Drawing.Size(100, 20);
            this.stone_2.TabIndex = 8;
            this.stone_2.TabStop = false;
            this.stone_2.Tag = "Stone";
            // 
            // stone_3
            // 
            this.stone_3.Image = ((System.Drawing.Image)(resources.GetObject("stone_3.Image")));
            this.stone_3.Location = new System.Drawing.Point(220, 306);
            this.stone_3.Name = "stone_3";
            this.stone_3.Size = new System.Drawing.Size(100, 20);
            this.stone_3.TabIndex = 9;
            this.stone_3.TabStop = false;
            this.stone_3.Tag = "Stone";
            // 
            // moving_Stone_1
            // 
            this.moving_Stone_1.Image = ((System.Drawing.Image)(resources.GetObject("moving_Stone_1.Image")));
            this.moving_Stone_1.Location = new System.Drawing.Point(389, 265);
            this.moving_Stone_1.Name = "moving_Stone_1";
            this.moving_Stone_1.Size = new System.Drawing.Size(100, 20);
            this.moving_Stone_1.TabIndex = 10;
            this.moving_Stone_1.TabStop = false;
            this.moving_Stone_1.Tag = "Stone";
            // 
            // stone_4
            // 
            this.stone_4.Image = ((System.Drawing.Image)(resources.GetObject("stone_4.Image")));
            this.stone_4.Location = new System.Drawing.Point(56, 231);
            this.stone_4.Name = "stone_4";
            this.stone_4.Size = new System.Drawing.Size(100, 20);
            this.stone_4.TabIndex = 11;
            this.stone_4.TabStop = false;
            this.stone_4.Tag = "Stone";
            this.stone_4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // stone_5
            // 
            this.stone_5.Image = ((System.Drawing.Image)(resources.GetObject("stone_5.Image")));
            this.stone_5.Location = new System.Drawing.Point(562, 348);
            this.stone_5.Name = "stone_5";
            this.stone_5.Size = new System.Drawing.Size(100, 20);
            this.stone_5.TabIndex = 12;
            this.stone_5.TabStop = false;
            this.stone_5.Tag = "Stone";
            // 
            // stone_7
            // 
            this.stone_7.Image = ((System.Drawing.Image)(resources.GetObject("stone_7.Image")));
            this.stone_7.Location = new System.Drawing.Point(693, 420);
            this.stone_7.Name = "stone_7";
            this.stone_7.Size = new System.Drawing.Size(100, 20);
            this.stone_7.TabIndex = 13;
            this.stone_7.TabStop = false;
            this.stone_7.Tag = "Stone";
            // 
            // moving_Stone_2
            // 
            this.moving_Stone_2.Image = ((System.Drawing.Image)(resources.GetObject("moving_Stone_2.Image")));
            this.moving_Stone_2.Location = new System.Drawing.Point(762, 231);
            this.moving_Stone_2.Name = "moving_Stone_2";
            this.moving_Stone_2.Size = new System.Drawing.Size(100, 20);
            this.moving_Stone_2.TabIndex = 14;
            this.moving_Stone_2.TabStop = false;
            this.moving_Stone_2.Tag = "Stone";
            // 
            // stone_6
            // 
            this.stone_6.Image = ((System.Drawing.Image)(resources.GetObject("stone_6.Image")));
            this.stone_6.Location = new System.Drawing.Point(609, 158);
            this.stone_6.Name = "stone_6";
            this.stone_6.Size = new System.Drawing.Size(100, 20);
            this.stone_6.TabIndex = 15;
            this.stone_6.TabStop = false;
            this.stone_6.Tag = "Stone";
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
            this.pointer.Location = new System.Drawing.Point(827, 470);
            this.pointer.Name = "pointer";
            this.pointer.Size = new System.Drawing.Size(45, 40);
            this.pointer.TabIndex = 17;
            this.pointer.TabStop = false;
            this.pointer.Tag = "Pointer";
            // 
            // money_2
            // 
            this.money_2.BackColor = System.Drawing.Color.Transparent;
            this.money_2.Image = ((System.Drawing.Image)(resources.GetObject("money_2.Image")));
            this.money_2.Location = new System.Drawing.Point(168, 479);
            this.money_2.Name = "money_2";
            this.money_2.Size = new System.Drawing.Size(25, 25);
            this.money_2.TabIndex = 18;
            this.money_2.TabStop = false;
            this.money_2.Tag = "Money";
            // 
            // enemy_1
            // 
            this.enemy_1.BackColor = System.Drawing.Color.Transparent;
            this.enemy_1.Image = ((System.Drawing.Image)(resources.GetObject("enemy_1.Image")));
            this.enemy_1.Location = new System.Drawing.Point(295, 410);
            this.enemy_1.Name = "enemy_1";
            this.enemy_1.Size = new System.Drawing.Size(25, 25);
            this.enemy_1.TabIndex = 19;
            this.enemy_1.TabStop = false;
            this.enemy_1.Tag = "Enemy";
            // 
            // money_4
            // 
            this.money_4.BackColor = System.Drawing.Color.Transparent;
            this.money_4.Image = ((System.Drawing.Image)(resources.GetObject("money_4.Image")));
            this.money_4.Location = new System.Drawing.Point(230, 479);
            this.money_4.Name = "money_4";
            this.money_4.Size = new System.Drawing.Size(25, 25);
            this.money_4.TabIndex = 21;
            this.money_4.TabStop = false;
            this.money_4.Tag = "Money";
            // 
            // money_1
            // 
            this.money_1.BackColor = System.Drawing.Color.Transparent;
            this.money_1.Image = ((System.Drawing.Image)(resources.GetObject("money_1.Image")));
            this.money_1.Location = new System.Drawing.Point(261, 479);
            this.money_1.Name = "money_1";
            this.money_1.Size = new System.Drawing.Size(25, 25);
            this.money_1.TabIndex = 22;
            this.money_1.TabStop = false;
            this.money_1.Tag = "Money";
            // 
            // money_5
            // 
            this.money_5.BackColor = System.Drawing.Color.Transparent;
            this.money_5.Image = ((System.Drawing.Image)(resources.GetObject("money_5.Image")));
            this.money_5.Location = new System.Drawing.Point(79, 200);
            this.money_5.Name = "money_5";
            this.money_5.Size = new System.Drawing.Size(25, 25);
            this.money_5.TabIndex = 23;
            this.money_5.TabStop = false;
            this.money_5.Tag = "Money";
            // 
            // money_6
            // 
            this.money_6.BackColor = System.Drawing.Color.Transparent;
            this.money_6.Image = ((System.Drawing.Image)(resources.GetObject("money_6.Image")));
            this.money_6.Location = new System.Drawing.Point(110, 200);
            this.money_6.Name = "money_6";
            this.money_6.Size = new System.Drawing.Size(25, 25);
            this.money_6.TabIndex = 24;
            this.money_6.TabStop = false;
            this.money_6.Tag = "Money";
            // 
            // money_8
            // 
            this.money_8.BackColor = System.Drawing.Color.Transparent;
            this.money_8.Image = ((System.Drawing.Image)(resources.GetObject("money_8.Image")));
            this.money_8.Location = new System.Drawing.Point(632, 127);
            this.money_8.Name = "money_8";
            this.money_8.Size = new System.Drawing.Size(25, 25);
            this.money_8.TabIndex = 25;
            this.money_8.TabStop = false;
            this.money_8.Tag = "Money";
            // 
            // money_9
            // 
            this.money_9.BackColor = System.Drawing.Color.Transparent;
            this.money_9.Image = ((System.Drawing.Image)(resources.GetObject("money_9.Image")));
            this.money_9.Location = new System.Drawing.Point(663, 127);
            this.money_9.Name = "money_9";
            this.money_9.Size = new System.Drawing.Size(25, 25);
            this.money_9.TabIndex = 26;
            this.money_9.TabStop = false;
            this.money_9.Tag = "Money";
            // 
            // money_10
            // 
            this.money_10.BackColor = System.Drawing.Color.Transparent;
            this.money_10.Image = ((System.Drawing.Image)(resources.GetObject("money_10.Image")));
            this.money_10.Location = new System.Drawing.Point(598, 479);
            this.money_10.Name = "money_10";
            this.money_10.Size = new System.Drawing.Size(25, 25);
            this.money_10.TabIndex = 27;
            this.money_10.TabStop = false;
            this.money_10.Tag = "Money";
            // 
            // money_11
            // 
            this.money_11.BackColor = System.Drawing.Color.Transparent;
            this.money_11.Image = ((System.Drawing.Image)(resources.GetObject("money_11.Image")));
            this.money_11.Location = new System.Drawing.Point(629, 479);
            this.money_11.Name = "money_11";
            this.money_11.Size = new System.Drawing.Size(25, 25);
            this.money_11.TabIndex = 28;
            this.money_11.TabStop = false;
            this.money_11.Tag = "Money";
            // 
            // money_12
            // 
            this.money_12.BackColor = System.Drawing.Color.Transparent;
            this.money_12.Image = ((System.Drawing.Image)(resources.GetObject("money_12.Image")));
            this.money_12.Location = new System.Drawing.Point(660, 479);
            this.money_12.Name = "money_12";
            this.money_12.Size = new System.Drawing.Size(25, 25);
            this.money_12.TabIndex = 29;
            this.money_12.TabStop = false;
            this.money_12.Tag = "Money";
            // 
            // money_3
            // 
            this.money_3.BackColor = System.Drawing.Color.Transparent;
            this.money_3.Image = ((System.Drawing.Image)(resources.GetObject("money_3.Image")));
            this.money_3.Location = new System.Drawing.Point(199, 479);
            this.money_3.Name = "money_3";
            this.money_3.Size = new System.Drawing.Size(25, 25);
            this.money_3.TabIndex = 30;
            this.money_3.TabStop = false;
            this.money_3.Tag = "Money";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(598, 325);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "Enemy";
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.money_3);
            this.Controls.Add(this.money_12);
            this.Controls.Add(this.money_11);
            this.Controls.Add(this.money_10);
            this.Controls.Add(this.money_9);
            this.Controls.Add(this.money_8);
            this.Controls.Add(this.money_6);
            this.Controls.Add(this.money_5);
            this.Controls.Add(this.money_1);
            this.Controls.Add(this.money_4);
            this.Controls.Add(this.enemy_1);
            this.Controls.Add(this.money_2);
            this.Controls.Add(this.pointer);
            this.Controls.Add(this.player);
            this.Controls.Add(this.stone_6);
            this.Controls.Add(this.moving_Stone_2);
            this.Controls.Add(this.stone_7);
            this.Controls.Add(this.stone_5);
            this.Controls.Add(this.stone_4);
            this.Controls.Add(this.moving_Stone_1);
            this.Controls.Add(this.stone_3);
            this.Controls.Add(this.stone_2);
            this.Controls.Add(this.stone_1);
            this.Controls.Add(this.Ground_1);
            this.Controls.Add(this.Ground_2);
            this.Controls.Add(this.Score);
            this.Name = "Window";
            this.Text = "Platformer";
            ((System.ComponentModel.ISupportInitialize)(this.Ground_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stone_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stone_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stone_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moving_Stone_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stone_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stone_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stone_7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moving_Stone_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stone_6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.money_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.money_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.money_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.money_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.money_6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.money_8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.money_9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.money_10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.money_11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.money_12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.money_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.PictureBox Ground_2;
        private System.Windows.Forms.PictureBox Ground_1;
        private System.Windows.Forms.PictureBox stone_1;
        private System.Windows.Forms.PictureBox stone_2;
        private System.Windows.Forms.PictureBox stone_3;
        private System.Windows.Forms.PictureBox moving_Stone_1;
        private System.Windows.Forms.PictureBox stone_4;
        private System.Windows.Forms.PictureBox stone_5;
        private System.Windows.Forms.PictureBox stone_7;
        private System.Windows.Forms.PictureBox moving_Stone_2;
        private System.Windows.Forms.PictureBox stone_6;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox pointer;
        private System.Windows.Forms.PictureBox money_2;
        private System.Windows.Forms.PictureBox enemy_1;
        private System.Windows.Forms.PictureBox money_4;
        private System.Windows.Forms.PictureBox money_1;
        private System.Windows.Forms.PictureBox money_5;
        private System.Windows.Forms.PictureBox money_6;
        private System.Windows.Forms.PictureBox money_8;
        private System.Windows.Forms.PictureBox money_9;
        private System.Windows.Forms.PictureBox money_10;
        private System.Windows.Forms.PictureBox money_11;
        private System.Windows.Forms.PictureBox money_12;
        private System.Windows.Forms.PictureBox money_3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

