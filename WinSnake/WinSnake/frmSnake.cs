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
        Gitter git;
        //int intKastenX;
        //int intKastenY;
        int intBoxSize = 15;

    
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
            sp.Schlange(pbSpielfeld, Brushes.Pink, 15, 15, intBoxSize);
            sp.EssenGenerieren(pbSpielfeld, Brushes.Green, intBoxSize);
            git.Linien(pbSpielfeld);

        }

        private void pbSpielfeld_Click(object sender, EventArgs e)
        {
            

        }

        
    }
}
