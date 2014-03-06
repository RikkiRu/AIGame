using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logic
{
    public class WorldLive
    {
        public static Random rand = new Random();
        public static int worldSizeX;
        public static int worldSizeY;
        public static int chunkSizeX;
        public static int chunkSizeY;
        public static int halfChunkSizeX;
        public static int halfChunkSizeY;
        public static wave_cl Wave;

        public WorldLive()
        {
            worldSizeX=50;
            worldSizeY=50; 
            chunkSizeX = 10;
            chunkSizeY = 10;
            halfChunkSizeX = chunkSizeX / 2;
            halfChunkSizeY = chunkSizeY / 2;
            genNature();
            Wave = new wave_cl();
        }

        void genNature()
        {
            gameObjMain temp;

            for (int i = 0; i < worldSizeX; i++)
            {
                for (int j = 0; j < worldSizeY; j++)
                {
                    Program.gameList.ground.Add(new OBFloor(i, j, 0));
                    if (percent(10)) { temp = new OBtree(i, j, 1); Program.gameList.objects.Add(temp); ; continue; }
                    if (percent(3)) { temp = new OBstone(i, j, 2); temp.IsBlocking = true; Program.gameList.objects.Add(temp); continue; }
                    if (percent(5)) { temp = new OBeatGrass (i, j, 4); Program.gameList.objects.Add(temp); continue; }
                }
            }

            temp = new OBrabbit(5, 7, 5);
            Program.gameList.actors.Add(temp);
        }

        static public bool percent(int p)
        {
            if(p<0) p=0;
            if(p>100) p=100;

            if (rand.Next(101) <= p) return true;
            else return false;
        }

        public void main()
        {
        }
    }
}
