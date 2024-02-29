namespace Gopher_Aim_Trainer_2
{
    partial class the_game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Gopher = new System.Windows.Forms.PictureBox();
            this.hit_label = new System.Windows.Forms.Label();
            this.miss_label = new System.Windows.Forms.Label();
            this.totalShots_label = new System.Windows.Forms.Label();
            this.hit_count = new System.Windows.Forms.Label();
            this.miss_count = new System.Windows.Forms.Label();
            this.shot_counter = new System.Windows.Forms.Label();
            this.restart_game = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.playagain_label = new System.Windows.Forms.Label();
            this.gameover_label = new System.Windows.Forms.Label();
            this.yes_playagain = new System.Windows.Forms.Button();
            this.no_dontplayagain = new System.Windows.Forms.Button();
            this.dash = new System.Windows.Forms.Label();
            this.accuracy_label = new System.Windows.Forms.Label();
            this.accuracy = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Gopher)).BeginInit();
            this.SuspendLayout();
            // 
            // Gopher
            // 
            this.Gopher.BackColor = System.Drawing.Color.Transparent;
            this.Gopher.Image = global::Gopher_Aim_Trainer_2.Properties.Resources.Goferidle;
            this.Gopher.Location = new System.Drawing.Point(94, 473);
            this.Gopher.Name = "Gopher";
            this.Gopher.Size = new System.Drawing.Size(142, 132);
            this.Gopher.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Gopher.TabIndex = 0;
            this.Gopher.TabStop = false;
            this.Gopher.Click += new System.EventHandler(this.Gopher_Click);
            // 
            // hit_label
            // 
            this.hit_label.AutoSize = true;
            this.hit_label.BackColor = System.Drawing.Color.Transparent;
            this.hit_label.Font = new System.Drawing.Font("Franklin Gothic Medium", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hit_label.Location = new System.Drawing.Point(12, 83);
            this.hit_label.Name = "hit_label";
            this.hit_label.Size = new System.Drawing.Size(74, 37);
            this.hit_label.TabIndex = 1;
            this.hit_label.Text = "HIT:";
            // 
            // miss_label
            // 
            this.miss_label.AutoSize = true;
            this.miss_label.BackColor = System.Drawing.Color.Transparent;
            this.miss_label.Font = new System.Drawing.Font("Franklin Gothic Medium", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miss_label.Location = new System.Drawing.Point(12, 120);
            this.miss_label.Name = "miss_label";
            this.miss_label.Size = new System.Drawing.Size(101, 37);
            this.miss_label.TabIndex = 2;
            this.miss_label.Text = "MISS:";
            // 
            // totalShots_label
            // 
            this.totalShots_label.AutoSize = true;
            this.totalShots_label.BackColor = System.Drawing.Color.Transparent;
            this.totalShots_label.Font = new System.Drawing.Font("Franklin Gothic Medium", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalShots_label.Location = new System.Drawing.Point(12, 9);
            this.totalShots_label.Name = "totalShots_label";
            this.totalShots_label.Size = new System.Drawing.Size(224, 37);
            this.totalShots_label.TabIndex = 3;
            this.totalShots_label.Text = "TOTAL SHOTS:";
            // 
            // hit_count
            // 
            this.hit_count.AutoSize = true;
            this.hit_count.BackColor = System.Drawing.Color.Transparent;
            this.hit_count.Font = new System.Drawing.Font("Franklin Gothic Medium", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hit_count.Location = new System.Drawing.Point(119, 83);
            this.hit_count.Name = "hit_count";
            this.hit_count.Size = new System.Drawing.Size(37, 37);
            this.hit_count.TabIndex = 4;
            this.hit_count.Text = "0";
            // 
            // miss_count
            // 
            this.miss_count.AutoSize = true;
            this.miss_count.BackColor = System.Drawing.Color.Transparent;
            this.miss_count.Font = new System.Drawing.Font("Franklin Gothic Medium", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miss_count.Location = new System.Drawing.Point(119, 120);
            this.miss_count.Name = "miss_count";
            this.miss_count.Size = new System.Drawing.Size(37, 37);
            this.miss_count.TabIndex = 5;
            this.miss_count.Text = "0";
            // 
            // shot_counter
            // 
            this.shot_counter.AutoSize = true;
            this.shot_counter.BackColor = System.Drawing.Color.Transparent;
            this.shot_counter.Font = new System.Drawing.Font("Franklin Gothic Medium", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shot_counter.Location = new System.Drawing.Point(242, 9);
            this.shot_counter.Name = "shot_counter";
            this.shot_counter.Size = new System.Drawing.Size(37, 37);
            this.shot_counter.TabIndex = 6;
            this.shot_counter.Text = "0";
            // 
            // restart_game
            // 
            this.restart_game.AutoSize = true;
            this.restart_game.BackColor = System.Drawing.Color.Transparent;
            this.restart_game.Font = new System.Drawing.Font("Franklin Gothic Medium", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restart_game.Location = new System.Drawing.Point(1062, 9);
            this.restart_game.Name = "restart_game";
            this.restart_game.Size = new System.Drawing.Size(190, 37);
            this.restart_game.TabIndex = 7;
            this.restart_game.Text = ">RESTART<";
            this.restart_game.Click += new System.EventHandler(this.restart_game_Click);
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.Font = new System.Drawing.Font("Franklin Gothic Medium", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(1132, 46);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(120, 37);
            this.exit.TabIndex = 8;
            this.exit.Text = ">EXIT<";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // playagain_label
            // 
            this.playagain_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.playagain_label.AutoSize = true;
            this.playagain_label.BackColor = System.Drawing.Color.Transparent;
            this.playagain_label.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playagain_label.ForeColor = System.Drawing.Color.Brown;
            this.playagain_label.Location = new System.Drawing.Point(2400, 2400);
            this.playagain_label.Name = "playagain_label";
            this.playagain_label.Size = new System.Drawing.Size(189, 39);
            this.playagain_label.TabIndex = 9;
            this.playagain_label.Text = "Play Again?:";
            // 
            // gameover_label
            // 
            this.gameover_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gameover_label.AutoSize = true;
            this.gameover_label.BackColor = System.Drawing.Color.Transparent;
            this.gameover_label.Font = new System.Drawing.Font("Bahnschrift", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameover_label.ForeColor = System.Drawing.Color.Brown;
            this.gameover_label.Location = new System.Drawing.Point(2400, 2400);
            this.gameover_label.Name = "gameover_label";
            this.gameover_label.Size = new System.Drawing.Size(377, 77);
            this.gameover_label.TabIndex = 10;
            this.gameover_label.Text = "GAME OVER";
            // 
            // yes_playagain
            // 
            this.yes_playagain.BackColor = System.Drawing.Color.Transparent;
            this.yes_playagain.FlatAppearance.BorderSize = 0;
            this.yes_playagain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yes_playagain.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Bold);
            this.yes_playagain.ForeColor = System.Drawing.Color.Brown;
            this.yes_playagain.Location = new System.Drawing.Point(2400, 2400);
            this.yes_playagain.Name = "yes_playagain";
            this.yes_playagain.Size = new System.Drawing.Size(49, 52);
            this.yes_playagain.TabIndex = 11;
            this.yes_playagain.Text = "Y";
            this.yes_playagain.UseVisualStyleBackColor = false;
            this.yes_playagain.Click += new System.EventHandler(this.yes_playagain_Click);
            // 
            // no_dontplayagain
            // 
            this.no_dontplayagain.BackColor = System.Drawing.Color.Transparent;
            this.no_dontplayagain.FlatAppearance.BorderSize = 0;
            this.no_dontplayagain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.no_dontplayagain.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Bold);
            this.no_dontplayagain.ForeColor = System.Drawing.Color.Brown;
            this.no_dontplayagain.Location = new System.Drawing.Point(2400, 2400);
            this.no_dontplayagain.Name = "no_dontplayagain";
            this.no_dontplayagain.Size = new System.Drawing.Size(49, 52);
            this.no_dontplayagain.TabIndex = 12;
            this.no_dontplayagain.Text = "N";
            this.no_dontplayagain.UseVisualStyleBackColor = false;
            this.no_dontplayagain.Click += new System.EventHandler(this.no_dontplayagain_Click);
            // 
            // dash
            // 
            this.dash.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dash.AutoSize = true;
            this.dash.BackColor = System.Drawing.Color.Transparent;
            this.dash.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dash.ForeColor = System.Drawing.Color.Brown;
            this.dash.Location = new System.Drawing.Point(2400, 2400);
            this.dash.Name = "dash";
            this.dash.Size = new System.Drawing.Size(29, 39);
            this.dash.TabIndex = 13;
            this.dash.Text = "\\";
            // 
            // accuracy_label
            // 
            this.accuracy_label.AutoSize = true;
            this.accuracy_label.BackColor = System.Drawing.Color.Transparent;
            this.accuracy_label.Font = new System.Drawing.Font("Franklin Gothic Medium", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accuracy_label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.accuracy_label.Location = new System.Drawing.Point(12, 46);
            this.accuracy_label.Name = "accuracy_label";
            this.accuracy_label.Size = new System.Drawing.Size(186, 37);
            this.accuracy_label.TabIndex = 14;
            this.accuracy_label.Text = "ACCURACY:";
            // 
            // accuracy
            // 
            this.accuracy.AutoSize = true;
            this.accuracy.BackColor = System.Drawing.Color.Transparent;
            this.accuracy.Font = new System.Drawing.Font("Franklin Gothic Medium", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accuracy.Location = new System.Drawing.Point(204, 46);
            this.accuracy.Name = "accuracy";
            this.accuracy.Size = new System.Drawing.Size(63, 37);
            this.accuracy.TabIndex = 15;
            this.accuracy.Text = "0%";
            // 
            // the_game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gopher_Aim_Trainer_2.Properties.Resources.pixel_art_pixels_digital_art_horizon_wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.accuracy);
            this.Controls.Add(this.accuracy_label);
            this.Controls.Add(this.dash);
            this.Controls.Add(this.no_dontplayagain);
            this.Controls.Add(this.gameover_label);
            this.Controls.Add(this.playagain_label);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.restart_game);
            this.Controls.Add(this.shot_counter);
            this.Controls.Add(this.miss_count);
            this.Controls.Add(this.hit_count);
            this.Controls.Add(this.totalShots_label);
            this.Controls.Add(this.miss_label);
            this.Controls.Add(this.hit_label);
            this.Controls.Add(this.Gopher);
            this.Controls.Add(this.yes_playagain);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "the_game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "the_game";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.the_game_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.Gopher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Gopher;
        private System.Windows.Forms.Label hit_label;
        private System.Windows.Forms.Label miss_label;
        private System.Windows.Forms.Label totalShots_label;
        private System.Windows.Forms.Label hit_count;
        private System.Windows.Forms.Label miss_count;
        private System.Windows.Forms.Label shot_counter;
        private System.Windows.Forms.Label restart_game;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label playagain_label;
        private System.Windows.Forms.Label gameover_label;
        private System.Windows.Forms.Button yes_playagain;
        private System.Windows.Forms.Button no_dontplayagain;
        private System.Windows.Forms.Label dash;
        private System.Windows.Forms.Label accuracy_label;
        private System.Windows.Forms.Label accuracy;
    }
}