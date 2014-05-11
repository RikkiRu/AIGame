using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OpenTK.Graphics.OpenGL;

namespace Logic
{
    public partial class Form_game : Form
    {
        // --------
        public float ortoX;
        public float ortoY;
        Image imgDoorOpen;
        Image imgDoorClose;
        public float posCamX=0;
        public float posCamY=0;
        public float speedOfView=10;
        public WorldLive WL;

        public delegate void voidfunc();
        public event voidfunc Time;

        int iteration;
        // --------

        public Form_game(int x, int y)
        {
            InitializeComponent();

            if (Program.f1.windowed)
            {
                int mX = Screen.PrimaryScreen.WorkingArea.Width;
                mX -= mX / 100;
                int mY = Screen.PrimaryScreen.WorkingArea.Height;
                mY -= mY / 100;
                if (x > mX) x = mX;
                if (y > mY) y = mY;
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
            }

            this.Width = x;
            this.Height = y;
            posCamX = 0;
            posCamY = 0;
        }

        private void Form_game_Load(object sender, EventArgs e)
        {
            this.Text = Program.f1.Text;
            imgDoorOpen = Image.FromFile("GameFiles/textures/InGame/doorOpen.png");
            imgDoorClose = Image.FromFile("GameFiles/textures/InGame/doorClose.png");
            pictureBox_door.Image = imgDoorClose;
            pictureBox_door.Parent = this;

            GL.ClearColor(1.0f, 1.0f, 1.0f, 1.0f);
            GL.Enable(EnableCap.Texture2D);
            GL.Enable(EnableCap.Blend);
            GL.BlendFunc(BlendingFactorSrc.SrcAlpha, BlendingFactorDest.OneMinusSrcAlpha);


            matrix(glControl1.Width, glControl1.Height);
            Program.gameList = new gameObjList();
            WL = new WorldLive();
            timer_game.Enabled = true;
            iteration = 0;
        }

        private void Form_game_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.f1.hidePanel();
            Program.f1.timer_loop.Enabled = true;
            Program.f1.Show();
        }

        void matrix(int w, int h)
        {
            ortoX = 100;
            ortoY = 100;
            if (h == 0) h = 1;
            float aspect = (float)w / (float)h;
            GL.Viewport(0, 0, w, h);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            if (w < h) { GL.Ortho(0, ortoX, ortoY / aspect, 0, -2, 2); ortoY = ortoY / aspect; }
            else { GL.Ortho(0, ortoX * aspect, ortoY, 0, -2, 2); ortoX = ortoX * aspect; }
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();
        }

        private void timer_game_Tick(object sender, EventArgs e)
        {
            if (iteration < 50)
            {
                    Render.main();
                    WL.main();
                    glControl1.SwapBuffers();
                
                iteration++;
            }

            else
            {
                timer_game.Enabled = false;
                iteration = 0;
                if (Time != null) Time();

                
                timer_game.Enabled = true;
            }
        }

        private void pictureBox_door_MouseEnter(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = imgDoorOpen;
        }

        private void pictureBox_door_MouseLeave(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = imgDoorClose;
        }

        private void pictureBox_door_MouseClick(object sender, MouseEventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void Form_game_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A: posCamX += speedOfView; break;
                case Keys.D: posCamX -= speedOfView; break;
                case Keys.W: posCamY += speedOfView; break;
                case Keys.S: posCamY -= speedOfView; break;
            }
        }

        private void timer_short_Tick(object sender, EventArgs e)
        {
           
        }


   
    }
}
