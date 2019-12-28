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
    public partial class hastalar : Form
    {
        public hastalar()
        {
            InitializeComponent();
        }
        Hasta hasta = new Hasta();
        SqlConnection baglanti = new SqlConnection("server=gk\\mssqlserver01;Database=kanBagisOtomasyon;Trusted_Connection=true");
        SqlCommand veriOku = new SqlCommand();

        public void guncelle(DataGridView dgv)
        {
            baglanti.Open();
            veriOku.Connection = baglanti;
            veriOku.CommandText = "select * from hasta";
            SqlDataAdapter adpr = new SqlDataAdapter(veriOku);
            DataSet ds = new DataSet();
            adpr.Fill(ds, "hasta");
            dgv.DataSource = ds.Tables["hasta"];
            baglanti.Close();
        }
        public void bilgiler()
        {
            hasta.setKimlikNo(kimlikNo.Text);
            hasta.setAdi(adi.Text);
            hasta.setSoyadi(soyadi.Text);
            hasta.setKanGrubu(kanGrubu.Text);
            hasta.setAdresi(adresi.Text);
            hasta.setTelNo(telNo.Text);
            hasta.setHastaneKodu(hastaneKodu.Text);

        }
        private void ekle_Click(object sender, EventArgs e)
        {
            if (kimlikNo.Text != "" && adi.Text != "" && soyadi.Text != "" && kanGrubu.Text != "" && telNo.Text != "" && adresi.Text != ""&& hastaneKodu.Text!="")
            {
                if (kimlikNo.Text.Length == 11 && telNo.Text.Length == 11)
                {
                    bilgiler();
                    bool result = DAO.hastaneArama(hasta);
                    if (result)
                    {
                        
                        DAO.hastaEkle(hasta);
                        MessageBox.Show("Başarıyla eklendi.");
                        kimlikNo.Text = "";
                        adi.Text = "";
                        soyadi.Text = "";
                        kanGrubu.Text = "";
                        telNo.Text = "";
                        adresi.Text = "";
                        hastaneKodu.Text = "";
                    }
                    else
                    {

                        MessageBox.Show("sistemde böyle bir hastane kayıtlı değildir !!!");
                    }

                }
                else
                {
                    MessageBox.Show("TC kimlik numarası ve telefon numarası 11 haneli giriniz!!!");
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
                kimlikNo.Text = dgv.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                adi.Text = dgv.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                soyadi.Text = dgv.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                kanGrubu.Text = dgv.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                adresi.Text = dgv.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                telNo.Text = dgv.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
                hastaneKodu.Text = dgv.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();


            }
        }

        private void hastalar_Load(object sender, EventArgs e)
        {
            guncelle(dgv);
        }

        private void sil_Click(object sender, EventArgs e)
        {
            if (kimlikNo.Text != "" && adi.Text != "" && soyadi.Text != "" && kanGrubu.Text != "" && telNo.Text != "" && adresi.Text != "" && hastaneKodu.Text != "")
            {
                if (kimlikNo.Text.Length == 11 && telNo.Text.Length == 11)
                {
                    bilgiler();
                    bool result = DAO.hastaArama(hasta);
                    if (result)
                    {

                        DAO.hastaSil(hasta);
                        MessageBox.Show("Başarıyla silindi.");
                        kimlikNo.Text = "";
                        adi.Text = "";
                        soyadi.Text = "";
                        kanGrubu.Text = "";
                        telNo.Text = "";
                        adresi.Text = "";
                        hastaneKodu.Text = "";
                    }
                    else
                    {

                        MessageBox.Show("sistemde böyle bir hasta kayıtlı değildir !!!");
                    }

                }
                else
                {
                    MessageBox.Show("TC kimlik numarası ve telefon numarası 11 haneli giriniz!!!");
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
            if (kimlikNo.Text != "" && adi.Text != "" && soyadi.Text != "" && kanGrubu.Text != "" && telNo.Text != "" && adresi.Text != "" && hastaneKodu.Text != "")
            {
                if (kimlikNo.Text.Length == 11 && telNo.Text.Length == 11)
                {
                    bilgiler();
                    bool result = DAO.hastaArama(hasta);
                    if (result)
                    {

                        DAO.hastaGuncelle(hasta);
                        MessageBox.Show("Başarıyla güncellendi.");
                        kimlikNo.Text = "";
                        adi.Text = "";
                        soyadi.Text = "";
                        kanGrubu.Text = "";
                        telNo.Text = "";
                        adresi.Text = "";
                        hastaneKodu.Text = "";
                    }
                    else
                    {

                        MessageBox.Show("sistemde böyle bir hasta kayıtlı değildir !!!");
                    }

                }
                else
                {
                    MessageBox.Show("TC kimlik numarası ve telefon numarası 11 haneli giriniz!!!");
                }

            }
            else
            {
                MessageBox.Show("alanları eksiksiz giriniz lütfen!!!");
            }
            guncelle(dgv);
        
    }
    }
}
