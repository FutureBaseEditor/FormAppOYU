using System;
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
    public partial class Form5 : Form
    {
        int min = 0, max = 0, letterCount = 0;
        public Form5()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {            
            string letters = textBox1.Text;

            if (letters[(letters.Length)-1] != ' ')
            {
                letterCount++;
            }

            textBox2.Text = letterCount.ToString();

            string[] words = letters.Split(' ');
            textBox3.Text = (words.Length).ToString();
                        
            for (int i = 0; i < words.Length; i++)
            {
                if (i == 0) 
                {
                    min = words[i].Length;
                }

                if (words[i].Length > max)
                {
                    max = words[i].Length;
                    textBox5.Text = words[i];
                }

                if(words[i].Length <= min)
                { 
                    min = words[i].Length;
                    textBox4.Text = words[i];
                }
            }
     
        }
    }
}
