using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace MyFirstFormAppProject
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        
        Random rnd = new Random();
        int tickCount = 0;
        int randomTime = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
           
            if (tickCount == 0)
            {
                randomTime = rnd.Next(25);
            }

            if (tickCount == randomTime)
            {
                hole.Visible = true;
                bonus.Visible = true;
                int holeX = rnd.Next(this.Size.Width - hole.Width - finish.Width);
                int holeY = rnd.Next(this.Size.Height - hole.Height);
                hole.Location = new Point(holeX, holeY);

                int bonusX = rnd.Next(this.Size.Width - bonus.Width - finish.Width);
                int bonusY = rnd.Next(this.Size.Height - bonus.Height);
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

        void Go(PictureBox pb)
        {
            int value = rnd.Next(25);
            pb.Location = new Point(pb.Location.X + value, pb.Location.Y);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
        }

        private void suhrab_LocationChanged(object sender, EventArgs e)
        {
            //int holeX = hole.Location.X;
            //int holeY = hole.Location.Y;


            //int holeX2 = holeX + hole.Size.Width;
            //int holeY2 = holeY + hole.Size.Height;
            

        }

        void HitControl(PictureBox pb,PictureBox control,Point point)
        {
            int distanceX = pb.Location.X - control.Location.X;
            int distanceY = pb.Location.Y - control.Location.Y;

            if (Math.Abs(distanceX) < pb.Size.Width && Math.Abs(distanceY) < pb.Size.Height)
            {
                pb.Location = point; 
            }
        }

        void HitControlForBonus(PictureBox pb)
        {
            HitControl(pb, bonus, new Point(pb.Location.X + 100, pb.Location.Y));
        }
        void HitControlForHole(PictureBox pb)
        {
            HitControl(pb, hole, new Point(12, pb.Location.Y));
        }

        private void dila_LocationChanged(object sender, EventArgs e)
        {
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            HitControlForBonus(suhrab);
            HitControlForHole(suhrab);
            HitControlForHole(dila);
            HitControlForBonus(dila);
            HitControlForHole(lokman);
            HitControlForBonus(lokman);
            HitControlForHole(mustafa);
            HitControlForBonus(mustafa);
            HitControlForHole(mert);
            HitControlForBonus(mert);
            HitControlForHole(alpay);
            HitControlForBonus(alpay);
            HitControlForHole(senan);
            HitControlForBonus(senan);
        }
    }
}
