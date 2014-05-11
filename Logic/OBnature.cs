using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logic
{
    class OBtree : gameObjMain
    {
        int age;
        int health;

        public OBtree(int i, int j, int texture)
            : base(i, j, texture) { health = 100; age = 0; }

        public void Time()
        {
            age++;
        }
    }

    class OBstone : gameObjMain
    {
        public OBstone(int i, int j, int texture)
            : base(i, j, texture) { }
    }

    class OBeatGrass : gameObjMain, grassEat
    {
        public int eat;

        public OBeatGrass(int i, int j, int texture)
            : base(i, j, texture) { eat = 10; }
    }
}
