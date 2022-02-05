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
    public partial class kullaniciEkle : Form
    {
        public kullaniciEkle()
        {
            InitializeComponent();
        }
        sqlSinif sqlSinif = new sqlSinif();
        private void button_giris_Click(object sender, EventArgs e)
        {
            string kmt = "insert into kullanicilar (ad,soyad,sifre,kullanici_adi) values (@p1,@p2,@p3,@p4)";
            SqlCommand komut = new SqlCommand(kmt, sqlSinif.Baglanti_ac());
            komut.Parameters.AddWithValue("@p1", textBox_ad.Text);
            komut.Parameters.AddWithValue("@p2", textBox_soyad.Text);
            komut.Parameters.AddWithValue("@p3", textBox_kullanici_adi.Text);
            komut.Parameters.AddWithValue("@p4", textBox_sifre.Text);
            komut.ExecuteNonQuery();
            sqlSinif.Close();
            MessageBox.Show("Kayıt Eklendi");

        }
    }
}
