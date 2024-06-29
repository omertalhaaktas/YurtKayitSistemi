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

namespace YurtKayitSistemi
{
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();
        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();

            DataSet ds = new DataSet();

            if (bgl.baglanti().State == ConnectionState.Closed)
            {
                bgl.baglanti().Open();
            }

            adapter.SelectCommand = new SqlCommand("SELECT * FROM Personel", bgl.baglanti());
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            bgl.baglanti().Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Personel (PersonelAdSoyad, PersonelDepartman) values (@p1, @p2)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtPersonelAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtPersonelGorev.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Eklendi");


            SqlDataAdapter adapter = new SqlDataAdapter();

            DataSet ds = new DataSet();

            if (bgl.baglanti().State == ConnectionState.Closed)
            {
                bgl.baglanti().Open();
            }

            adapter.SelectCommand = new SqlCommand("SELECT * FROM Personel", bgl.baglanti());
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            bgl.baglanti().Close();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("delete from Personel where Personelid=@p1", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", TxtPersonelid.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Başarıyla Silindi");

            SqlDataAdapter adapter = new SqlDataAdapter();

            DataSet ds = new DataSet();

            if (bgl.baglanti().State == ConnectionState.Closed)
            {
                bgl.baglanti().Open();
            }

            adapter.SelectCommand = new SqlCommand("SELECT * FROM Personel", bgl.baglanti());
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            bgl.baglanti().Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            string ad, gorev, id;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            gorev = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

            TxtPersonelAd.Text = ad;
            TxtPersonelid.Text = id;
            TxtPersonelGorev.Text = gorev;
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut3 = new SqlCommand("update Personel set PersonelAdSoyad=@p1,PersonelDepartman=@p2 where Personelid=@p3", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", TxtPersonelAd.Text);
            komut3.Parameters.AddWithValue("@p2", TxtPersonelGorev.Text);
            komut3.Parameters.AddWithValue("@p3", TxtPersonelid.Text);
            komut3.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel Başarıyla Güncellendi");

            SqlDataAdapter adapter = new SqlDataAdapter();

            DataSet ds = new DataSet();

            if (bgl.baglanti().State == ConnectionState.Closed)
            {
                bgl.baglanti().Open();
            }

            adapter.SelectCommand = new SqlCommand("SELECT * FROM Personel", bgl.baglanti());
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            bgl.baglanti().Close();
        }
    }
}
