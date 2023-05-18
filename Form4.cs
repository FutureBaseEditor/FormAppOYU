﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstFormAppProject
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Evet_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Biz de öyle düşünmüştük");
            Close();
        }

        private void Hayir_MouseEnter(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int maximumX = Size.Width - Hayir.Width;

            int maximumY = Size.Height - Hayir.Height;
            int mininumY = Evet.Location.Y + Evet.Height; 

            int x = rnd.Next(maximumX);
            int y = rnd.Next(mininumY , maximumY);

            Hayir.Location = new Point(x,y);
        }

        int count = 0;
        string[] messagess = {
            "Öyle hemen gitmek yok 🙂" ,
            "Bir daha denesene 😄",
            "Hoş geldin hoş geldin. nerede bu insanlar",
            "Sakın bir daha kapatmayı deneme",
            "Bilgisayarını formatlarım",
            "Yiyorsa KAPAT",
            "hahahahahaha ahahahahah ahaha",
        };
        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show( messagess[count] );
            count++;

            if (count >= messagess.Length)
            {
                label2.Visible = false;
            }
        }


    }
}
