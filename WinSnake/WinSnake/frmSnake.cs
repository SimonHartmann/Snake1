using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinSnake
{
    public partial class frmSnake : Form
    {
        Spiel sp;
        int intKastenX;
        int intKastenY;

        

        public frmSnake()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pbSpielfeld_Click(object sender, EventArgs e)
        {
            sp = new Spiel();
            sp.Schlange(pbSpielfeld,Brushes.Pink, 10, 10, 15);
        }

        private void frmSnake_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Left:
                    break;
                case Keys.Right:
                    break;
                case Keys.Up:
                    break;
                case Keys.Down:
                    break;
                default:
                    break;
            }
        }
    }
}
