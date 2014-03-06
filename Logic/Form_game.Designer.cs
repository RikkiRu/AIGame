namespace Logic
{
    partial class Form_game
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_game));
            this.glControl1 = new OpenTK.GLControl();
            this.timer_game = new System.Windows.Forms.Timer(this.components);
            this.pictureBox_door = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_door)).BeginInit();
            this.SuspendLayout();
            // 
            // glControl1
            // 
            this.glControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.glControl1.BackColor = System.Drawing.Color.Black;
            this.glControl1.Location = new System.Drawing.Point(5, 6);
            this.glControl1.Name = "glControl1";
            this.glControl1.Padding = new System.Windows.Forms.Padding(4);
            this.glControl1.Size = new System.Drawing.Size(321, 308);
            this.glControl1.TabIndex = 0;
            this.glControl1.VSync = false;
            this.glControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_game_KeyDown);
            // 
            // timer_game
            // 
            this.timer_game.Interval = 20;
            this.timer_game.Tick += new System.EventHandler(this.timer_game_Tick);
            // 
            // pictureBox_door
            // 
            this.pictureBox_door.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_door.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_door.Location = new System.Drawing.Point(302, 319);
            this.pictureBox_door.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_door.Name = "pictureBox_door";
            this.pictureBox_door.Size = new System.Drawing.Size(24, 26);
            this.pictureBox_door.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_door.TabIndex = 1;
            this.pictureBox_door.TabStop = false;
            this.pictureBox_door.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_door_MouseClick);
            this.pictureBox_door.MouseEnter += new System.EventHandler(this.pictureBox_door_MouseEnter);
            this.pictureBox_door.MouseLeave += new System.EventHandler(this.pictureBox_door_MouseLeave);
            // 
            // Form_game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 350);
            this.Controls.Add(this.pictureBox_door);
            this.Controls.Add(this.glControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form_game";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_game_FormClosing);
            this.Load += new System.EventHandler(this.Form_game_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_game_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_door)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private OpenTK.GLControl glControl1;
        private System.Windows.Forms.Timer timer_game;
        private System.Windows.Forms.PictureBox pictureBox_door;
    }
}