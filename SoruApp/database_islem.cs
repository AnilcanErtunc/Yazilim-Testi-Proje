using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoruApp.Entitiy;

namespace SoruApp
{
    class database_islem
    {
        public string login_islem(string kullaniciAd, string sifre)  // YAPILACAK
        {
            SoruDataEntities1 db = new SoruDataEntities1();

            string veri = "boş";

                foreach(var user in db.tbl_Kullanıcı)
            {
                if (user.kullanıcı_ad == kullaniciAd && user.kullanıcı_sifre == sifre)
                {
                     veri = user.kullanıcı_ıd.ToString();
                }
          
            }

            /*
              tbl_Kullanıcı gelenVeri = (from nesne in db.tbl_Kullanıcı
                                         where nesne.kullanıcı_ad == kullaniciAd  &&  nesne.kullanıcı_sifre== sifre
                                         select nesne).FirstOrDefault();
              string a;
              string s;
              int id;

              if (gelenVeri != null)
              {
                  a = gelenVeri.kullanıcı_ad;
                  s = gelenVeri.kullanıcı_sifre;
                  id = gelenVeri.kullanıcı_ıd;
              }
              else
              {
                  id = 0;
              }



           */


            return veri;
        }

        public void soru_eklemek(string textBoxSoru,string textBoxA, string textBoxB,string textBoxC, string textBoxDogru) // BU TAMAM
        {
            SoruDataEntities1 db = new SoruDataEntities1();
            tbl_Soruu yenisoru = new tbl_Soruu();
            yenisoru.soru_text = textBoxSoru;
            yenisoru.sık_1 = textBoxA;
            yenisoru.sık_2 = textBoxB;
            yenisoru.sık_3 = textBoxC;
            yenisoru.sık_dogru = textBoxDogru;
            db.tbl_Soruu.Add(yenisoru);
            db.SaveChanges();
        }

        
    }
}
