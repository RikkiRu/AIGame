using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Logic
{
    class movieImg
    {
        public int x;
        public int y;
        public int SpeedX;
        public int SpeedY;
        int vec;
        public int sizeX;
        public int sizeY;
        public Image textr;
        public List<moveImgPoint> mas;

        public movieImg(int x, int y, int sizeX, int sizeY, Image img)
        {
            this.x = x;
            this.y = y;
            this.sizeX = sizeX;
            this.sizeY = sizeY;
            textr = img;
            mas = new List<moveImgPoint>();
            vec = 0;
        }

        public void SetSpeed()
        {
            SpeedX = mas[0].speedX;
            SpeedY = mas[0].speedY;
        }

        public void going()
        {
            if (!mas[vec].IsAble(x, y))
            {
                if (vec < mas.Count - 1)
                {
                    vec++;
                }
                else
                {
                    vec = 0;
                }

                SpeedX = mas[vec].speedX;
                SpeedY = mas[vec].speedY;
            }
            else
            {
                x += SpeedX;
                y += SpeedY;
            }
        }
    }

    class moveImgPoint
    {
        public int speedX;
        public int speedY;
        public int minX;
        public int maxX;
        public int minY;
        public int maxY;
        public bool minXon;
        public bool maxXon;
        public bool minYon;
        public bool maxYon;

        public moveImgPoint()
        {
            clear();
        }

        public void clear()
        {
            speedX = 0;
            speedY = 0;
            minX = 0;
            maxX = 0;
            minY = 0;
            maxY = 0;
            minXon = false;
            maxXon = false;
            minYon = false;
            maxYon = false;
        }

        public bool IsAble(int px, int py)
        {
            if (minXon) if (px < minX) return false;
            if (maxXon) if (px > maxX) return false;
            if (minYon) if (py < minY) return false;
            if (maxYon) if (py > maxY) return false;
      
            return true;
        }
    }
}
