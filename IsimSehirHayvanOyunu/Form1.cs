using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsimSehirHayvanOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            if (lblHarf.Text!="")
            {
                sayac = 0;
                timer1.Enabled = true;
                btnHarfVer.Enabled = false;
                btnBasla.Enabled = false;   
            }
            else
            {
                MessageBox.Show("ÖNCE HARF SEÇME BUTONUNA BASMALISINIZ");
                Form1 frm = new Form1();
                frm.Show();
                this.Hide();

            }

        }
        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sayac==59)
            {
                timer1.Stop();
                MessageBox.Show("SÜRENİZ SONA ERDİ TEKRAR DENEYİNİZ");
                Form1 frm = new Form1();
                frm.Show();
                this.Hide();
                
            }
            sayac++;
            lblZaman.Text = sayac.ToString();
            
            

            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnHarfVer_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int sayi = rnd.Next(65, 91);
            if (sayi == 87 || sayi == 88 || sayi==81) // X-W-Q HARFLERİ GELİRSE İŞLEM YAPMAYACAK
            {
            }

            else
            {
                lblHarf.Text = ((char)sayi).ToString();
            }

            
        }
        int puan = 0;
        private void btnKontrolEt_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            txtIsim.Enabled = false;
            txtSehir.Enabled = false;
            txtHayvan.Enabled = false;
            txtBitki.Enabled = false;
            txtEsya.Enabled = false;
            txtUnlu.Enabled = false;
            if (txtIsim.Text.Trim()=="")
            {
               
            }
            else if (txtIsim.Text.Trim().Substring(0, 1).ToUpper() == lblHarf.Text && txtIsim.Text.Length >= 2)
            {

                puan += 10;
            }
            if(txtSehir.Text.Trim()=="")
            {
                

            }
            else if (txtSehir.Text.Substring(0, 1).ToUpper() == lblHarf.Text && txtSehir.Text.Length >= 3)
            {
                puan += 10;
            }
            if(txtHayvan.Text.Trim()=="")
            {
                

            }
            else if (txtHayvan.Text.Trim().Substring(0, 1).ToUpper() == lblHarf.Text && txtHayvan.Text.Length >= 2)
            {
                puan += 10;
            }
           if(txtBitki.Text.Trim()=="")
            {
               

            }
            else if (txtBitki.Text.Trim().Substring(0, 1).ToUpper() == lblHarf.Text && txtBitki.Text.Length >= 3)
            {
                puan += 10;
            }
            if (txtEsya.Text.Trim()=="")
            {
               

            }
            else if((txtEsya.Text.Trim().Substring(0, 1).ToUpper() == lblHarf.Text && txtEsya.Text.Length >= 3))
            {
                puan += 10;
            }
            if(txtUnlu.Text.Trim()=="")
            {
                

            }
            else if (txtUnlu.Text.Trim().Substring(0, 1).ToUpper() == lblHarf.Text && txtUnlu.Text.Length >= 5)
            {
                puan += 10;
            }
            MessageBox.Show(puan.ToString());
        }
    }
}
