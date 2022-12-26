using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adsoyadsınıf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class cv
        {
            string ad, soyAd, işler, yeni, lise, üniversite, yaş, mail;
            public string Ad
            {
                get { return ad; }
                set { ad = value; }
            }
            public string SoyAd
            {
                get { return soyAd; }
                set { soyAd = value; }
            }
            public string Ders
            {
                get { return işler; }
                set { işler = value; }

            }
            public string Lise
            {
                get { return lise; }
                set { lise = value; }
            }
            public string Universite
            {
                get { return üniversite; }
                set { üniversite = value; }
            }
            public string Yaş
            {
                get { return yaş; }
                set { yaş = value; }
            }
            public string Mail
            {
                get { return mail; }
                set { mail = value; }
            }
            public string Yeni
            {
                get { return yeni; }
                set { yeni = value; }

            }
            public void duzenle()
            {
                yeni = "Kişi Adı : " + ad + " Soyadı : " + SoyAd + " İşlerin :  " + işler + " Lise : " + lise + " Universite : " + Universite + " Yaşınızı Girinzi : " + yaş + " Mail : " + mail;
            } 
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            cv Serhat = new cv();
            Serhat.Ad = textBox1.Text;
            Serhat.SoyAd = textBox2.Text;
            Serhat.Ders = textBox3.Text;
            Serhat.Lise = textBox4.Text;
            Serhat.Universite = textBox5.Text;
            Serhat.Yaş = textBox7.Text;
            Serhat.Mail = textBox8.Text;
            Serhat.duzenle();
            listBox1.Items.Add(Serhat.Yeni);
            string no = Convert.ToString(textBox6.Text);
            if (no.Length == 11)
            {
                listBox1.Items.Add ("Telefon Numaranız" + no);
            }
            else
            {
                MessageBox.Show("Lutfen 11 Haneli Numaranızı Giriniz","Hata ! ",MessageBoxButtons.OK,MessageBoxIcon.Information );
            }

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }
    }
}
