using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenTK.Graphics.OpenGL;
using System.Drawing;

namespace Logic
{
    class Render
    {
        static public void main()
        {
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.LoadIdentity();
            GL.Translate(Program.fGame.posCamX, Program.fGame.posCamY, 0);

            //КАРТА
            foreach (gameObjMain t in Program.gameList.ground)
            {
                t.draw();
            }

            //ОБЪЕКТЫ
            foreach (gameObjMain t in Program.gameList.objects)
            {
                t.draw();
            }

            //АКТЕРЫ
            foreach (gameObjMain t in Program.gameList.actors)
            {
                t.draw();
            }
        }

        static public void drawQuad(int texId, float p1x, float p1y, float p2x, float p2y)
        {
            Program.gameList.textures[texId].bind();
            GL.Begin(BeginMode.Quads);
                GL.TexCoord2(0, 0); GL.Vertex2(p1x, p1y);
                GL.TexCoord2(0, 1); GL.Vertex2(p1x, p2y);
                GL.TexCoord2(1, 1); GL.Vertex2(p2x, p2y);
                GL.TexCoord2(1, 0); GL.Vertex2(p2x, p1y);
            GL.End();
        }
    }
}
