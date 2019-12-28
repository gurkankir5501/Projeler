using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace kanBagisOtomasyonu
{
    
    public partial class Bagiscilarsayfasi : Form
    {
        SqlConnection baglanti = new SqlConnection("server=gk\\mssqlserver01;Database=kanBagisOtomasyon;Trusted_Connection=true");
        SqlCommand veriOku = new SqlCommand();

        Bagisci bagisci = new Bagisci();
       
        public Bagiscilarsayfasi()
        {
            InitializeComponent();
        }
        
        public void guncelle(DataGridView dgv)
        {
            baglanti.Open();
            veriOku.Connection = baglanti;
            veriOku.CommandText = "select * from bagisci";
            SqlDataAdapter adpr = new SqlDataAdapter(veriOku);
            DataSet ds = new DataSet();
            adpr.Fill(ds, "bagisci");
            dgv.DataSource = ds.Tables["bagisci"];
            baglanti.Close();
        }


        private void tcKimlikNo_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void ad_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        private void soyad_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void kanGrubu_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void telNo_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void adresi_TextChanged(object sender, EventArgs e)
        {
            
           
        }

        public void bilgiler()
        {
            bagisci.setTcKimlikNo(tcKimlikNo.Text);
            bagisci.setAd(ad.Text);
            bagisci.setSoyad(soyad.Text);
            bagisci.setKanGrubu(kanGrubu.Text);
            bagisci.setTelNo(telNo.Text);
            bagisci.setAdres(adresi.Text);
        }
        
        private void bagisciEkle_Click(object sender, EventArgs e)
        {
            if (tcKimlikNo.Text != "" && ad.Text != "" && soyad.Text != "" && kanGrubu.Text != "" && telNo.Text != "" && adresi.Text != "")
            {
                if (tcKimlikNo.Text.Length == 11 && telNo.Text.Length == 11)
                {
                    bilgiler();
                    bool result = DAO.bagisciArama(bagisci);
                    if (result)
                    {
                        MessageBox.Show("sistemde böyle bir bağışcı kayıtlı!!!");

                    }
                    else
                    {
                        
                        DAO.bagisciEkle(bagisci);
                        MessageBox.Show("Başarıyla eklendi.");
                        tcKimlikNo.Text = "";
                        ad.Text = "";
                        soyad.Text = "";
                        kanGrubu.Text = "";
                        telNo.Text = "";
                        adresi.Text = "";
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

        private void bagisciListele_Click(object sender, EventArgs e)
        {
            bilgiler();


        }
        
        private void bagisciSil_Click(object sender, EventArgs e)
        {
            if (tcKimlikNo.Text != "" && tcKimlikNo.Text.Length==11)
            {

                bilgiler();
                bool result = DAO.bagisciArama(bagisci);
                if (result)
                {
                    
                    DAO.bagisciSil(bagisci);
                    tcKimlikNo.Text = "";
                    ad.Text = "";
                    soyad.Text = "";
                    kanGrubu.Text = "";
                    telNo.Text = "";
                    adresi.Text = "";
                    MessageBox.Show("işlem başarılı");
                }
                else
                {
                    MessageBox.Show("böyle bir kayıt bulunamadı!!!");
                }
                
            }
            else
            {
                MessageBox.Show("TC kimlik no 11 haneli olmalıdır!!!");
            }
            guncelle(dgv);

        }

        private void bagisciGuncelle_Click(object sender, EventArgs e)
        {
            
            if (tcKimlikNo.Text != ""&& tcKimlikNo.Text==tcKimlikNo.Text && ad.Text != "" && soyad.Text != "" && kanGrubu.Text != "" && telNo.Text != "" && adresi.Text != "")
            {
                if (tcKimlikNo.Text.Length == 11 && telNo.Text.Length == 11)
                {
                    bilgiler();
                    bool result = DAO.bagisciArama(bagisci);
                    if (result)
                    {
                        DAO.bagisciGuncelle(bagisci);
                        MessageBox.Show("Başarıyla Güncellendi.");
                        tcKimlikNo.Text = "";
                        ad.Text = "";
                        soyad.Text = "";
                        kanGrubu.Text = "";
                        telNo.Text = "";
                        adresi.Text = "";

                    }
                    

                }
                else
                {
                    MessageBox.Show("TC kimlik numarası ve telefon numarası 11 haneli giriniz!!!");
                }

            }
            else
            {
                MessageBox.Show("alanları eksiksiz giriniz lütfen!!!\n"+"tc Kimlik numarası güncellenemez!!!");
            }

            guncelle(dgv);


        }


        private void Bagiscilarsayfasi_Load(object sender, EventArgs e)
        {
            guncelle(dgv);
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgv.CurrentRow.Selected = true;
                tcKimlikNo.Text = dgv.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                ad.Text = dgv.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                soyad.Text = dgv.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                kanGrubu.Text = dgv.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                telNo.Text = dgv.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
                adresi.Text = dgv.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                
            }
            
            

        }

       
    }
}
