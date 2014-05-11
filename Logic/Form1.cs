using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Logic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //---------- объявления
        List<LangGUI> LangList;
        public bool IsEnglish;
        Bitmap bm;
        Graphics gr;
        Image background;
        Image flagEng;
        Image flagRus;
        Image buttonOff;
        Image buttonOn;
        Image panelImg;
        Image imgAccept;
        Image imgAcceptOn;
        Image imgBeam;
        movieImg moveBack;
        int dpiX;
        int dpiY;
        public bool sound;
        public bool windowed;
        //----------

        void loadScript()
        {
            moveBack = new movieImg(-10, -10, pictureBox_back.Width*2, pictureBox_back.Height*2, background);
            moveImgPoint mp;

            int sizeX = pictureBox_back.Width;
            int sizeY = pictureBox_back.Height;

            int speed = 1;

            mp = new moveImgPoint();
            mp.minXon = true;
            mp.minX = -sizeX+10;
            mp.speedX = -speed;
            moveBack.mas.Add(mp);

            mp = new moveImgPoint();
            mp.minYon = true;
            mp.minY = -sizeY+10;
            mp.speedY = -speed;
            moveBack.mas.Add(mp);

            mp = new moveImgPoint();
            mp.maxXon = true;
            mp.maxX = -10;
            mp.speedX = speed;
            moveBack.mas.Add(mp);

            mp = new moveImgPoint();
            mp.maxYon = true;
            mp.maxY = -10;
            mp.speedY = speed;
            moveBack.mas.Add(mp);

            moveBack.SetSpeed();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            background = Image.FromFile("GameFiles/textures/mainMenu/background.png");
            flagEng = Image.FromFile("GameFiles/Lang/eng.png");
            flagRus = Image.FromFile("GameFiles/Lang/rus.png");
            buttonOff = Image.FromFile("GameFiles/textures/mainMenu/buttonOff.png");
            buttonOn = Image.FromFile("GameFiles/textures/mainMenu/buttonOn.png");
            panelImg = Image.FromFile("GameFiles/textures/mainMenu/panel.png");
            imgAccept = Image.FromFile("GameFiles/textures/mainMenu/accept.png");
            imgAcceptOn = Image.FromFile("GameFiles/textures/mainMenu/acceptOn.png");
            imgBeam = Image.FromFile("GameFiles/textures/mainMenu/beam.png");
            bm = new Bitmap(pictureBox_back.Width, pictureBox_back.Height);
            gr = Graphics.FromImage(bm);

            button_about.BackgroundImage = button_exit.BackgroundImage = button_load.BackgroundImage = button_new.BackgroundImage =button_options.BackgroundImage = buttonOff;
            panel1.BackgroundImage = panelImg;
            button_acept.BackgroundImage = imgAccept;
            button_cancel.BackgroundImage = imgAccept;
            button_bot.BackgroundImage = imgAccept;
            button_two.BackgroundImage = imgAccept;
            button_canelGame.BackgroundImage = imgAccept;
            pictureBox_beam_opt.Parent = pictureBox_beamNew.Parent = pictureBox_back;
            pictureBox_beamNew.Image = pictureBox_beam_opt.Image = imgBeam;
            LangList = new List<LangGUI>();
            IsEnglish = false;
            dpiX = 0;
            dpiY = 0;
            sound = true;
            windowed = true;

            configLoad();
            locale_load();
            localize();
            loadScript();

            this.DoubleBuffered = true;
            timer_loop.Enabled = true;
        }

        void Render()
        {
            gr.Clear(Color.White);

            gr.DrawImage(moveBack.textr, moveBack.x, moveBack.y, moveBack.sizeX, moveBack.sizeY);
            moveBack.going();

            pictureBox_back.Image = bm;
        }

        void configLoad()
        {
            StreamReader FileRead = new StreamReader("GameFiles/config.txt");

            while (!FileRead.EndOfStream)
            {
                string temp = FileRead.ReadLine();
                int split = temp.IndexOf('=');
                string parametr = temp.Substring(0, split);
                string znachenie = temp.Substring(split+1, temp.Length-split-1);
                switch (parametr)
                {
                    case "Lang": if (znachenie == "1") IsEnglish = true; else IsEnglish = false; break;
                    case "dpiX": dpiX = Convert.ToInt32(znachenie); break;
                    case "dpiY": dpiY = Convert.ToInt32(znachenie); break;
                    case "sound": if (znachenie == "1") sound = true; else sound = false; break;
                    case "windowed": if (znachenie == "1") windowed = true; else windowed = false; break;
                }
            }

            FileRead.Close();

            checkBox_full.Checked = windowed;
            checkBox_sound.Checked = sound;
        }

        void configSave()
        {
            StreamWriter sw = new StreamWriter("GameFiles/config.txt");
            string param="";
            string pValue="";
            param="Lang";
            if(IsEnglish) pValue="1"; else pValue="0";
            sw.WriteLine(param + "=" + pValue);

            param = "dpiX";
            pValue = dpiX.ToString();
            sw.WriteLine(param + "=" + pValue);

            param = "dpiY";
            pValue = dpiY.ToString();
            sw.WriteLine(param + "=" + pValue);

            param = "sound";
            if (sound) pValue = "1"; else pValue = "0";
            sw.WriteLine(param + "=" + pValue);

            param = "windowed";
            if (windowed) pValue = "1"; else pValue = "0";
            sw.Write(param + "=" + pValue);

            sw.Close();
        }

        void locale_load()
        {
            StreamReader FileRead = new StreamReader("GameFiles/Lang/GUI.txt");
            LangList.Clear();
            int i=0;
            while (!FileRead.EndOfStream)
            {
                string temp = FileRead.ReadLine();
                string[] x = temp.Split('*');
                LangList.Add(new LangGUI(x[0], x[1]));
                i++;
            }
            FileRead.Close();
        }

        void localize()
        {
            try
            {
                button_new.Text = LangList[0].Get(IsEnglish);
                button_load.Text=LangList[1].Get(IsEnglish);
                button_options.Text=LangList[2].Get(IsEnglish);
                button_about.Text=LangList[3].Get(IsEnglish);
                button_exit.Text=LangList[4].Get(IsEnglish);
                this.Text = LangList[5].Get(IsEnglish);
                button_cancel.Text = LangList[6].Get(IsEnglish);
                button_canelGame.Text = LangList[6].Get(IsEnglish);
                checkBox_sound.Text = LangList[7].Get(IsEnglish);
                label_dpi.Text = LangList[8].Get(IsEnglish);
                checkBox_full.Text = LangList[9].Get(IsEnglish);
                label_newGame.Text = LangList[10].Get(IsEnglish);
                button_bot.Text = LangList[11].Get(IsEnglish);
                button_two.Text = LangList[12].Get(IsEnglish);       
            }
            catch
            {
                MessageBox.Show("Oops! Where is error of locale loading!");
            }

            if (IsEnglish) button_lang.BackgroundImage = flagEng;
            else button_lang.BackgroundImage = flagRus;
        }

        private void button_lang_Click(object sender, EventArgs e)
        {
            IsEnglish = !IsEnglish;
            localize();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            configSave();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer_loop_Tick(object sender, EventArgs e)
        {
            Render();
        }

        void buttonUse(object sender, EventArgs e)
        {
            (sender as Button).BackgroundImage = buttonOn;
        }

        void buttonNotUse(object sender, EventArgs e)
        {
            (sender as Button).BackgroundImage = buttonOff;
        }

        void buttonAcceptUse(object sender, EventArgs e)
        {
            (sender as Button).BackgroundImage = imgAcceptOn;
        }

        void buttonAcceptNotUse(object sender, EventArgs e)
        {
            (sender as Button).BackgroundImage = imgAccept;
        }

        private void button_about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logic"+Environment.NewLine+"v1.0 alpha"+Environment.NewLine+"RikoshetRU");
        }

        private void button_options_Click(object sender, EventArgs e)
        {
            hidePanel();

            int x=Screen.PrimaryScreen.Bounds.Width;
            int y=Screen.PrimaryScreen.Bounds.Height;
            string good = x.ToString() + "x" + y.ToString();
            if(!comboBox1.Items.Contains(good)) comboBox1.Items.Add(good);

            comboBox1.Text = dpiX.ToString() + "x" + dpiY.ToString();

            showPanel_options();
        }

        void showPanel_options()
        {
            panel1.Visible = true;
            label_dpi.Visible = true;
            comboBox1.Visible = true;
            checkBox_full.Visible = true;
            checkBox_sound.Visible = true;
            button_cancel.Visible = true;
            button_acept.Visible = true;
            pictureBox_beam_opt.Visible = true;
        }

        public void hidePanel()
        {
            panel1.Visible = false;
            label_dpi.Visible = false;
            comboBox1.Visible = false;
            checkBox_full.Visible = false;
            checkBox_sound.Visible = false;
            button_cancel.Visible = false;
            button_acept.Visible = false;
            label_newGame.Visible = false;
            button_bot.Visible = false;
            button_two.Visible = false;
            button_canelGame.Visible = false;
            pictureBox_beam_opt.Visible = false;
            pictureBox_beamNew.Visible = false;
        }

        private void button_acept_Click(object sender, EventArgs e)
        {
            hidePanel();
            string[] x = comboBox1.Text.Split('x');
            dpiX = Convert.ToInt32(x[0]);
            dpiY = Convert.ToInt32(x[1]);
            sound = checkBox_sound.Checked;
            windowed = checkBox_full.Checked;
            configSave();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            hidePanel();
        }

        private void button_new_Click(object sender, EventArgs e)
        {
            hidePanel();
            panelNewGameShow();
        }

        void panelNewGameShow()
        {
            panel1.Visible = true;
            label_newGame.Visible = true;
            button_bot.Visible = true;
            button_two.Visible = true;
            button_canelGame.Visible = true;
            pictureBox_beamNew.Visible = true;
        }

        private void button_canelGame_MouseClick(object sender, MouseEventArgs e)
        {
            hidePanel();
        }

        private void button_two_Click(object sender, EventArgs e)
        {
            timer_loop.Enabled = false;
            this.Hide();
            Program.fGame = new Form_game(dpiX, dpiY);
            Program.fGame.Show();
        }
    }
}
