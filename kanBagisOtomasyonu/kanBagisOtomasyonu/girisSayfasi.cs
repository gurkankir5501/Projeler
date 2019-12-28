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
    public partial class girisSayfasi : Form
    {
        public girisSayfasi()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void kullaniciAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void parola_TextChanged(object sender, EventArgs e)
        {

        }

        string gorevKodu;
        private void girisButonu_Click(object sender, EventArgs e)
        {
            DAO dao = new DAO();
            Yonetici yonetici = new Yonetici();

            

            if (bagisMerkeziYonetici.Checked)
            {
                gorevKodu = "111111";
            }
            if (hastaneYonetici.Checked)
            {
                gorevKodu = "222222";
            }
            yonetici.setYoneticiKodu(kullaniciAdi.Text);
            yonetici.setYoneticiParola(parola.Text);
            yonetici.setGorevKodu(gorevKodu);

            try
            {
                if (DAO.girisKontrol(yonetici))
                {
                    if (gorevKodu == "111111")
                    {
                        this.Hide();
                        MessageBox.Show("sisteme başarılı giriş yaptınız");
                        kanBagisMerkeziYonetici kanBagisMerkeziYonetici = new kanBagisMerkeziYonetici();
                        kanBagisMerkeziYonetici.Show();
                    }
                    else if (gorevKodu == "222222")
                    {
                        this.Hide();
                        MessageBox.Show("sisteme başarılı giriş yaptınız");
                        hastaneYonetici hastaneYonetici = new hastaneYonetici();
                        hastaneYonetici.Show();
                    }
                }
                else
                {
                    MessageBox.Show("böyle bir kullanıcı sistemde bulunmuyor");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

      

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bagisMerkeziYonetici_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void kullaniciAdi_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
