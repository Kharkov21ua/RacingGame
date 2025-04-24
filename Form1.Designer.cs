namespace RacingGame
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bg1 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.bg2 = new System.Windows.Forms.PictureBox();
            this.bg3 = new System.Windows.Forms.PictureBox();
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.enemy2 = new System.Windows.Forms.PictureBox();
            this.labelloos = new System.Windows.Forms.Label();
            this.btmRestart = new System.Windows.Forms.Button();
            this.btmclose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            this.SuspendLayout();
            // 
            // bg1
            // 
            this.bg1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bg1.BackgroundImage")));
            this.bg1.Location = new System.Drawing.Point(0, -650);
            this.bg1.Name = "bg1";
            this.bg1.Size = new System.Drawing.Size(853, 650);
            this.bg1.TabIndex = 0;
            this.bg1.TabStop = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.player.Image = ((System.Drawing.Image)(resources.GetObject("player.Image")));
            this.player.InitialImage = ((System.Drawing.Image)(resources.GetObject("player.InitialImage")));
            this.player.Location = new System.Drawing.Point(363, 510);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(111, 128);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 1;
            this.player.TabStop = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 20;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // bg2
            // 
            this.bg2.Image = ((System.Drawing.Image)(resources.GetObject("bg2.Image")));
            this.bg2.Location = new System.Drawing.Point(0, 0);
            this.bg2.Name = "bg2";
            this.bg2.Size = new System.Drawing.Size(853, 650);
            this.bg2.TabIndex = 2;
            this.bg2.TabStop = false;
            // 
            // bg3
            // 
            this.bg3.Image = ((System.Drawing.Image)(resources.GetObject("bg3.Image")));
            this.bg3.Location = new System.Drawing.Point(0, 0);
            this.bg3.Name = "bg3";
            this.bg3.Size = new System.Drawing.Size(840, 650);
            this.bg3.TabIndex = 3;
            this.bg3.TabStop = false;
            // 
            // enemy1
            // 
            this.enemy1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.enemy1.Image = ((System.Drawing.Image)(resources.GetObject("enemy1.Image")));
            this.enemy1.Location = new System.Drawing.Point(174, -190);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(99, 187);
            this.enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy1.TabIndex = 4;
            this.enemy1.TabStop = false;
            // 
            // enemy2
            // 
            this.enemy2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.enemy2.Image = ((System.Drawing.Image)(resources.GetObject("enemy2.Image")));
            this.enemy2.Location = new System.Drawing.Point(561, -400);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(99, 187);
            this.enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy2.TabIndex = 5;
            this.enemy2.TabStop = false;
            // 
            // labelloos
            // 
            this.labelloos.AutoSize = true;
            this.labelloos.BackColor = System.Drawing.Color.RosyBrown;
            this.labelloos.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelloos.Location = new System.Drawing.Point(146, 108);
            this.labelloos.Name = "labelloos";
            this.labelloos.Size = new System.Drawing.Size(549, 108);
            this.labelloos.TabIndex = 6;
            this.labelloos.Text = "Game Over";
            // 
            // btmRestart
            // 
            this.btmRestart.BackColor = System.Drawing.Color.Red;
            this.btmRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmRestart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btmRestart.Location = new System.Drawing.Point(128, 353);
            this.btmRestart.Name = "btmRestart";
            this.btmRestart.Size = new System.Drawing.Size(286, 64);
            this.btmRestart.TabIndex = 7;
            this.btmRestart.Text = "Restart Game";
            this.btmRestart.UseVisualStyleBackColor = false;
            this.btmRestart.Click += new System.EventHandler(this.btmRestart_Click);
            // 
            // btmclose
            // 
            this.btmclose.BackColor = System.Drawing.Color.Red;
            this.btmclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmclose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btmclose.Location = new System.Drawing.Point(420, 353);
            this.btmclose.Name = "btmclose";
            this.btmclose.Size = new System.Drawing.Size(286, 64);
            this.btmclose.TabIndex = 8;
            this.btmclose.Text = "Close Game";
            this.btmclose.UseVisualStyleBackColor = false;
            this.btmclose.Click += new System.EventHandler(this.btmclose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(840, 650);
            this.Controls.Add(this.btmclose);
            this.Controls.Add(this.btmRestart);
            this.Controls.Add(this.labelloos);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.enemy1);
            this.Controls.Add(this.player);
            this.Controls.Add(this.bg1);
            this.Controls.Add(this.bg2);
            this.Controls.Add(this.bg3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.bg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bg1;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox bg2;
        private System.Windows.Forms.PictureBox bg3;
        private System.Windows.Forms.PictureBox enemy1;
        private System.Windows.Forms.PictureBox enemy2;
        private System.Windows.Forms.Label labelloos;
        private System.Windows.Forms.Button btmRestart;
        private System.Windows.Forms.Button btmclose;
    }
}

