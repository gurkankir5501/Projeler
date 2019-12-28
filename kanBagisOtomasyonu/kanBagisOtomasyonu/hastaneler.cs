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
    public partial class hastaneler : Form
    {
        public hastaneler()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("server=gk\\mssqlserver01;Database=kanBagisOtomasyon;Trusted_Connection=true");
        SqlCommand veriOku = new SqlCommand();
        Hastane hastane = new Hastane();
        public void guncellee(DataGridView dgv)
        {
            baglanti.Open();
            veriOku.Connection = baglanti;
            veriOku.CommandText = "select * from hastane";
            SqlDataAdapter adpr = new SqlDataAdapter(veriOku);
            DataSet ds = new DataSet();
            adpr.Fill(ds, "hastane");
            dgv.DataSource = ds.Tables["hastane"];
            baglanti.Close();
        }

        private void hastaneler_Load(object sender, EventArgs e)
        {
            guncellee(dgv);
        }

        public void bilgiler()
        {
            hastane.setHastaneKodu(hastaneKodu.Text);
            hastane.setAdi(adi.Text);
            hastane.setAdresi(adresi.Text);
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgv.CurrentRow.Selected = true;
                hastaneKodu.Text = dgv.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                adi.Text = dgv.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                adresi.Text = dgv.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
      
            }
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            if (hastaneKodu.Text != "" && adi.Text != "" && adresi.Text != "")
            {
                
                    bilgiler();
                    bool result = DAO.hastaneeArama(hastane);
                    if (result)
                    {

                    MessageBox.Show("sistemde böyle bir hastane kayıtlıdır !!!");

                }
                    else
                    {
                    DAO.hastaneEkle(hastane);
                    MessageBox.Show("Başarıyla eklendi.");
                    hastaneKodu.Text = "";
                    adi.Text = "";
                    adresi.Text = "";
                    
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
            if (hastaneKodu.Text != "" && adi.Text != "" && adresi.Text != "")
            {
                
                    bilgiler();
                    bool result = DAO.hastaneeArama(hastane);
                    if (result)
                    {

                        DAO.hastaneSil(hastane);
                        MessageBox.Show("Başarıyla silindi.");
                        hastaneKodu.Text = "";
                        adi.Text = "";
                        adresi.Text = "";
                        
                    }
                    else
                    {

                        MessageBox.Show("sistemde böyle bir hastane kayıtlı değildir !!!");
                    }

            }
            else
            {
                MessageBox.Show("alanları eksiksiz giriniz lütfen!!!");
            }
            guncellee(dgv);
        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            if (hastaneKodu.Text != "" && adi.Text != "" && adresi.Text != "")
            {
              
                    bilgiler();
                    bool result = DAO.hastaneeArama(hastane);
                    if (result)
                    {

                        DAO.hastaneGuncelle(hastane);
                        MessageBox.Show("Başarıyla güncellendi.");
                        hastaneKodu.Text = "";
                        adi.Text = "";
                        adresi.Text = "";
                        
                    }
                    else
                    {

                        MessageBox.Show("sistemde böyle bir hastane kayıtlı değildir !!!");
                    }

            }
            else
            {
                MessageBox.Show("alanları eksiksiz giriniz lütfen!!!");
            }
            guncellee(dgv);
        }
    }
}
