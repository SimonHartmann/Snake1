using System;
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
        public int intBoxsize;
        public Color cFarbe;
        public int intX;
        public int intY;

        Graphics g;
        PictureBox pb;

        public void Schlange(PictureBox pb, int intx, int inty,int intboxsize)
        {
            g = pb.CreateGraphics();
            g.FillEllipse(Brushes.Pink, intx - (intboxsize / 2), inty - (intboxsize / 2), intboxsize, intboxsize);
        }
    }
}
