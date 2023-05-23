

using MyFirstFormAppProject.Properties;
using System;

namespace MyFirstFormAppProject
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            players = new PictureBox[] { senan , lokman, suhrab, dila, mustafa, mert, alpay };
            Shuffle(players);

            int spaceValue = 6;
            int width = 100;
            int height = width;
            int startPositionX = 12;
            int startPositionY = startPositionX;

            lastPlayer = players[0];
            firstPlayer = players[0];

            for (int i = 0; i < players.Length; i++)
            {
                players[i].Size = new Size(width,height);
                players[i].Location = new Point(startPositionX, startPositionY + (height + spaceValue) * i );
            }
           
        }


       
        Random rnd = new Random();
        PictureBox[] players;
        PictureBox lastPlayer,firstPlayer;
        int tickCount = 0, randomTime = 0;

        private void start_Click(object sender, EventArgs e)
        {
            playerTimer.Start();
            hitControlTimer.Start();
        }
        private void playerTimer_Tick(object sender, EventArgs e)
        {
            if (tickCount == 0)
            {
                randomTime = rnd.Next(15);
            }

            if (tickCount == randomTime)
            {
                hole.Visible = true;
                bonus.Visible = true;
                int holeX = rnd.Next(firstPlayer.Location.X, this.Size.Width - hole.Width - finish.Width);
                int holeY = rnd.Next(players.Last().Location.Y );
                hole.Location = new Point(holeX, holeY);
                
                int bonusX = rnd.Next(lastPlayer.Location.X, this.Size.Width - bonus.Width - finish.Width);
                int bonusY = rnd.Next(players.Last().Location.Y);
                bonus.Location = new Point(bonusX, bonusY);

                tickCount = 0;
            }

            tickCount++;

            Go(suhrab);
            Go(dila);
            Go(lokman);
            Go(mustafa);
            Go(mert);
            Go(alpay);
            Go(senan);
        }
        private void hitControlTimer_Tick(object sender, EventArgs e)
        {
            OnHit(suhrab);
            OnHit(dila);
            OnHit(lokman);
            OnHit(mustafa);
            OnHit(mert);
            OnHit(alpay);
            OnHit(senan);
            LastPlayerControl();
            FirstPlayerControl();
        }
        void Go(PictureBox pb)
        {
            int value = rnd.Next(25);
            pb.Location = new Point(pb.Location.X + value, pb.Location.Y);
        }
        void OnHit(PictureBox player)
        {
            HitControl(player, bonus, new Point(player.Location.X + 100, player.Location.Y));
            HitControl(player, hole, new Point(12, player.Location.Y));
            FotoFinish(player);
        }
        void HitControl(PictureBox player,PictureBox hitObject,Point newPoint)
        {
            int distanceX = player.Location.X - hitObject.Location.X;
            int distanceY = player.Location.Y - hitObject.Location.Y;

            if (Math.Abs(distanceX) < player.Size.Width && Math.Abs(distanceY) < player.Size.Height)
            {
                player.Location = newPoint; 
            }
        }
        void FotoFinish(PictureBox player)
        {
            if (finishFlag.Location.X - ( player.Location.X + player.Size.Width) < 0)
            {
                playerTimer.Stop();
                hitControlTimer.Stop();
                MessageBox.Show("Kazanan " + player.Name.ToUpper() );
            }
        }
        void LastPlayerControl()
        {
            for (int i = 0; i < players.Length; i++)
            {
                if (players[i].Location.X < lastPlayer.Location.X  )
                {
                    lastPlayer = players[i];
                }
            }

            this.Text = lastPlayer.Name;
        }
        void FirstPlayerControl()
        {
            for (int i = 0; i < players.Length; i++)
            {
                if (players[i].Location.X > firstPlayer.Location.X)
                {
                    firstPlayer = players[i];
                }
            }

            this.Text = firstPlayer.Name;
        }
        void Shuffle(PictureBox[] array)
        {

            int n = array.Length;
            for (int i = 0; i < n; i++)
            {

                int r = i + (int)(rnd.NextDouble() * (n - i));
                PictureBox t = array[r];
                array[r] = array[i];
                array[i] = t;
            }
        }







    }
}
