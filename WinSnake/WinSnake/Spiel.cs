﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WinSnake
{
    class Spiel
    {

        Graphics g;
        PictureBox pb;
        Random rnd = new Random(DateTime.Now.Millisecond);

        public int intEssenY;
        public int intEssenX;

        public void Schlange(PictureBox pb,Brush bfarbe, int intx, int inty,int intboxsize)
        {
            intx = intx * intboxsize;
            inty = inty * intboxsize;
            g = pb.CreateGraphics();
            g.FillEllipse(bfarbe, intx -intboxsize, inty - intboxsize, intboxsize, intboxsize);
        }

        public void EssenGenerieren(PictureBox pb, Brush bfarbe, int intboxsize) {

            intEssenX = rnd.Next(0,30);
            intEssenY = rnd.Next(0,30);
            g = pb.CreateGraphics();
            g.FillEllipse(bfarbe,intEssenX*intboxsize,intEssenY*intboxsize,intboxsize,intboxsize);


        }


    }
}
