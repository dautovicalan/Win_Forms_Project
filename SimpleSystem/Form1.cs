﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//ALAN JE MALI BOSANAC I VOLI PRIMAT U GUZU VELIKE PORCIJE
namespace SimpleSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            label1.Text = "Marosini je sad gejko";
        }
    }
}
