using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kanBagisOtomasyonu
{
    public partial class yoneticiler2 : Form
    {
        public yoneticiler2()
        {
            InitializeComponent();
        }
        Yonetici yonetici = new Yonetici();

        SqlConnection baglanti = new SqlConnection("server=gk\\mssqlserver01;Database=kanBagisOtomasyon;Trusted_Connection=true");
        SqlCommand veriOku = new SqlCommand();
        public void bilgiler()
        {
            yonetici.setYoneticiKodu(yoneticiKodu.Text);
            yonetici.setYoneticiAdi(ad.Text);
            yonetici.setYoneticiSoyadi(soyad.Text);
            yonetici.setYoneticiParola(parola.Text);
            yonetici.setGorevKodu("222222");
        }
        public void guncelle(DataGridView dgv)
        {
            baglanti.Open();
            veriOku.Connection = baglanti;
            veriOku.CommandText = "select yoneticiKodu,adi,soyadi,parola,gorevi from Yonetici Inner Join gorev on (yonetici.gorevKodu='222222' and gorev.gorevKodu='222222')";
            SqlDataAdapter adpr = new SqlDataAdapter(veriOku);
            DataSet ds = new DataSet();
            adpr.Fill(ds, "yonetici,gorev");
            dgv.DataSource = ds.Tables["yonetici,gorev"];
            baglanti.Close();
        }
        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgv.CurrentRow.Selected = true;
                yoneticiKodu.Text = dgv.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                ad.Text = dgv.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                soyad.Text = dgv.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                parola.Text = dgv.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();


            }
        }

        private void yoneticiler2_Load(object sender, EventArgs e)
        {
            guncelle(dgv);
        }

        private void yoneticiEkle_Click(object sender, EventArgs e)
        {
            if (yoneticiKodu.Text != "" && ad.Text != "" && soyad.Text != "" && parola.Text != "")
            {

                bilgiler();
                bool result = DAO.hastaneYoneticiArama(yonetici);
                if (result)
                {
                    MessageBox.Show("sistemde böyle bir yönetici kayıtlı!!!");

                }
                else
                {

                    DAO.hastaneYoneticiekle(yonetici);
                    MessageBox.Show("Başarıyla eklendi.");
                    yoneticiKodu.Text = "";
                    ad.Text = "";
                    soyad.Text = "";
                    parola.Text = "";

                }
            }
            else
            {
                MessageBox.Show("alanları eksiksiz giriniz lütfen!!!");
            }
            guncelle(dgv);
        }

        private void yoneticiSil_Click(object sender, EventArgs e)
        {
            bilgiler();
            bool result = DAO.hastaneYoneticiArama(yonetici);
            if (result)
            {

                DAO.hastaneYoneticiSil(yonetici);
                yoneticiKodu.Text = "";
                ad.Text = "";
                soyad.Text = "";
                parola.Text = "";

                MessageBox.Show("işlem başarılı");
            }
            else
            {
                MessageBox.Show("böyle bir kayıt bulunamadı!!!");
            }
            guncelle(dgv);
        }

        private void yoneticiGuncelle_Click(object sender, EventArgs e)
        {

            if (yoneticiKodu.Text != "" && ad.Text != "" && soyad.Text != "" && parola.Text != "")
            {
                bilgiler();

                DAO.hastaneYoneticiGuncelle(yonetici);
                MessageBox.Show("Başarıyla Güncellendi.");
                yoneticiKodu.Text = "";
                ad.Text = "";
                soyad.Text = "";
                parola.Text = "";

            }
            else
            {
                MessageBox.Show("alanları eksiksiz giriniz lütfen!!!");
            }

            guncelle(dgv);
        }
    }
}
