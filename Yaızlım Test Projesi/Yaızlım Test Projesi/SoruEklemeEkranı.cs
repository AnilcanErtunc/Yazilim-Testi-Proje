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
    public partial class SoruEklemeEkranı : Form
    {
        public SoruEklemeEkranı()
        {
            InitializeComponent();
        }
        SinavDB Context = new SinavDB();
        public void ComboBoxaKonuCek()
        {
            var Konular = (from i in Context.TBLKONUs

                           select i.KonuID
                               ).ToArray();
            for(int i = 0; i < 10; i++)
            {
                comboBox1.Items.Add(Konular[i]);
            }
        }


        private void buttonEkle_Click(object sender, EventArgs e)
        {
            TBLSORU Yeni = new TBLSORU();

            Yeni.Soru = richTextBoxSORU.Text;
            Yeni.A = textBoxASIKKI.Text;
            Yeni.B = textBoxBSIKKI.Text;
            Yeni.C = textBoxCSIKKI.Text;
            Yeni.D = textBoxDSIKKI.Text;
            Yeni.KonuID =  comboBox1.SelectedIndex;
            Yeni.DogruCevap = textBoxBSIKKI.Text;
            Context.TBLSORUs.Add(Yeni);
            Context.SaveChanges();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void SoruEklemeEkranı_Load(object sender, EventArgs e)
        {
            ComboBoxaKonuCek();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
