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
    public partial class KanDeposu : Form
    {
        public KanDeposu()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("server=gk\\mssqlserver01;Database=kanBagisOtomasyon;Trusted_Connection=true");
        SqlCommand veriOku = new SqlCommand();
        kanDepo kanDepo = new kanDepo();
        public void bilgiler()
        {
            kanDepo.setKanDeposuId(kanDeposuId.Text);
            kanDepo.setKanGrubu(kanGrubu.Text);
            kanDepo.setVerilisTarihi(verilisTarihi.Text);
            kanDepo.setMiktar(Convert.ToInt32(miktar.Text));
            kanDepo.setSubeKodu(subeKodu.Text);

        }

        public void guncelle(DataGridView dgv)
        {
            baglanti.Open();
            veriOku.Connection = baglanti;
            veriOku.CommandText = "select * from kanDeposu";
            SqlDataAdapter adpr = new SqlDataAdapter(veriOku);
            DataSet ds = new DataSet();
            adpr.Fill(ds, "kanDeposu");
            dgv.DataSource = ds.Tables["kanDeposu"];
            baglanti.Close();
        }
        private void KanDeposu_Load(object sender, EventArgs e)
        {
            guncelle(dgv);
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            if (kanDeposuId.Text != "" && kanGrubu.Text != "" && verilisTarihi.Text != "" && miktar.Text != "" && subeKodu.Text !="")
            {
               
                
                    bilgiler();
                    bool result = DAO.bagisKanDeposuMerkeziArama(kanDepo);
                    if (result)
                    {
                        
                        DAO.bagisKanDeposuMerkeziEkle(kanDepo);
                        MessageBox.Show("Başarıyla eklendi.");
                        kanDeposuId.Text = "";
                        kanGrubu.Text = "";
                        verilisTarihi.Text = "";
                        miktar.Text = "";
                        subeKodu.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("sistemde böyle bir şube kayıtlı değil!!!");

                    }

            }
            else
            {
                MessageBox.Show("alanları eksiksiz giriniz lütfen!!!");
            }
            guncelle(dgv);

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgv.CurrentRow.Selected = true;
                kanDeposuId.Text = dgv.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                kanGrubu.Text = dgv.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                verilisTarihi.Text = dgv.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                miktar.Text = dgv.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                subeKodu.Text = dgv.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();

            }
        }

        private void sil_Click(object sender, EventArgs e)
        {
            if (kanDeposuId.Text != "" && kanGrubu.Text != "" && verilisTarihi.Text != "" && miktar.Text != "" && subeKodu.Text != "")
            {


                bilgiler();
                bool result = DAO.bagisKanDeposuIdArama(kanDepo);
                if (result)
                {

                    DAO.bagisKanDeposuMerkeziSil(kanDepo);
                    MessageBox.Show("Başarıyla silindi.");
                    kanDeposuId.Text = "";
                    kanGrubu.Text = "";
                    verilisTarihi.Text = "";
                    miktar.Text = "";
                    subeKodu.Text = "";
                }
                else
                {
                    MessageBox.Show("sistemde böyle bir kan kodu kayıtlı değil!!!");

                }

            }
            else
            {
                MessageBox.Show("alanları eksiksiz giriniz lütfen!!!");
            }
            guncelle(dgv);
        }

        private void guncellee_Click(object sender, EventArgs e)
        {
            if (kanDeposuId.Text != "" && kanGrubu.Text != "" && verilisTarihi.Text != "" && miktar.Text != "" && subeKodu.Text != "")
            {


                bilgiler();
               

                    DAO.bagisKanDeposuMerkeziGuncelle(kanDepo);
                    MessageBox.Show("Başarıyla güncellendi.");
                    kanDeposuId.Text = "";
                    kanGrubu.Text = "";
                    verilisTarihi.Text = "";
                    miktar.Text = "";
                    subeKodu.Text = "";
              

            }
            else
            {
                MessageBox.Show("alanları eksiksiz giriniz lütfen!!!");
            }
            guncelle(dgv);

        }
    }
}
