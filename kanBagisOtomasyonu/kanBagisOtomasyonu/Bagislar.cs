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
    public partial class Bagislar : Form
    {
        SqlConnection baglanti = new SqlConnection("server=gk\\mssqlserver01;Database=kanBagisOtomasyon;Trusted_Connection=true");
        SqlCommand veriOku = new SqlCommand();
        Bagis bagis = new Bagis();
        

        private void Bagislar_Load(object sender, EventArgs e)
        {
            guncelle(dgv);
        }

        public void guncelle(DataGridView dgv)
        {
            baglanti.Open();
            veriOku.Connection = baglanti;
            veriOku.CommandText = "select * from bagis";
            SqlDataAdapter adpr = new SqlDataAdapter(veriOku);
            DataSet ds = new DataSet();
            adpr.Fill(ds, "bagis");
            dgv.DataSource = ds.Tables["bagis"];
            baglanti.Close();
        }

        public void bilgiler()
        {
            bagis.setKimlikNo(tcKimlikNo.Text);
            bagis.setSubeNo(subeNo.Text);
            bagis.setVerilisTarihi(verilisTarihi.Text);

        }

        private void bagisciEkle_Click(object sender, EventArgs e)
        {
            bilgiler();
            if (subeNo.Text != "" && tcKimlikNo.Text != "" && verilisTarihi.Text != "")
            {
                if (tcKimlikNo.Text.Length == 11)
                {
                    bool result = DAO.bagisciBagisMerkeziArama(bagis);
                    

                    if (result)
                    {
                        DAO.bagisEkle(bagis);
                        MessageBox.Show("kayıt başarılı bir şekide eklendi.");
                        tcKimlikNo.Text = "";
                        subeNo.Text = "";
                        verilisTarihi.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Böyle bir kan bağış merkezi veya bağışcı bulunmamaktadır!!!");
                    }
                }
                else
                {
                    MessageBox.Show("tc Kimlik No 11 haneli olmalı");
                }
            }
            else
            {
                MessageBox.Show("alanları eksiksiz giriniz.");
            }

            guncelle(dgv);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgv.CurrentRow.Selected = true;
                subeNo.Text = dgv.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                tcKimlikNo.Text = dgv.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();              
                verilisTarihi.Text = dgv.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                

            }
        }

        private void bagisciGuncelle_Click(object sender, EventArgs e)
        {

            bilgiler();
            if (subeNo.Text != "" && tcKimlikNo.Text != "" && verilisTarihi.Text != "")
            {
                if (tcKimlikNo.Text.Length == 11)
                {
                    bool result = DAO.bagisciBagisMerkeziArama(bagis);


                    if (result)
                    {
                        DAO.bagisGuncelle(bagis);
                        MessageBox.Show("kayıt başarılı bir şekide güncellendi.");
                        tcKimlikNo.Text = "";
                        subeNo.Text = "";
                        verilisTarihi.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Böyle bir kan bağış merkezi veya bağışcı bulunmamaktadır!!!");
                    }
                }
                else
                {
                    MessageBox.Show("tc Kimlik No 11 haneli olmalı");
                }
            }
            else
            {
                MessageBox.Show("alanları eksiksiz giriniz.");
            }
            guncelle(dgv);

        }

        private void subeNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void bagisciSil_Click(object sender, EventArgs e)
        {
            bilgiler();
            if (subeNo.Text != "" && tcKimlikNo.Text != "" && verilisTarihi.Text != "")
            {
                if (tcKimlikNo.Text.Length == 11)
                {
                    bool result = DAO.bagisciBagisMerkeziArama(bagis);


                    if (result)
                    {
                        DAO.bagisSil(bagis);
                        MessageBox.Show("kayıt başarılı bir şekide silindi.");
                        tcKimlikNo.Text = "";
                        subeNo.Text = "";
                        verilisTarihi.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Böyle bir bağış bulunmamaktadır !!!");
                    }
                }
                else
                {
                    MessageBox.Show("tc Kimlik No 11 haneli olmalı");
                }
            }
            else
            {
                MessageBox.Show("alanları eksiksiz giriniz.");
            }
            guncelle(dgv);
        }
    }
}
