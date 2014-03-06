using OpenTK.Graphics.OpenGL;
using System.Drawing;
using System.Collections.Generic;
using System;

namespace Logic
{
    delegate void Task();

    public class IntPoint
    {
        public int x;
        public int y;

        public IntPoint()
        {
            x = 0;
            y = 0;
        }

        public IntPoint(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    class OBhuman:gameObjMain
    {
        public OBhuman(int i, int j, int texture)
            : base(i, j, texture) { }
    }

    class OBrabbit : gameObjMain
    {
        public OBrabbit(int i, int j, int texture)
            : base(i, j, texture) { say("Я живу!"); health = 100; wantEat = 100; Program.fGame.Time += Fact; priority = 0; stage = 0; }

        int sayTime=0;
        font iSpeaking;
        int health;
        int wantEat;

        object target;

        int stage;
        int priority;
        Task action;

        void Fact()
        {
            wantEat++;
            if (wantEat > 700) { Program.gameList.actors.Remove(this); }
            mind();
        }

        void mind()
        {
            if (priority == 0)
            {
                action = someSearch;
                TaskChange(1);
            }

            if(action!=null) action();
        }

        void TaskChange(int prioritet)
        {
            stage = 0;
            priority = prioritet;
        }

        void someSearch()
        {
            switch (stage)
            {
                case 0: 
                    say("Кушать хочу"); 
                    target = new IntPoint(-1, -1); 
                    foreach(gameObjMain t in Program.gameList.objects)
                    {
                        if (t is grassEat) { (target as IntPoint).x = t.i; (target as IntPoint).y = t.j; stage++; say("О вон какая вкусняшка!"); return; }
                    }
                    say("Похоже еды нет. Хнык хнык.");

                    break; //выбор точки

                case 1:
                    if (i == (target as IntPoint).x && j == (target as IntPoint).y)
                    {
                        priority = 0;
                        say("Ну пришел вроде");
                        stage++;
                    }
                    else
                    {
                       IntPoint t = WorldLive.Wave.hunt(new IntPoint(i, j), new IntPoint((target as IntPoint).x, (target as IntPoint).y));
                       TryToMove(t);
                    }
                    break; //волна

                case 2: 
                    break; //съел
            }
            
        }

        void TryToMove(IntPoint where)
        {
            if (where.x >= 0 && where.y >= 0 && where.x < WorldLive.worldSizeX && where.y < WorldLive.worldSizeY)
            {
                foreach (gameObjMain t in Program.gameList.objects)
                {
                    if (t.i == where.x && t.j == where.y && t.IsBlocking == true) { say("Не пройти"); return; }
                }

                setPos(where.x, where.y);
                say(i.ToString() + " " + j.ToString());
            }

            else say("Хм..");
        }

        public void say(string s)
        {
            iSpeaking = new font(s, forRenderX1, forRenderY1, Color.Blue, 25); 
            sayTime = 100;
        }

        public override void draw()
        {
            base.draw();

            if (sayTime > 0)
            {
                iSpeaking.move(forRenderX1, forRenderY1);

                iSpeaking.labels.bind();
                GL.Begin(BeginMode.Quads);
                GL.TexCoord2(0, 0); GL.Vertex2(iSpeaking.label_x, iSpeaking.label_y);
                GL.TexCoord2(0, 1); GL.Vertex2(iSpeaking.label_x, iSpeaking.label_height);
                GL.TexCoord2(1, 1); GL.Vertex2(iSpeaking.label_lengh, iSpeaking.label_height);
                GL.TexCoord2(1, 0); GL.Vertex2(iSpeaking.label_lengh, iSpeaking.label_y);
                GL.End();
                sayTime--;
            }
        }


    }


}
