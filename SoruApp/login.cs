using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoruApp
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
     

            database_islem login = new database_islem();

            string deneme = login.login_islem(txt_kullanıcı.ToString(), txt_sifre.ToString()) ;

            MessageBox.Show(deneme);
             
            
        }


    }
}
