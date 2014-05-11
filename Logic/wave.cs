using System;

namespace Logic
{
    public class wave_cl
    {
        public int[,] wave;
        static int maxWave = 5;

        public wave_cl()
        {
            wave = new int[maxWave, maxWave];
        }

        public IntPoint hunt(IntPoint whereNow, IntPoint toGo)
        {
            IntPoint whereNowOld = new IntPoint(whereNow.x, whereNow.y);

            if (whereNow.x < 0) whereNow.x = 0;
            if (whereNow.x >= maxWave) whereNow.x = maxWave - 1;
            if (toGo.x < 0) toGo.x = 0;
            if (toGo.x >= maxWave) toGo.x = maxWave - 1;
            if (whereNow.y < 0) whereNow.y = 0;
            if (whereNow.y >= maxWave) whereNow.y = maxWave - 1;
            if (toGo.y < 0) toGo.y = 0;
            if (toGo.y >= maxWave) toGo.y = maxWave - 1;

            build_wave(0, 0, toGo.x, toGo.y);
            int d = wave[whereNow.x, whereNow.y];
            if (d != 0)
            {
                int size = wave.GetLength(0);
                int size2 = wave.GetLength(1);

                if (WorldLive.percent(50))
                {
                    if (whereNow.x > 0) if (wave[whereNow.x - 1, whereNow.y] == d - 1) return new IntPoint(whereNowOld.x-1, whereNowOld.y);// h.move("up");
                    if (whereNow.x < size - 1) if (wave[whereNow.x + 1, whereNow.y] == d - 1) return new IntPoint(whereNowOld.x+1, whereNowOld.y);//h.move("down");
                    if (whereNow.y > 0) if (wave[whereNow.x, whereNow.y - 1] == d - 1) return new IntPoint(whereNowOld.x, whereNowOld.y-1);//h.move("left");
                    if (whereNow.y < size2 - 1) if (wave[whereNow.x, whereNow.y + 1] == d - 1) return new IntPoint(whereNowOld.x, whereNowOld.y+1);//h.move("right");
                }
                else
                {
                    if (whereNow.y > 0) if (wave[whereNow.x, whereNow.y - 1] == d - 1) return new IntPoint(whereNowOld.x, whereNowOld.y - 1);//h.move("left");
                    if (whereNow.y < size2 - 1) if (wave[whereNow.x, whereNow.y + 1] == d - 1) return new IntPoint(whereNowOld.x, whereNowOld.y + 1);//h.move("right");
                    if (whereNow.x > 0) if (wave[whereNow.x - 1, whereNow.y] == d - 1) return new IntPoint(whereNowOld.x - 1, whereNowOld.y);// h.move("up");
                    if (whereNow.x < size - 1) if (wave[whereNow.x + 1, whereNow.y] == d - 1) return new IntPoint(whereNowOld.x + 1, whereNowOld.y);//h.move("down");
                }
            }
            return new IntPoint(-1, -1);
        }

        public void build_wave(int hunt_x, int hunt_y, int run_x, int run_y)
        {
            for (int i = 0; i < wave.GetLength(0); i++)
            {
                for (int j = 0; j < wave.GetLength(1); j++)
                {
                    wave[i, j] = 0;
                }
            }

            wave[run_x, run_y] = 1;

            int d = 1;
            int size = wave.GetLength(0);
            int size2 = wave.GetLength(1);
            while (wave[hunt_x, hunt_y] == 0 && d < wave.Length)
            {
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size2; j++)
                    {
                        if (wave[i, j] == d)
                        {
                            if (i > 0) for_build(i - 1, j, d, hunt_x, hunt_y);
                            if (i < size - 1) for_build(i + 1, j, d, hunt_x, hunt_y);
                            if (j > 0) for_build(i, j - 1, d, hunt_x, hunt_y);
                            if (j < size2 - 1) for_build(i, j + 1, d, hunt_x, hunt_y);
                        }
                    }
                }
                d++;
            }
        }

        public void for_build(int i, int j, int d, int hx, int hy)
        {
            foreach (gameObjMain t in Program.gameList.objects)
            {
                if (t.i == i && t.j == j && t.IsBlocking == true) return;
            }
            wave[i, j] = d + 1;
        }
    }
}
