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
    public partial class Tedarik : Form
    {
        public Tedarik()
        {
            InitializeComponent();
        }
        tedarikk tedarikk = new tedarikk();
        SqlConnection baglanti = new SqlConnection("server=gk\\mssqlserver01;Database=kanBagisOtomasyon;Trusted_Connection=true");
        SqlCommand veriOku = new SqlCommand();
        public void bilgiler()
        {
            tedarikk.setSubeKodu(subeKodu.Text);
            tedarikk.setHastaneKodu(hastaneKodu.Text);
            tedarikk.setKanGrubu(kanGrubu.Text);
            tedarikk.setAlinmaTarihi(alinmaTarihi.Text);
            tedarikk.setMiktar(Convert.ToInt32(miktar.Text));
        }
        public void guncelle(DataGridView dgv)
        {
            baglanti.Open();
            veriOku.Connection = baglanti;
            veriOku.CommandText = "select * from tedarik";
            SqlDataAdapter adpr = new SqlDataAdapter(veriOku);
            DataSet ds = new DataSet();
            adpr.Fill(ds, "tedarik");
            dgv.DataSource = ds.Tables["tedarik"];
            baglanti.Close();
        }

        private void Tedarik_Load(object sender, EventArgs e)
        {
            guncelle(dgv);

        }

        private void miktar_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ekle_Click(object sender, EventArgs e)
        {
            if (subeKodu.Text != "" && hastaneKodu.Text != "" && alinmaTarihi.Text != "" && kanGrubu.Text != "" && miktar.Text != "")
            {
                
                    bilgiler();
                    bool result = DAO.tedarikBagisMerkeziHastaneArama(tedarikk);
                if (result)
                {
                    DAO.tedarikEkle(tedarikk);
                    MessageBox.Show("Başarıyla eklendi.");
                    subeKodu.Text = "";
                    hastaneKodu.Text = "";
                    kanGrubu.Text = "";
                    alinmaTarihi.Text = "";
                    miktar.Text = "";

                }
                else
                {
                    MessageBox.Show("sistemde böyle bir bağış merkezi veya hastane kayıtlı değil !!!");
                    
                    
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
                subeKodu.Text = dgv.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                hastaneKodu.Text = dgv.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                alinmaTarihi.Text = dgv.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                kanGrubu.Text = dgv.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                miktar.Text = dgv.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();

            }

        }

        private void Sil_Click(object sender, EventArgs e)
        {
            if (subeKodu.Text != "" && hastaneKodu.Text != "" && alinmaTarihi.Text != "" && kanGrubu.Text != "" && miktar.Text != "")
            {

                bilgiler();
                bool result = DAO.tedarikBagisMerkeziHastaneArama(tedarikk);
                if (result)
                {
                    DAO.tedarikSil(tedarikk);
                    MessageBox.Show("Başarıyla silindi.");
                    subeKodu.Text = "";
                    hastaneKodu.Text = "";
                    kanGrubu.Text = "";
                    alinmaTarihi.Text = "";
                    miktar.Text = "";

                }
                else
                {
                    MessageBox.Show("sistemde böyle bir bağış merkezi veya hastane kayıtlı değil !!!");


                }
            }
            else
            {
                MessageBox.Show("alanları eksiksiz giriniz lütfen!!!");
            }
            guncelle(dgv);
        }

        private void Guncelle_Click(object sender, EventArgs e)
        {
            if (subeKodu.Text != "" && hastaneKodu.Text != "" && alinmaTarihi.Text != "" && kanGrubu.Text != "" && miktar.Text != "")
            {

                bilgiler();
               
                
                    DAO.tedarikSil(tedarikk);
                    MessageBox.Show("Başarıyla silindi.");
                    subeKodu.Text = "";
                    hastaneKodu.Text = "";
                    kanGrubu.Text = "";
                    alinmaTarihi.Text = "";
                    miktar.Text = "";

            
            }
            else
            {
                MessageBox.Show("alanları eksiksiz giriniz lütfen!!!");
            }
            guncelle(dgv);
        }
    }
}
