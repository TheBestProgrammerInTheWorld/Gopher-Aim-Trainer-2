using System;
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
    public partial class the_game : Form
    {
        public the_game()
        {
            InitializeComponent();
        }


        // --- EXIT AND RESTART BUTTONS ---
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void restart_game_Click(object sender, EventArgs e)
        {
            ShotsCount = 0;
            HitCount = 0;
            MissCount = 0;

            hit_count.Text = "0";
            miss_count.Text = "0";
            shot_counter.Text = "0";
        }


        // --- COUNTERS ---
        int ShotsCount = 0;
        int HitCount = 0;
        int MissCount = 0;

        void shot_noise()
        {
            //AUDIO FILES DO NOT WORK ON THIS COMPUTER
            /*
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\jwireman\Music\Sound Effects\Shotsound");
            player.Play();
            */
        }

        //function
        void fn_shot()
        {
            HitCount++;
            hit_count.Text = HitCount.ToString();

            ShotsCount++;
            shot_counter.Text = ShotsCount.ToString();

            double accuracy = (HitCount / ShotsCount) * 10;
        }

        //function
        void fn_missShot()
        {
            MissCount++;
            miss_count.Text = MissCount.ToString();

            ShotsCount++;
            shot_counter.Text = ShotsCount.ToString();
        }

        //click gopher
        private void Gopher_Click(object sender, EventArgs e)
        {
            fn_shot();
        }

        //miss gopher (click window)
        private void the_game_MouseClick(object sender, MouseEventArgs e)
        {
            fn_missShot();

            //sets gameover menu into view once at 10 missed shots
            if (MissCount >= 10)
            {
                timer.Stop();
                gameover_label.Location = new Point(444, 302);
                playagain_label.Location = new Point(478, 379);
                yes_playagain.Location = new Point(658, 372);
                dash.Location = new Point(703, 379);
                no_dontplayagain.Location = new Point(728, 372);
                Gopher.Location = new Point(2400, 2400);
            }
        }


        // --- GOPHER POSITIONING ---
        Random r = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            int x, y;
            x = r.Next(-10, 1140);
            y = r.Next(445, 560);
            Gopher.Location = new Point(x, y);
        }


        // --- GAME OVER BUTTONS ---
        private void yes_playagain_Click(object sender, EventArgs e)
        {
            ShotsCount = 0;
            HitCount = 0;
            MissCount = 0;

            hit_count.Text = "0";
            miss_count.Text = "0";
            shot_counter.Text = "0";

            gameover_label.Location = new Point(2400, 2400);
            playagain_label.Location = new Point(2400, 2400);
            yes_playagain.Location = new Point(2400, 2400);
            dash.Location = new Point(2400, 2400);
            no_dontplayagain.Location = new Point(2400, 2400);
            timer.Start();
        }

        private void no_dontplayagain_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
