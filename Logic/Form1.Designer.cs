namespace Logic
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_lang = new System.Windows.Forms.Button();
            this.pictureBox_back = new System.Windows.Forms.PictureBox();
            this.timer_loop = new System.Windows.Forms.Timer(this.components);
            this.button_new = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_about = new System.Windows.Forms.Button();
            this.button_options = new System.Windows.Forms.Button();
            this.button_load = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_canelGame = new System.Windows.Forms.Button();
            this.label_newGame = new System.Windows.Forms.Label();
            this.button_two = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.checkBox_full = new System.Windows.Forms.CheckBox();
            this.button_bot = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button_acept = new System.Windows.Forms.Button();
            this.checkBox_sound = new System.Windows.Forms.CheckBox();
            this.label_dpi = new System.Windows.Forms.Label();
            this.pictureBox_beam_opt = new System.Windows.Forms.PictureBox();
            this.pictureBox_beamNew = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_back)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_beam_opt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_beamNew)).BeginInit();
            this.SuspendLayout();
            // 
            // button_lang
            // 
            this.button_lang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_lang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_lang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_lang.Location = new System.Drawing.Point(323, 267);
            this.button_lang.Margin = new System.Windows.Forms.Padding(0);
            this.button_lang.Name = "button_lang";
            this.button_lang.Size = new System.Drawing.Size(35, 31);
            this.button_lang.TabIndex = 2;
            this.button_lang.TabStop = false;
            this.button_lang.UseVisualStyleBackColor = true;
            this.button_lang.Click += new System.EventHandler(this.button_lang_Click);
            // 
            // pictureBox_back
            // 
            this.pictureBox_back.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_back.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_back.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_back.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.pictureBox_back.Name = "pictureBox_back";
            this.pictureBox_back.Size = new System.Drawing.Size(379, 322);
            this.pictureBox_back.TabIndex = 6;
            this.pictureBox_back.TabStop = false;
            // 
            // timer_loop
            // 
            this.timer_loop.Interval = 50;
            this.timer_loop.Tick += new System.EventHandler(this.timer_loop_Tick);
            // 
            // button_new
            // 
            this.button_new.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_new.BackColor = System.Drawing.Color.Transparent;
            this.button_new.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_new.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_new.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_new.Location = new System.Drawing.Point(19, 17);
            this.button_new.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.button_new.Name = "button_new";
            this.button_new.Size = new System.Drawing.Size(148, 43);
            this.button_new.TabIndex = 7;
            this.button_new.TabStop = false;
            this.button_new.Text = "new";
            this.button_new.UseVisualStyleBackColor = false;
            this.button_new.Click += new System.EventHandler(this.button_new_Click);
            this.button_new.MouseEnter += new System.EventHandler(this.buttonUse);
            this.button_new.MouseLeave += new System.EventHandler(this.buttonNotUse);
            // 
            // button_exit
            // 
            this.button_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_exit.BackColor = System.Drawing.Color.Transparent;
            this.button_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_exit.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_exit.Location = new System.Drawing.Point(19, 262);
            this.button_exit.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(148, 43);
            this.button_exit.TabIndex = 8;
            this.button_exit.TabStop = false;
            this.button_exit.Text = "exit";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            this.button_exit.MouseEnter += new System.EventHandler(this.buttonUse);
            this.button_exit.MouseLeave += new System.EventHandler(this.buttonNotUse);
            // 
            // button_about
            // 
            this.button_about.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_about.BackColor = System.Drawing.Color.Transparent;
            this.button_about.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_about.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_about.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_about.Location = new System.Drawing.Point(19, 183);
            this.button_about.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.button_about.Name = "button_about";
            this.button_about.Size = new System.Drawing.Size(148, 43);
            this.button_about.TabIndex = 9;
            this.button_about.TabStop = false;
            this.button_about.Text = "about";
            this.button_about.UseVisualStyleBackColor = false;
            this.button_about.Click += new System.EventHandler(this.button_about_Click);
            this.button_about.MouseEnter += new System.EventHandler(this.buttonUse);
            this.button_about.MouseLeave += new System.EventHandler(this.buttonNotUse);
            // 
            // button_options
            // 
            this.button_options.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_options.BackColor = System.Drawing.Color.Transparent;
            this.button_options.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_options.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_options.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_options.Location = new System.Drawing.Point(19, 128);
            this.button_options.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.button_options.Name = "button_options";
            this.button_options.Size = new System.Drawing.Size(148, 43);
            this.button_options.TabIndex = 10;
            this.button_options.TabStop = false;
            this.button_options.Text = "options";
            this.button_options.UseVisualStyleBackColor = false;
            this.button_options.Click += new System.EventHandler(this.button_options_Click);
            this.button_options.MouseEnter += new System.EventHandler(this.buttonUse);
            this.button_options.MouseLeave += new System.EventHandler(this.buttonNotUse);
            // 
            // button_load
            // 
            this.button_load.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_load.BackColor = System.Drawing.Color.Transparent;
            this.button_load.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_load.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_load.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_load.Location = new System.Drawing.Point(19, 73);
            this.button_load.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.button_load.Name = "button_load";
            this.button_load.Size = new System.Drawing.Size(148, 43);
            this.button_load.TabIndex = 11;
            this.button_load.TabStop = false;
            this.button_load.Text = "load";
            this.button_load.UseVisualStyleBackColor = false;
            this.button_load.MouseEnter += new System.EventHandler(this.buttonUse);
            this.button_load.MouseLeave += new System.EventHandler(this.buttonNotUse);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button_canelGame);
            this.panel1.Controls.Add(this.label_newGame);
            this.panel1.Controls.Add(this.button_two);
            this.panel1.Controls.Add(this.button_cancel);
            this.panel1.Controls.Add(this.checkBox_full);
            this.panel1.Controls.Add(this.button_bot);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.button_acept);
            this.panel1.Controls.Add(this.checkBox_sound);
            this.panel1.Controls.Add(this.label_dpi);
            this.panel1.Location = new System.Drawing.Point(177, 17);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 209);
            this.panel1.TabIndex = 12;
            this.panel1.Visible = false;
            // 
            // button_canelGame
            // 
            this.button_canelGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_canelGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_canelGame.Location = new System.Drawing.Point(40, 155);
            this.button_canelGame.Name = "button_canelGame";
            this.button_canelGame.Size = new System.Drawing.Size(98, 26);
            this.button_canelGame.TabIndex = 11;
            this.button_canelGame.Text = "back";
            this.button_canelGame.UseVisualStyleBackColor = true;
            this.button_canelGame.Visible = false;
            this.button_canelGame.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_canelGame_MouseClick);
            this.button_canelGame.MouseEnter += new System.EventHandler(this.buttonAcceptUse);
            this.button_canelGame.MouseLeave += new System.EventHandler(this.buttonAcceptNotUse);
            // 
            // label_newGame
            // 
            this.label_newGame.Location = new System.Drawing.Point(20, 11);
            this.label_newGame.Name = "label_newGame";
            this.label_newGame.Size = new System.Drawing.Size(140, 17);
            this.label_newGame.TabIndex = 10;
            this.label_newGame.Text = "new";
            this.label_newGame.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_newGame.Visible = false;
            // 
            // button_two
            // 
            this.button_two.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_two.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_two.Location = new System.Drawing.Point(22, 86);
            this.button_two.Name = "button_two";
            this.button_two.Size = new System.Drawing.Size(138, 36);
            this.button_two.TabIndex = 9;
            this.button_two.Text = "two";
            this.button_two.UseVisualStyleBackColor = true;
            this.button_two.Visible = false;
            this.button_two.Click += new System.EventHandler(this.button_two_Click);
            this.button_two.MouseEnter += new System.EventHandler(this.buttonAcceptUse);
            this.button_two.MouseLeave += new System.EventHandler(this.buttonAcceptNotUse);
            // 
            // button_cancel
            // 
            this.button_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cancel.Location = new System.Drawing.Point(72, 150);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(79, 31);
            this.button_cancel.TabIndex = 7;
            this.button_cancel.TabStop = false;
            this.button_cancel.Text = "cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Visible = false;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            this.button_cancel.MouseEnter += new System.EventHandler(this.buttonAcceptUse);
            this.button_cancel.MouseLeave += new System.EventHandler(this.buttonAcceptNotUse);
            // 
            // checkBox_full
            // 
            this.checkBox_full.AutoSize = true;
            this.checkBox_full.Location = new System.Drawing.Point(23, 105);
            this.checkBox_full.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_full.Name = "checkBox_full";
            this.checkBox_full.Size = new System.Drawing.Size(75, 21);
            this.checkBox_full.TabIndex = 6;
            this.checkBox_full.Text = "window";
            this.checkBox_full.UseVisualStyleBackColor = true;
            this.checkBox_full.Visible = false;
            // 
            // button_bot
            // 
            this.button_bot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_bot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_bot.Location = new System.Drawing.Point(22, 44);
            this.button_bot.Name = "button_bot";
            this.button_bot.Size = new System.Drawing.Size(139, 36);
            this.button_bot.TabIndex = 8;
            this.button_bot.Text = "bot";
            this.button_bot.UseVisualStyleBackColor = true;
            this.button_bot.Visible = false;
            this.button_bot.MouseEnter += new System.EventHandler(this.buttonAcceptUse);
            this.button_bot.MouseLeave += new System.EventHandler(this.buttonAcceptNotUse);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "400x320",
            "800x600"});
            this.comboBox1.Location = new System.Drawing.Point(23, 31);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(128, 24);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.TabStop = false;
            this.comboBox1.Visible = false;
            // 
            // button_acept
            // 
            this.button_acept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_acept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_acept.Location = new System.Drawing.Point(22, 150);
            this.button_acept.Margin = new System.Windows.Forms.Padding(4);
            this.button_acept.Name = "button_acept";
            this.button_acept.Size = new System.Drawing.Size(43, 31);
            this.button_acept.TabIndex = 4;
            this.button_acept.TabStop = false;
            this.button_acept.Text = "OK";
            this.button_acept.UseVisualStyleBackColor = true;
            this.button_acept.Visible = false;
            this.button_acept.Click += new System.EventHandler(this.button_acept_Click);
            this.button_acept.MouseEnter += new System.EventHandler(this.buttonAcceptUse);
            this.button_acept.MouseLeave += new System.EventHandler(this.buttonAcceptNotUse);
            // 
            // checkBox_sound
            // 
            this.checkBox_sound.AutoSize = true;
            this.checkBox_sound.Location = new System.Drawing.Point(23, 76);
            this.checkBox_sound.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_sound.Name = "checkBox_sound";
            this.checkBox_sound.Size = new System.Drawing.Size(69, 21);
            this.checkBox_sound.TabIndex = 3;
            this.checkBox_sound.Text = "sound";
            this.checkBox_sound.UseVisualStyleBackColor = true;
            this.checkBox_sound.Visible = false;
            // 
            // label_dpi
            // 
            this.label_dpi.AutoSize = true;
            this.label_dpi.Location = new System.Drawing.Point(19, 11);
            this.label_dpi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_dpi.Name = "label_dpi";
            this.label_dpi.Size = new System.Drawing.Size(46, 17);
            this.label_dpi.TabIndex = 0;
            this.label_dpi.Text = "label1";
            this.label_dpi.Visible = false;
            // 
            // pictureBox_beam_opt
            // 
            this.pictureBox_beam_opt.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_beam_opt.Location = new System.Drawing.Point(166, 133);
            this.pictureBox_beam_opt.Name = "pictureBox_beam_opt";
            this.pictureBox_beam_opt.Size = new System.Drawing.Size(12, 33);
            this.pictureBox_beam_opt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_beam_opt.TabIndex = 13;
            this.pictureBox_beam_opt.TabStop = false;
            this.pictureBox_beam_opt.Visible = false;
            // 
            // pictureBox_beamNew
            // 
            this.pictureBox_beamNew.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_beamNew.Location = new System.Drawing.Point(166, 21);
            this.pictureBox_beamNew.Name = "pictureBox_beamNew";
            this.pictureBox_beamNew.Size = new System.Drawing.Size(12, 33);
            this.pictureBox_beamNew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_beamNew.TabIndex = 14;
            this.pictureBox_beamNew.TabStop = false;
            this.pictureBox_beamNew.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(379, 322);
            this.Controls.Add(this.pictureBox_beamNew);
            this.Controls.Add(this.pictureBox_beam_opt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_load);
            this.Controls.Add(this.button_options);
            this.Controls.Add(this.button_about);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_new);
            this.Controls.Add(this.button_lang);
            this.Controls.Add(this.pictureBox_back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formName";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_back)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_beam_opt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_beamNew)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_lang;
        private System.Windows.Forms.PictureBox pictureBox_back;
        private System.Windows.Forms.Button button_new;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_about;
        private System.Windows.Forms.Button button_options;
        private System.Windows.Forms.Button button_load;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox_sound;
        private System.Windows.Forms.Label label_dpi;
        private System.Windows.Forms.Button button_acept;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox_full;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Label label_newGame;
        private System.Windows.Forms.Button button_two;
        private System.Windows.Forms.Button button_bot;
        private System.Windows.Forms.Button button_canelGame;
        private System.Windows.Forms.PictureBox pictureBox_beam_opt;
        private System.Windows.Forms.PictureBox pictureBox_beamNew;
        public System.Windows.Forms.Timer timer_loop;
    }
}

