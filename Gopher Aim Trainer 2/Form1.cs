﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gopher_Aim_Trainer_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkRed;
            this.TransparencyKey = Color.DarkRed;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void playGame_Click(object sender, EventArgs e)
        {
            the_game aim_trainer = new the_game();

            aim_trainer.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
