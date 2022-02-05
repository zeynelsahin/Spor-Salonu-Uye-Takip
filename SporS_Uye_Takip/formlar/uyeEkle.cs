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
using SporS_Uye_Takip.siniflar;

namespace SporS_Uye_Takip.formlar
{
    public partial class uyeEkle : Form
    {
        public uyeEkle()
        {
            InitializeComponent();
        }
        sqlSinif sqlSinif = new sqlSinif();
        private void button_giris_Click(object sender, EventArgs e)
        {
            string kmt = "insert into uyeler (tcno,ad,soyad,cinsiyet,dogumtarihi,adres,il,ilce,telefon,eposta,kangrubu) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)";
            SqlCommand komut = new SqlCommand(kmt, sqlSinif.Baglanti_ac());
            komut.Parameters.AddWithValue("@p1", maskedTextBox_tcno.Text);
            komut.Parameters.AddWithValue("@p2", textBox_ad.Text);
            komut.Parameters.AddWithValue("@p3", textBox_soyad.Text);
            if (radioButton_erkek.Checked)
            {
                komut.Parameters.AddWithValue("@p4", "erkek");
            }
            else
            {
                komut.Parameters.AddWithValue("@p4", "kadın");
            }
            komut.Parameters.AddWithValue("@p5", maskedTextBox_dogumta.Text);
            komut.Parameters.AddWithValue("@p6", textBox_adres.Text);
            komut.Parameters.AddWithValue("@p7", comboBox_il.Text);
            komut.Parameters.AddWithValue("@p8", comboBox_ilce.Text);
            komut.Parameters.AddWithValue("@p9", "0" + maskedTextBox1_telefon.Text);
            komut.Parameters.AddWithValue("@p10", textBox_eposta.Text);
            komut.Parameters.AddWithValue("@p11", comboBox_kangrub.Text);
            komut.ExecuteNonQuery();
            sqlSinif.Close();
            MessageBox.Show("Kayıt Eklendi");
        }
        private void uyeEkle_Load(object sender, EventArgs e)
        {
            string kmt = "select * from iller";
            SqlCommand komut = new SqlCommand(kmt, sqlSinif.Baglanti_ac());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox_il.DataSource = dt;
            comboBox_il.ValueMember = "id";
            comboBox_il.DisplayMember = "sehir";
        }

        private void comboBox_il_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_il.SelectedIndex != -1)
            {
                string kmt = "select * from ilceler where sehir='" + comboBox_il.SelectedValue + "'";

                SqlDataAdapter da = new SqlDataAdapter(kmt, sqlSinif.Baglanti_ac());
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    comboBox_ilce.DataSource = dt;
                    comboBox_ilce.ValueMember = "id";
                    comboBox_ilce.DisplayMember = "ilce";
                }
            }
        }
    }
}
