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
    public partial class hastaneİlanlar : Form
    {
        public hastaneİlanlar()
        {
            InitializeComponent();
        }



        SqlConnection baglanti = new SqlConnection("server=gk\\mssqlserver01;Database=kanBagisOtomasyon;Trusted_Connection=true");
        SqlCommand veriOku = new SqlCommand();
        ilanlarr ilanlarr = new ilanlarr();
        public void bilgiler()
        {
            ilanlarr.setilanKodu(ilanKodu.Text);
            ilanlarr.setilanMetini(ilanMetini.Text);
            ilanlarr.setYoneticiKodu(yoneticiKodu.Text);
        }

        public void guncellee(DataGridView dataGridView)
        {
            baglanti.Open();
            veriOku.Connection = baglanti;
            veriOku.CommandText = "select * from ilan";
            SqlDataAdapter adpr = new SqlDataAdapter(veriOku);
            DataSet ds = new DataSet();
            adpr.Fill(ds, "ilan");
            dgv.DataSource = ds.Tables["ilan"];
            baglanti.Close();
        }
        private void hastaneİlanlar_Load(object sender, EventArgs e)
        {
            guncellee(dgv); 
        }

        private void ilanKodu_TextChanged(object sender, EventArgs e)
        {

        }

        private void ekle_Click(object sender, EventArgs e)
        {
            if (ilanKodu.Text != "" && ilanMetini.Text != "" && yoneticiKodu.Text != "" )
            {
                
                    bilgiler();
                    bool result = DAO.ilanArama(ilanlarr);
                    if (result)
                    {
                        MessageBox.Show("sistemde böyle bir bağışcı kayıtlı!!!");

                    }
                    else
                    {

                        DAO.ilanEkle(ilanlarr);
                        MessageBox.Show("Başarıyla eklendi.");
                        ilanKodu.Text = "";
                        ilanMetini.Text = "";
                        yoneticiKodu.Text = "";
                    }

            }
            else
            {
                MessageBox.Show("alanları eksiksiz giriniz lütfen!!!");
            }

            guncellee(dgv);
        }

        private void sil_Click(object sender, EventArgs e)
        {
            bilgiler();
            bool result = DAO.ilanArama(ilanlarr);
            if (result)
            {

                DAO.ilanSil(ilanlarr);
                ilanKodu.Text = "";
                ilanMetini.Text = "";
                yoneticiKodu.Text = "";
                MessageBox.Show("işlem başarılı");
            }
            else
            {
                MessageBox.Show("böyle bir kayıt bulunamadı!!!");
            }
            guncellee(dgv);
        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            if (ilanKodu.Text != "" && ilanMetini.Text != "" && yoneticiKodu.Text != "")
            {

                bilgiler();
                bool result = DAO.ilanArama(ilanlarr);
                if (result)
                {
                    
                    DAO.ilanGuncelle(ilanlarr);
                    MessageBox.Show("Başarıyla güncellendi.");
                    ilanKodu.Text = "";
                    ilanMetini.Text = "";
                    yoneticiKodu.Text = "";
                }
                else
                {

                    MessageBox.Show("sistemde böyle bir ilan kayıtlı değildir!!!");
                }

            }
            else
            {
                MessageBox.Show("alanları eksiksiz giriniz lütfen!!!");
            }

            guncellee(dgv);
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgv.CurrentRow.Selected = true;
                ilanKodu.Text = dgv.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                ilanMetini.Text = dgv.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                yoneticiKodu.Text = dgv.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                

            }
        }
    }
}
