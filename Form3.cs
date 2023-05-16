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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        enum Durum { SeciliDegil, Secili } // bool
        Durum GoodButtonDurum = Durum.SeciliDegil;
        Durum CheapButtonDurum = Durum.SeciliDegil;
        Durum FastButtonDurum = Durum.SeciliDegil;

        private void Good_Click(object sender, EventArgs e)
        {
            if (GoodButtonDurum == Durum.SeciliDegil)//seciliyse
            {
                GoodButtonDurum = Durum.Secili;
                if (CheapButtonDurum == Durum.Secili)
                {
                    FastButtonDurum = Durum.SeciliDegil;
                    RenkDegistir(Fast, FastButtonDurum);
                }
            }
            else if (GoodButtonDurum == Durum.Secili)//secilideğilse
            {
                GoodButtonDurum = Durum.SeciliDegil;
            }

            RenkDegistir(Good, GoodButtonDurum);
        }

        private void Cheap_Click(object sender, EventArgs e)
        {
            if (CheapButtonDurum == Durum.SeciliDegil)//seciliyse
            {
                CheapButtonDurum = Durum.Secili;
                if (FastButtonDurum == Durum.Secili)
                {
                    GoodButtonDurum = Durum.SeciliDegil;
                    RenkDegistir(Good, GoodButtonDurum);
                }
            }
            else if (CheapButtonDurum == Durum.Secili)//secilideğilse
            {
                CheapButtonDurum = Durum.SeciliDegil;
            }

            RenkDegistir(Cheap, CheapButtonDurum);
        }

        private void Fast_Click(object sender, EventArgs e)
        {
            if (FastButtonDurum == Durum.SeciliDegil)//seciliyse
            {
                FastButtonDurum = Durum.Secili;
                if (GoodButtonDurum == Durum.Secili)
                {
                    CheapButtonDurum = Durum.SeciliDegil;
                    RenkDegistir(Cheap, CheapButtonDurum);
                }
            }
            else if (FastButtonDurum == Durum.Secili)//secilideğilse
            {
                FastButtonDurum = Durum.SeciliDegil;
            }

            RenkDegistir(Fast, FastButtonDurum);
        }


        void RenkDegistir(Button button,Durum buttonDurum)
        {
            button.BackColor = (buttonDurum == Durum.Secili) ? Color.YellowGreen : Color.Brown;
        }

        

    }
}
