using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using OpenTK.Graphics.OpenGL;

namespace Logic
{
    class gameObjList
    {
        public List<Textures> textures;
        public List<gameObjInter> ground;
        public List<gameObjMain> objects;
        public List<gameObjMain> actors;

        public gameObjList()
        {
            textures = new List<Textures>();
            ground = new List<gameObjInter>();
            objects = new List<gameObjMain>();
            actors = new List<gameObjMain>();

            Textload();
        }

        public void UpdateLists()
        {
            textures.Clear();
            ground.Clear();
            objects.Clear();
            actors.Clear();
        }

        void Textload()
        {            
            textures.Add(new Textures(@"GameFiles/textures/InGame/grass.png"));//0
            textures.Add(new Textures(@"GameFiles/textures/InGame/tree.png"));//1
            textures.Add(new Textures(@"GameFiles/textures/InGame/stone.png"));//2
            textures.Add(new Textures(@"GameFiles/textures/InGame/stiv.png"));//3
            textures.Add(new Textures(@"GameFiles/textures/InGame/eatGrass.png"));//4
            textures.Add(new Textures(@"GameFiles/textures/InGame/rabbit.png"));//5
        }
    }

    interface gameObjInter
    {
        void draw();
    }

    interface eat
    {
    }

    interface grassEat : eat
    {
    }

    abstract class gameObjMain:gameObjInter
    {
        public int i;
        public int j;
        public int texture;
        public bool IsKill;
        public bool IsBlocking;

        public int forRenderX1;
        public int forRenderY1;
        public int forRenderX2;
        public int forRenderY2;

        public void setPos(int i, int j)
        {
            if (i < 0) i = 0;
            if (j < 0) j = 0;
            if (i >= WorldLive.worldSizeX) i = WorldLive.worldSizeX - 1;
            if (j >= WorldLive.worldSizeY) j = WorldLive.worldSizeY - 1;

            this.i = i;
            this.j = j;

            forRenderX1 = (i) * WorldLive.chunkSizeX;
            forRenderY1 = (j) * WorldLive.chunkSizeY;
            forRenderX2 = forRenderX1 + WorldLive.chunkSizeX;
            forRenderY2 = forRenderY1 + WorldLive.chunkSizeY;
        }

        public gameObjMain(int i, int j, int texture)
        {
            IsKill = false;
            this.i = i;
            this.j = j;
            this.texture = texture;
            IsBlocking = false;
            setPos(i, j);
        }

        public virtual void draw()
        {
            Render.drawQuad(texture, forRenderX1, forRenderY1, forRenderX2, forRenderY2);
        }
    }

    class OBFloor : gameObjMain
    {
        public OBFloor(int i, int j, int texture)
            : base(i, j, texture) {  }
    }
}
