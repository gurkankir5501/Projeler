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
    public partial class İlanlar : Form
    {
        SqlConnection baglanti = new SqlConnection("server=gk\\mssqlserver01;Database=kanBagisOtomasyon;Trusted_Connection=true");
        SqlCommand veriOku = new SqlCommand();
        public İlanlar()
        {
            InitializeComponent();
        }
        
        private void İlanlar_Load(object sender, EventArgs e)
        {
           
            baglanti.Open();
            veriOku.Connection = baglanti;
            veriOku.CommandText = "select * from ilan";
            SqlDataAdapter adpr = new SqlDataAdapter(veriOku);
            DataSet ds = new DataSet();
            adpr.Fill(ds, "ilan");
            dataGridView1.DataSource = ds.Tables["ilan"];
            baglanti.Close();
            


        }

        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
