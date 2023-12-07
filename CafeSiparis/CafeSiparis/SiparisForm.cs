using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeSiparis
{
    public partial class SiparisForm : Form
    {
        int caySayi=0;
        int kahveSayi=0;
        int suSayi=0;

        public SiparisForm()
        {
            InitializeComponent();
        }


        private void cayEksiLabel_Click(object sender, EventArgs e)
        {
            
            caySayi--;
            if (caySayi < 0)
            {
                caySayi = 0;
            }
            caySayisiLabel.Text = Convert.ToString(caySayi);
            
        }


        private void cayArtıLabel_Click(object sender, EventArgs e)
        {
            
            caySayi++;
            caySayisiLabel.Text= Convert.ToString(caySayi); 
        }

        private void kahveArtıButon_Click(object sender, EventArgs e)
        {
            
            kahveSayi++;
            kahveSayisiLabel.Text = Convert.ToString(kahveSayi);
        }

        private void kahveEksiButon_Click(object sender, EventArgs e)
        {
            
            kahveSayi--;
            if (kahveSayi < 0)
            {
                kahveSayi = 0;
            }
            kahveSayisiLabel.Text = Convert.ToString(kahveSayi);
        }

        private void suArtıButon_Click(object sender, EventArgs e)
        {
            
            suSayi++;
            suSayiLabel.Text = Convert.ToString(suSayi);
        }

        private void suEksiButon_Click(object sender, EventArgs e)
        {
            
            suSayi--;
            if (suSayi < 0)
            {
                suSayi = 0;
            }
            suSayiLabel.Text = Convert.ToString(suSayi);
        }

        private void sıfırlaButon_Click(object sender, EventArgs e)
        {
            caySayi = 0;
            kahveSayi = 0;
            suSayi = 0;
            caySayisiLabel.Text = "0";
            kahveSayisiLabel.Text = "0";
            suSayiLabel.Text = "0";

        }

        private void siparisiTamamlaButon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sipariş Özeti:\n " + caySayisiLabel.Text + " Çay\n" + kahveSayisiLabel.Text + " Kahve\n" + suSayiLabel.Text + " Su\n");
        }


        private void cikisbutton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    }

