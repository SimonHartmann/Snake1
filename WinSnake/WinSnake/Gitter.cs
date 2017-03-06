using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WinSnake
{
    class Gitter
    {
        Graphics g;
        

        public void Linien(PictureBox pb)
        {
            g = pb.CreateGraphics();
            for (int i = 0; i < 450; i=i+15)
            {
                g.DrawLine(Pens.Black,0, i, 450, i);
                g.DrawLine(Pens.Black, i, 0, i, 450);
            }
        }
    }
}
