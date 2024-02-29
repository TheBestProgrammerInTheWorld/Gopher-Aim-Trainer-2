using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gopher_Aim_Trainer_2
{
    public partial class the_game : Form
    {
        public the_game()
        {
            InitializeComponent();

            //Gopher.BackColor = System.Drawing.Color.Transparent;
            //Gopher5.Controls.Add(Gopher4);
            //Gopher4.BackColor = Color.Transparent;

            //Gopher4.Controls.Add(Gopher3);
            //Gopher3.BackColor = Color.Transparent;

            //Gopher3.Controls.Add(Gopher2);
            //Gopher2.BackColor = Color.Transparent;

            //Gopher2.Controls.Add(Gopher);
            //Gopher.BackColor = Color.Transparent;

        }
        //void ParentPictureBox_Paint(object sender, PaintEventArgs e)
        //{
        //    Graphics g = e.Graphics;

        //    var controls = this.Gopher.Controls.OfType<PictureBox>();
        //    foreach (var c in controls)
        //    {
        //        g.DrawImage(c.Image, c.Location.X, c.Location.Y, c.Width, c.Height);
        //    }
        //}



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
        double ShotsCount = 0;
        double HitCount = 0;
        double MissCount = 0;



// --- NOISES DONT WORK ---
        void shot_noise()
        {
            //SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\admin\source\repos\Gopher Aim Trainer 2 - backup\Gopher Aim Trainer 2\bin\Debug\sample.mp3");
            //player.Play();
            SoundPlayer p = new SoundPlayer();
            p.SoundLocation = @"C:\Users\jwireman\Desktop\Gopher Aim Trainer 2 - backup\Gopher Aim Trainer 2\bin\Debug\halloweenimpact.wav";
            p.Play();
        }



// --- CHANGES SIZE BASED OFF DISTANCE
        //void changesize()
        //{
        //    if (Gopher.Location.Y < 475)
        //    {
        //        Size size = new Size(120, 100);
        //        Gopher.Size = size;
        //    }
        //    else if(Gopher.Location.Y >= 475 && Gopher.Location.Y < 500)
        //    {
        //        Size size = new Size(140, 130); 
        //        Gopher.Size = size;
        //    } 
        //    else if (Gopher.Location.Y >= 500)
        //    {
        //        Size size = new Size(180, 160);
        //        Gopher.Size = size;
        //    }
        //}



// --- FUNCTION(S) TO CHANGE PSOTION AND ANIMATION ---
        Random r = new Random();
        bool Gopher1_Targetable = true;
        bool Gopher2_Targetable = true;
        bool Gopher3_Targetable = true;
        bool Gopher4_Targetable = true;
        bool Gopher5_Targetable = true;

        //GOPHER 1
        async void fn_shot1()
        {
            Gopher1_Targetable = false;

            HitCount+=1;
            hit_count.Text = HitCount.ToString();

            ShotsCount+=1;
            shot_counter.Text = ShotsCount.ToString();

            double countAccuracy = Math.Round((HitCount / ShotsCount) * 100);
            accuracy.Text = countAccuracy.ToString() + " % ";

            Gopher.Image = Gopher_Aim_Trainer_2.Properties.Resources.Gofershot;
            await Task.Delay(800);
            int x, y;
            x = r.Next(-20, 160);
            y = r.Next(445, 560);
            Gopher.Location = new Point(x, y);
            //changesize();

            Gopher.Image = Gopher_Aim_Trainer_2.Properties.Resources.GoferRise;
            await Task.Delay(600);

            Gopher.Image = Gopher_Aim_Trainer_2.Properties.Resources.Goferidle;

            Gopher1_Targetable = true;
        }
        //GOPHER 2
        async void fn_shot2()
        {
            Gopher2_Targetable = false;

            HitCount += 1;
            hit_count.Text = HitCount.ToString();

            ShotsCount += 1;
            shot_counter.Text = ShotsCount.ToString();

            double countAccuracy = Math.Round((HitCount / ShotsCount) * 100);
            accuracy.Text = countAccuracy.ToString() + "%";

            Gopher2.Image = Gopher_Aim_Trainer_2.Properties.Resources.Gofershot;
            await Task.Delay(800);
            int x, y;
            x = r.Next(220, 400);
            y = r.Next(445, 560);
            Gopher2.Location = new Point(x, y);
            //changesize();
            Gopher2.Image = Gopher_Aim_Trainer_2.Properties.Resources.GoferRise;
            await Task.Delay(600);

            Gopher2.Image = Gopher_Aim_Trainer_2.Properties.Resources.Goferidle;

            Gopher2_Targetable = true;
        }
        //GOPHER 3
        async void fn_shot3()
        {
            Gopher3_Targetable = false;

            HitCount += 1;
            hit_count.Text = HitCount.ToString();

            ShotsCount += 1;
            shot_counter.Text = ShotsCount.ToString();

            double countAccuracy = Math.Round((HitCount / ShotsCount) * 100);
            accuracy.Text = countAccuracy.ToString() + "%";

            Gopher3.Image = Gopher_Aim_Trainer_2.Properties.Resources.Gofershot;
            await Task.Delay(800);
            int x, y;
            x = r.Next(460, 640);
            y = r.Next(445, 560);
            Gopher3.Location = new Point(x, y);
            //changesize();
            Gopher3.Image = Gopher_Aim_Trainer_2.Properties.Resources.GoferRise;
            await Task.Delay(600);

            Gopher3.Image = Gopher_Aim_Trainer_2.Properties.Resources.Goferidle;

            Gopher3_Targetable = true;
        }
        //GOPHER 4
        async void fn_shot4()
        {
            Gopher4_Targetable = false;

            HitCount += 1;
            hit_count.Text = HitCount.ToString();

            ShotsCount += 1;
            shot_counter.Text = ShotsCount.ToString();

            double countAccuracy = Math.Round((HitCount / ShotsCount) * 100);
            accuracy.Text = countAccuracy.ToString() + "%";

            Gopher4.Image = Gopher_Aim_Trainer_2.Properties.Resources.Gofershot;
            await Task.Delay(800);
            int x, y;
            x = r.Next(700, 880);
            y = r.Next(445, 560);
            Gopher4.Location = new Point(x, y);
            //changesize();
            Gopher4.Image = Gopher_Aim_Trainer_2.Properties.Resources.GoferRise;
            await Task.Delay(600);

            Gopher4.Image = Gopher_Aim_Trainer_2.Properties.Resources.Goferidle;

            Gopher4_Targetable = true;
        }
        //GOPHER 5
        async void fn_shot5()
        {
            Gopher5_Targetable = false;

            HitCount += 1;
            hit_count.Text = HitCount.ToString();

            ShotsCount += 1;
            shot_counter.Text = ShotsCount.ToString();

            double countAccuracy = Math.Round((HitCount / ShotsCount) * 100);
            accuracy.Text = countAccuracy.ToString() + "%";

            Gopher5.Image = Gopher_Aim_Trainer_2.Properties.Resources.Gofershot;
            await Task.Delay(800);
            int x, y;
            x = r.Next(940, 1140);
            y = r.Next(445, 560);
            Gopher5.Location = new Point(x, y);
            //changesize();
            Gopher5.Image = Gopher_Aim_Trainer_2.Properties.Resources.GoferRise;
            await Task.Delay(600);

            Gopher5.Image = Gopher_Aim_Trainer_2.Properties.Resources.Goferidle;

            Gopher5_Targetable = true;
        }


// --- FUNCTION WHEN CLICK BACKGROUND = MISS SHOT ---
        void fn_missShot()
        {
            shot_noise();

            MissCount+=1;
            miss_count.Text = MissCount.ToString();

            ShotsCount+=1;
            shot_counter.Text = ShotsCount.ToString();

            double countAccuracy = Math.Round((HitCount / ShotsCount) * 100);
            accuracy.Text = countAccuracy.ToString() + "%";
        }

        

// --- CLICK A GOPHER SEE WHAT HAPPENS ---
        private void Gopher_Click(object sender, EventArgs e)
        {
            shot_noise();
            if (Gopher1_Targetable == true)
            {
                fn_shot1();
            }
        }
        private void Gopher2_Click(object sender, EventArgs e)
        {
            shot_noise();

            if (Gopher2_Targetable == true)
            {
                fn_shot2();
            }
        }

        private void Gopher3_Click(object sender, EventArgs e)
        {
            shot_noise();

            if (Gopher3_Targetable == true)
            {
                fn_shot3();
            }
        }

        private void Gopher4_Click(object sender, EventArgs e)
        {
            shot_noise();

            if (Gopher4_Targetable == true)
            {
                fn_shot4();
            }
        }

        private void Gopher5_Click(object sender, EventArgs e)
        {
            shot_noise();

            if (Gopher5_Targetable == true)
            {
                fn_shot5();
            }
        }



// --- CLICK BACKGROUND ---
        async void showimage()
        {
            pictureBox1.Visible = true;


            SoundPlayer p = new SoundPlayer();
            p.SoundLocation = @"C:\Users\jwireman\Desktop\Gopher Aim Trainer 2 - backup\Gopher Aim Trainer 2\bin\Debug\fuzzyjumpscare.wav";
            p.Play();

            await Task.Delay(1200);

            pictureBox1.Visible = false;
        }
        private void the_game_MouseClick(object sender, MouseEventArgs e)
        {
            fn_missShot();

            
            //sets gameover menu into view once at 10 missed shots
            if (MissCount >= 3)
            {
                showimage();
                gameover_label.Location = new Point(444, 302);
                playagain_label.Location = new Point(478, 379);
                yes_playagain.Location = new Point(658, 372);
                dash.Location = new Point(703, 379);
                no_dontplayagain.Location = new Point(728, 372);
                //Gopher.Location = new Point(2400, 2400);
            }
        }

        

// --- GAME OVER BUTTONS ---
        private void yes_playagain_Click(object sender, EventArgs e)
        {
            int x, y;

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
            
            //x = r.Next(-10, 1140);
            //y = r.Next(445, 560);
            //Gopher.Location = new Point(x, y);
            //changesize();
        }

        private void no_dontplayagain_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
