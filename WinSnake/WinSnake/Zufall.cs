using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WinSnake
{
    class Zufall
    {
        Random rnd = new Random(DateTime.Now.Millisecond);

        public Zufall(int intMinimum, int intMaximum)
        {
            rnd.Next(intMinimum,intMaximum);
        }

       
    }
}
