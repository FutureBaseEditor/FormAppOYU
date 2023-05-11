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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        string PlaceHolder = "Birim Seçiniz";
        string C = "Santigrat";
        string K = "Kelvin";
        string F = "Fahrenayt";

        private void Form2_Load(object sender, EventArgs e)
        {
            MevcutCombo.Items.Add(PlaceHolder);
            MevcutCombo.Items.Add(C);
            MevcutCombo.Items.Add(K);
            MevcutCombo.Items.Add(F);

            DonusturulecekCombo.Items.Add(PlaceHolder);
            DonusturulecekCombo.Items.Add(C);
            DonusturulecekCombo.Items.Add(K);
            DonusturulecekCombo.Items.Add(F);

            MevcutCombo.SelectedItem = PlaceHolder;
            DonusturulecekCombo.SelectedItem = PlaceHolder;
        }
        private void Deger_TextChanged(object sender, EventArgs e)
        {
            SonucGoster();
        }

        private void MevcutCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MevcutCombo.SelectedItem == DonusturulecekCombo.SelectedItem)
            {
                DonusturulecekCombo.SelectedItem = PlaceHolder;
            }

            SonucGoster();
        }

        private void DonusturulecekCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MevcutCombo.SelectedItem == DonusturulecekCombo.SelectedItem)
            {
                MevcutCombo.SelectedItem = PlaceHolder;
            }

            SonucGoster();
        }

        private void Sonuc_TextChanged(object sender, EventArgs e)
        {
            SonucGoster();
        }
        double CtoK(double value)
        {
            return value + 273.15;
        }
        double KtoC(double value)
        {
            return value - 273.15;
        }
        double CtoF(double value)
        {
            return (value * 1.8) + 32;
        }
        double FtoC(double value)
        {
            return (value - 32) / 1.8;
        }
        double KtoF(double value)
        {
            return value * 9 / 5 - 459.67;
        }
        double FtoK(double value)
        {
            return (value + 459.67) * 5 / 9;
        }

        void SonucGoster()
        {
            if (Deger.Text.Trim() == "") Deger.Text = "0";

            double deger = double.Parse(Deger.Text);
            double sonuc = 0;
            

            if (MevcutCombo.SelectedItem == C && DonusturulecekCombo.SelectedItem == K)
            {
                sonuc = CtoK(deger);
            }
            else if (MevcutCombo.SelectedItem == K && DonusturulecekCombo.SelectedItem == C)
            {
                sonuc = KtoC(deger);
            }
            else if (MevcutCombo.SelectedItem == C && DonusturulecekCombo.SelectedItem == F)
            {
                sonuc = CtoF(deger);
            }
            else if (MevcutCombo.SelectedItem == F && DonusturulecekCombo.SelectedItem == C)
            {
                sonuc = FtoC(deger);
            }
            else if (MevcutCombo.SelectedItem == K && DonusturulecekCombo.SelectedItem == F)
            {
                sonuc = KtoF(deger);
            }
            else if (MevcutCombo.SelectedItem == F && DonusturulecekCombo.SelectedItem == K)
            {
                sonuc = FtoK(deger);
            }
            Sonuc.Text = sonuc.ToString();
        }

       
    }
}
