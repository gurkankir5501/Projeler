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
    public partial class hastaneYonetici : Form
    {
        public hastaneYonetici()
        {
            InitializeComponent();
        }

        private void hastaneYonetici_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void hasta_Click(object sender, EventArgs e)
        {
            hastalar hasta = new hastalar();
            hasta.Show();
        }

        private void hastane_Click(object sender, EventArgs e)
        {
            hastaneler hastaneler = new hastaneler();
            hastaneler.Show();
        }

        private void yonetici_Click(object sender, EventArgs e)
        {
            yoneticiler2 yoneticiler2 = new yoneticiler2();
            yoneticiler2.Show();
        }

        private void ilan_Click(object sender, EventArgs e)
        {
            hastaneİlanlar hastaneİlanlar = new hastaneİlanlar();
            hastaneİlanlar.Show();
        }
    }
}
