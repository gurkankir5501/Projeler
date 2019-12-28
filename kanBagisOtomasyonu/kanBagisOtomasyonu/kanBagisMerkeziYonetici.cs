using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kanBagisOtomasyonu
{
    public partial class kanBagisMerkeziYonetici : Form
    {
        public kanBagisMerkeziYonetici()
        {
            InitializeComponent();
        }

     

        private void kanBagisMerkeziYonetici_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bagiscilarsayfasi bagiscilar = new Bagiscilarsayfasi();
            bagiscilar.Show();
        }

        private void bagislar_Click(object sender, EventArgs e)
        {
            Bagislar bagislar =new Bagislar();
            bagislar.Show();

        }

        private void kanBagisMerkezleri_Click(object sender, EventArgs e)
        {
            BagisMerkezleri bagis = new BagisMerkezleri();
            bagis.Show();
        }

        private void yonetici_Click(object sender, EventArgs e)
        {
            Yoneticiler yoneticiler = new Yoneticiler();
            yoneticiler.Show();
        }

        private void ilan_Click(object sender, EventArgs e)
        {
            İlanlar ilanlar = new İlanlar();
            ilanlar.Show();
        }

        private void tedarik_Click(object sender, EventArgs e)
        {
            Tedarik tedarik = new Tedarik();
            tedarik.Show();
        }

        private void giris_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
