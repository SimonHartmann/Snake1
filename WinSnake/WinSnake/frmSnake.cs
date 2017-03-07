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

        public frmSnake()
        {
            InitializeComponent();
            sp = new Spiel();
            git = new Gitter();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void cmdStart_Click(object sender, EventArgs e)
        {
            timerTick.Enabled = true;
            
            sp.Schlange(pbSpielfeld, Brushes.Pink, 3, 3, intBoxSize);
            git.Linien(pbSpielfeld);

        }

        private void pbSpielfeld_Click(object sender, EventArgs e)
        {
            sp.EssenGenerieren(pbSpielfeld, Brushes.Green, intBoxSize);

        }

        private void timerTick_Tick(object sender, EventArgs e)
        {        
            if (intRichtung == 1)//links
            {
                sp.Schlange(pbSpielfeld, Brushes.Pink, -1, intTmerCounter, intBoxSize);
            }
            else if (intRichtung == 2)//rechts
            {
                sp.Schlange(pbSpielfeld, Brushes.Pink, 1, intTmerCounter, intBoxSize);
            }
            else if (intRichtung == 3)//hoch
            {

            }
            else if (intRichtung == 4)//runter
            {

            }
            else
            {
                sp.Schlange(pbSpielfeld, Brushes.Pink, 3, intTmerCounter, intBoxSize);
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
