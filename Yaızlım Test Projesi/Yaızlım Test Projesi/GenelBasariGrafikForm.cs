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
    public partial class GenelBasariGrafikForm : Form
    {
        public GenelBasariGrafikForm()
        {
            InitializeComponent();
        }
        SinavDB DBContext = new SinavDB();
        private void GenelBasariGrafikForm_Load(object sender, EventArgs e)
        {
            var İstatistik = (from i in DBContext.TBLSINAVs
                          
                           select i.ToplamDoğru).ToArray();
            for(int i = 0; i < İstatistik.Length; i++)
            {
                chart1.Series["Sınavlar"].Points.AddY(İstatistik[i]);
            }
        }
    }
}
