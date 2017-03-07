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
        Gitter git;
        //int intKastenX;
        //int intKastenY;
        int intBoxSize = 15;
        int intTmerCounter;
        int intRichtung;
        int intAnfangX;
        int intAnfangY;
        int intEndeX;
        int intEndeY;
        int intX, intY;

        public frmSnake()
        {
            InitializeComponent();
            sp = new Spiel();
            git = new Gitter();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timerTick.Enabled = true;
            
            git.Linien(pbSpielfeld);

        }

        private void pbSpielfeld_Click(object sender, EventArgs e)
        {

            sp.EssenGenerieren(pbSpielfeld, Brushes.Green, intBoxSize);
        }

        private void timerTick_Tick(object sender, EventArgs e)
        {
            
            if (intRichtung == 1) //Links
            {
                sp.Schlange(pbSpielfeld, Brushes.Pink, intX--, intY, intBoxSize);
            }
            else if (intRichtung == 2) //Rechts
            {
                sp.Schlange(pbSpielfeld, Brushes.Pink, intX++, intY, intBoxSize);
            }
            else if (intRichtung == 3) //Hoch
            {
                sp.Schlange(pbSpielfeld, Brushes.Pink, intX, intY --, intBoxSize);
            }
            else if (intRichtung == 4) //Runter
            {
                sp.Schlange(pbSpielfeld, Brushes.Pink, intX, intY ++, intBoxSize);
            }
            else
            {
                sp.Schlange(pbSpielfeld, Brushes.Pink, 16, 15+intTmerCounter, intBoxSize);
            }
           
            intTmerCounter++;

        }

        private void frmSnake_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    intRichtung = 1;
                    break;
                case Keys.Right:
                    intRichtung = 2;
                    break;
                case Keys.Up:
                    intRichtung = 3;
                    break;
                case Keys.Down:
                    intRichtung = 4;
                    break;
                default:
                    break;
            }
        }
    }
}
