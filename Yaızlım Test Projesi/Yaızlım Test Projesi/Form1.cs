using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yaızlım_Test_Projesi.Entity;
namespace Yaızlım_Test_Projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                string E_posta = KuallniciAdiTextBox.Text;
                string Sifre = SifreTextBox.Text;
                var Geçerlimi = kullanicidogrula(E_posta, Sifre);

                if (Geçerlimi)
                {
                    MessageBox.Show("Giriş Başarılı");
                    this.Hide();
                    SoruEkranıForm SoruFormu = new SoruEkranıForm();
                    SoruFormu.Show();

                }

                else
                    MessageBox.Show("Tekrar deneyin.");
            }
            else if (radioButton2.Checked)
            {
                string E_posta = KuallniciAdiTextBox.Text;
                string Sifre = SifreTextBox.Text;
                var Geçerlimi = OgretmenDogrula(E_posta, Sifre);

                if (Geçerlimi)
                {
                    MessageBox.Show("Giriş Başarılı");
                    this.Hide();
                    
                    SoruEklemeEkranı SoruEkleme = new SoruEklemeEkranı();

                    SoruEkleme.Show();

                }

                else
                    MessageBox.Show("Tekrar deneyin.");

            }
            else
                MessageBox.Show("Kullanici türünü girin");

        }
        
        private bool kullanicidogrula(string kAdi, string kParola)
        {
           
            
            
                SinavDB DB = new SinavDB();
                var sorgu = from p in DB.TBLOGRENCİ
                            where p.e_posta == kAdi
                             && p.sifre == kParola
                            select p;
                if (sorgu.Any())
                {
                  return true;
                }

                else
                {
                    return false;
                }
               
            
            
        }

        private bool OgretmenDogrula(string kAdi,string kParola)
        {

            SinavDB DB = new SinavDB();
            var sorgu = from p in DB.TBLOGRETMEN
                        where p.e_posta == kAdi
                         && p.sifre == kParola
                        select p;
            if (sorgu.Any())
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
