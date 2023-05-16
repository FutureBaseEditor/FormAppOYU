using System.Security.Cryptography;

namespace GoodFastCheap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.ForeColor == Color.Black && button2.ForeColor == Color.Black && button3.ForeColor == Color.DarkGray)
            {
                button1.ForeColor = Color.DarkGray;
                button1.BackColor = Color.LightGray;
                button3.ForeColor = Color.Black;
                button3.BackColor = Color.DarkGray;
            }
            else if (button1.ForeColor == Color.DarkGray && button2.ForeColor == Color.Black && button3.ForeColor == Color.Black)
            {
                button1.ForeColor = Color.Black;
                button1.BackColor = Color.DarkGray;

                Random rnd = new Random();
                int random = rnd.Next(2);

                if (random == 0)
                {
                    button2.ForeColor = Color.DarkGray;
                    button2.BackColor = Color.LightGray;
                }
                else
                {
                    button3.ForeColor = Color.DarkGray;
                    button3.BackColor = Color.LightGray;
                }
            }
            else if (button1.ForeColor == Color.Black && button2.ForeColor == Color.DarkGray && button3.ForeColor == Color.Black)
            {
                button1.ForeColor = Color.DarkGray;
                button1.BackColor = Color.LightGray;
                button2.ForeColor = Color.Black;
                button2.BackColor = Color.DarkGray;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.ForeColor == Color.Black && button1.ForeColor == Color.Black && button3.ForeColor == Color.DarkGray)
            {
                button2.ForeColor = Color.DarkGray;
                button2.BackColor = Color.LightGray;
                button3.ForeColor = Color.Black;
                button3.BackColor = Color.DarkGray;
            }
            else if (button2.ForeColor == Color.DarkGray && button1.ForeColor == Color.Black && button3.ForeColor == Color.Black)
            {
                button2.ForeColor = Color.Black;
                button2.BackColor = Color.DarkGray;

                Random rnd = new Random();
                int random = rnd.Next(2);

                if (random == 0)
                {
                    button1.ForeColor = Color.DarkGray;
                    button1.BackColor = Color.LightGray;
                }
                else
                {
                    button3.ForeColor = Color.DarkGray;
                    button3.BackColor = Color.LightGray;
                }
            }
            else if (button2.ForeColor == Color.Black && button1.ForeColor == Color.DarkGray && button3.ForeColor == Color.Black)
            {
                button2.ForeColor = Color.DarkGray;
                button2.BackColor = Color.LightGray;
                button1.ForeColor = Color.Black;
                button1.BackColor = Color.DarkGray;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.ForeColor == Color.Black && button2.ForeColor == Color.Black && button1.ForeColor == Color.DarkGray)
            {
                button3.ForeColor = Color.DarkGray;
                button3.BackColor = Color.LightGray;
                button1.ForeColor = Color.Black;
                button1.BackColor = Color.DarkGray;
            }
            else if (button3.ForeColor == Color.DarkGray && button2.ForeColor == Color.Black && button1.ForeColor == Color.Black)
            {
                button3.ForeColor = Color.Black;
                button3.BackColor = Color.DarkGray;

                Random rnd = new Random();
                int random = rnd.Next(2);

                if (random == 0)
                {
                    button2.ForeColor = Color.DarkGray;
                    button2.BackColor = Color.LightGray;
                }
                else
                {
                    button1.ForeColor = Color.DarkGray;
                    button1.BackColor = Color.LightGray;
                }
            }
            else if (button3.ForeColor == Color.Black && button2.ForeColor == Color.DarkGray && button1.ForeColor == Color.Black)
            {
                button3.ForeColor = Color.DarkGray;
                button3.BackColor = Color.LightGray;
                button2.ForeColor = Color.Black;
                button2.BackColor = Color.DarkGray;
            }
        }
    }
}