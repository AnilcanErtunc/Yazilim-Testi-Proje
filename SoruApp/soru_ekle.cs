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
    public partial class soru_ekle : Form
    {
        public soru_ekle()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSoruEkle_Click(object sender, EventArgs e)// BUTOOOOOON
        {

                database_islem data = new database_islem();
             
                data.soru_eklemek(textBoxSoru.Text,textBoxA.Text,textBoxB.Text,textBoxC.Text,textBoxDogru.Text);
         
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxKonu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSoru_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
