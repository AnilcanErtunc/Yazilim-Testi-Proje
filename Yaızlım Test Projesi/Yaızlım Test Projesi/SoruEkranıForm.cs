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
    public partial class SoruEkranıForm : Form
    {
        public SoruEkranıForm()
        {
            InitializeComponent();
        }
        SinavDB Context = new SinavDB();
        int i = 0;
        int DogruCevaplar = 0;
        int YanlisCevaplar = 0;
        int[] Yanlislar = new int[20];
        int Encok1;
        int Encok2;
        string[] Sorular = new string[100];
        string[] Sorular1 = new string[40];
        string[] A = new string[100];
        string[] B = new string[100];
        string[] C = new string[100];
        string[] D = new string[100];
        string[] A1 = new string[40];
        string[] B1 = new string[40];
        string[] C1 = new string[40];
        string[] D1 = new string[40];
        string[] dogrular = new string[70];


        public int[] YanlislariGetir()
        {

            SinavDB Context = new SinavDB();
            var yanlis = (from i in Context.SınavGeçmişiTBL
                          orderby i.YanlisSayisi descending
                          select i.KonuID).ToArray();
            return yanlis;

        }



        public string[] DogrularıCek()
        {
            SinavDB Context = new SinavDB();
            var Dogrular = (from i in Context.TBLSORUs
                            select i.DogruCevap).ToArray();
            return Dogrular;
        }



        private void SoruEkranıForm_Load(object sender, EventArgs e)
        {
            dogrular = DogrularıCek();
            Yanlislar = YanlislariGetir();
             Encok1 = Yanlislar[0];
             Encok2 = Yanlislar[1];

             Sorular = (from i in Context.TBLSORUs
                           where i.KonuID == Encok1 || i.KonuID == Encok2
                           select i.Soru).ToArray();


             Sorular1 = (from i in Context.TBLSORUs
                            where i.KonuID != Encok1 || i.KonuID != Encok2
                            select i.Soru).ToArray();



             A = (from i in Context.TBLSORUs
                     where i.KonuID == Encok1 || i.KonuID == Encok2
                     select i.A).ToArray();
             B = (from i in Context.TBLSORUs
                     where i.KonuID == Encok1 || i.KonuID == Encok2
                     select i.B).ToArray();
             C = (from i in Context.TBLSORUs
                     where i.KonuID == Encok1 || i.KonuID == Encok2
                     select i.C).ToArray();
             D = (from i in Context.TBLSORUs
                     where i.KonuID == Encok1 || i.KonuID == Encok2
                     select i.D).ToArray();

             A1 = (from i in Context.TBLSORUs
                      where i.KonuID != Encok1 || i.KonuID != Encok2
                      select i.A).ToArray();
             B1 = (from i in Context.TBLSORUs
                      where i.KonuID != Encok1 || i.KonuID != Encok2
                      select i.B).ToArray();
             C1 = (from i in Context.TBLSORUs
                      where i.KonuID != Encok1 || i.KonuID != Encok2
                      select i.C).ToArray();
             D1 = (from i in Context.TBLSORUs
                      where i.KonuID != Encok1 || i.KonuID != Encok2
                      select i.D).ToArray();
           
            Array.Copy(A, A1,A.Length);
            Array.Copy(B, B1, B.Length);
            Array.Copy(C, C1, C.Length);
            Array.Copy(D, D1, D.Length);
            Array.Copy(Sorular, Sorular1, Sorular.Length);

            

        }



      
        private void CevapButton_Click(object sender, EventArgs e)
        {
            if (i == Sorular1.Length)
            {
                MessageBox.Show("Sınav Bitti");
                TBLSINAV YeniSinavSonucları = new TBLSINAV();
                YeniSinavSonucları.ToplamDoğru = DogruCevaplar;
                YeniSinavSonucları.ToplamYanlış = YanlisCevaplar;
                var OGRID = Context.TBLOGRENCİ.First();
                YeniSinavSonucları.OgrenciID = OGRID.OgrenciID;
                Context.TBLSINAVs.Add(YeniSinavSonucları);
                Context.SaveChanges();
                this.Close();
                Application.Exit();

            }
            SoruLabel.Text = Sorular1[i];
            radioButtonASIKKI.Text = A1[i];
            radioButtonB.Text = B1[i];
            radioButtonC.Text = C1[i];
            radioButtonD.Text = D1[i];

            KacinicSoruLABEL.Text = (i + 1).ToString();



            if (radioButtonASIKKI.Checked && dogrular[i] == radioButtonASIKKI.Text)
            {
                DogruCevaplar++;
            }
            else if (radioButtonB.Checked && dogrular[i] == radioButtonB.Text)
            {
                DogruCevaplar++;
            }
            else if (radioButtonC.Checked && dogrular[i] == radioButtonC.Text)
            {
                DogruCevaplar++;
            }
            else if (radioButtonD.Checked && dogrular[i] == radioButtonD.Text)
            {
                DogruCevaplar++;
            }

            else
            {
                YanlisCevaplar++;
                var KonuIDler = (from i in Context.TBLSORUs
                                 select i.KonuID).ToArray();
                int konuıd = KonuIDler[i];

                var GüncellenecekYanlisDegeri = (from i in Context.SınavGeçmişiTBL
                                                 where i.KonuID == konuıd
                                                 select i).Single();


                GüncellenecekYanlisDegeri.YanlisSayisi = GüncellenecekYanlisDegeri.YanlisSayisi + 1;
                Context.SaveChanges();



            }

            i++;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonBitir_Click(object sender, EventArgs e)
        {

            TBLSINAV YeniSinavSonucları = new TBLSINAV();
            YeniSinavSonucları.ToplamDoğru = DogruCevaplar;
            YeniSinavSonucları.ToplamYanlış = YanlisCevaplar;
            var OGRID = Context.TBLOGRENCİ.First();
            YeniSinavSonucları.OgrenciID = OGRID.OgrenciID;
            Context.TBLSINAVs.Add(YeniSinavSonucları);
            Context.SaveChanges();
            MessageBox.Show("Sınav bitti");
            Application.Exit();

        }
    }
}
