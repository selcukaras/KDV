using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kdvform
{
    public partial class Form1 : Form
    {
        private double[] kdvler;
        private double[] fiyatlar;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            cmb_urun.Items.Add("Klavye");
            cmb_urun.Items.Add("Mouse");
            cmb_urun.Items.Add("Monitor");
            cmb_urun.Items.Add("Hoparlör");
            cmb_urun.Items.Add("Yazıcı");
            cmb_urun.Items.Add("Tarayıcı");
            kdvler = new double[6];
            kdvler[0] = 0.1;
            kdvler[1] = 0.15;
            kdvler[2] = 0.18;
            kdvler[3] = 0.20;
            kdvler[4] = 0.15;
            kdvler[5] = 0.15;
            fiyatlar = new double[6];
            fiyatlar[0] = 25;
            fiyatlar[1] = 15;
            fiyatlar[2] = 250;
            fiyatlar[3] = 35;
            fiyatlar[4] = 375;
            fiyatlar[5] = 325;
        }
    



        private void cmb_urun_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cmbIndex = cmb_urun.SelectedIndex;
            double kdv = kdvler[cmbIndex];
            double fiyat = fiyatlar[cmbIndex];
            double satis = fiyat + fiyat * kdv;
            string str = String.Format("Satış Fiyatı: {0:0.00}", satis);
            lblFiyat.Text = str;
            if (kdv == 0.1)
            {
                radioButton1.Select();
            }
            else if (kdv == 0.15)
            {
                radioButton2.Select();
            }
            else if (kdv == 0.18)
            {
                radioButton3.Select();
            }
            else if (kdv == 0.20)
            {
                radioButton4.Select();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioSelect();
        }

        private void radioSelect()
        {
            int cmbIndex = cmb_urun.SelectedIndex;
            double kdv = kdvler[cmbIndex];
            if (kdv == 0.1)
            {
                radioButton1.Select();
            }
            else if (kdv == 0.15)
            {
                radioButton2.Select();
            }
            else if (kdv == 0.18)
            {
                radioButton3.Select();
            }
            else if (kdv == 0.20)
            {
                radioButton4.Select();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioSelect();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            radioSelect();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            radioSelect();
        }
    }
}
        
