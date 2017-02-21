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

        Graphics g;
        PictureBox pb;

        public void Schlange(PictureBox pb,Brush bfarbe, int intx, int inty,int intboxsize)
        {
            g = pb.CreateGraphics();
            g.FillEllipse(bfarbe, intx - (intboxsize / 2), inty - (intboxsize / 2), intboxsize, intboxsize);
        }
    }
}
