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
    public partial class BagisMerkezleri : Form
    {
        
        public BagisMerkezleri()
        {
            InitializeComponent();
        }

        private void BagisMerkezleri_Load(object sender, EventArgs e)
        {
            guncelle(dgv);

        }
        KanBagisMerkezi kanbagismerkezi = new KanBagisMerkezi();

        SqlConnection baglanti = new SqlConnection("server=gk\\mssqlserver01;Database=kanBagisOtomasyon;Trusted_Connection=true");
        SqlCommand veriOku = new SqlCommand();
        public void guncelle(DataGridView dgv)
        {
            baglanti.Open();
            veriOku.Connection = baglanti;
            veriOku.CommandText = "select * from kanBagisMerkezi";
            SqlDataAdapter adpr = new SqlDataAdapter(veriOku);
            DataSet ds = new DataSet();
            adpr.Fill(ds, "kanBagisMerkezi");
            dgv.DataSource = ds.Tables["kanBagisMerkezi"];
            baglanti.Close();
        }
        public void bilgiler()
        {
            kanbagismerkezi.setSubeKodu(subeKodu.Text);
            kanbagismerkezi.setAdi(ad.Text);
            kanbagismerkezi.setAcilisTarihi(acilisTarihi.Text);
            kanbagismerkezi.setAdresi(adresi.Text);
        }


        private void adresi_TextChanged(object sender, EventArgs e)
        {

        }

        private void bagisciEkle_Click(object sender, EventArgs e)
        {
            if (subeKodu.Text != "" && ad.Text != "" && acilisTarihi.Text != "" && adresi.Text != "")
            {
              
                    bilgiler();
                    bool result = DAO.bagisMerkeziArama(kanbagismerkezi);
                    if (result)
                    {
                        MessageBox.Show("sistemde böyle bir bağışcı kayıtlı!!!");

                    }
                    else
                    {

                        DAO.bagisMerkeziekle(kanbagismerkezi);
                        MessageBox.Show("Başarıyla eklendi.");
                        subeKodu.Text = "";
                        ad.Text = "";
                        acilisTarihi.Text = "";
                        adresi.Text = "";
                    }
            }
            else
            {
                MessageBox.Show("alanları eksiksiz giriniz lütfen!!!");
            }
            guncelle(dgv);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgv.CurrentRow.Selected = true;
                subeKodu.Text = dgv.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                ad.Text = dgv.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                acilisTarihi.Text = dgv.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                adresi.Text = dgv.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();

            }
        }

        private void bagisciSil_Click(object sender, EventArgs e)
        {
            if (subeKodu.Text != "" && ad.Text != "" && acilisTarihi.Text != "" && adresi.Text != "")
            {

                bilgiler();
                bool result = DAO.bagisMerkeziArama(kanbagismerkezi);
                if (result)
                {
                    
                    DAO.bagisMerkeziSil(kanbagismerkezi);
                    MessageBox.Show("Başarıyla silindi.");
                    subeKodu.Text = "";
                    ad.Text = "";
                    acilisTarihi.Text = "";
                    adresi.Text = "";
                }
                else
                {
                    MessageBox.Show("sistemde böyle bir bağışcı kayıtlı Degil!!!");

                }
            }
            else
            {
                MessageBox.Show("alanları eksiksiz giriniz lütfen!!!");
            }
            guncelle(dgv);
        }

        private void bagisciGuncelle_Click(object sender, EventArgs e)
        {
            if (subeKodu.Text != "" && ad.Text != "" && acilisTarihi.Text != "" && adresi.Text != "")
            {
                bilgiler();    
                DAO.bagisMerkeziGuncelle(kanbagismerkezi);
                MessageBox.Show("Başarıyla Güncellendi.");
                subeKodu.Text = "";
                ad.Text = "";
                acilisTarihi.Text = "";
                adresi.Text = "";
             
            }
            else
            {
                MessageBox.Show("alanları eksiksiz giriniz lütfen!!!");
            }
            guncelle(dgv);
        }
    }
}
