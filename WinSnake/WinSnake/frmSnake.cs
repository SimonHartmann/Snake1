﻿using System;
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
        //int intKastenX;
        //int intKastenY;
        int intBoxSize = 15;




        public frmSnake()
        {
            InitializeComponent();
            sp = new Spiel();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pbSpielfeld_Click(object sender, EventArgs e)
        {
            sp.EssenGenerieren(pbSpielfeld, Brushes.Green, intBoxSize);
            sp.Schlange(pbSpielfeld,Brushes.Pink, 10, 10, intBoxSize);
        }
    }
}
