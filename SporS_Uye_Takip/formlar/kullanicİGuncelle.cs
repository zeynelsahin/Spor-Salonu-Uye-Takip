using SporS_Uye_Takip.siniflar;
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

namespace SporS_Uye_Takip.formlar
{
    public partial class kullanicİGuncelle : Form
    {
        public kullanicİGuncelle()
        {
            InitializeComponent();
        }
        public int id { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string kullanici_adi { get; set; }
        public string sifre { get; set; }
        private void button_giris_Click(object sender, EventArgs e)
        {
            sqlSinif sqlSinif = new sqlSinif();
            string kmt = "Update kullanicilar set ad=@p1,soyad=@p2,sifre=@p3,kullanici_adi=@p4 where kullanici_id=@p5";
            SqlCommand komut = new SqlCommand(kmt,sqlSinif.Baglanti_ac());
            komut.Parameters.AddWithValue("@p1",textBox_ad.Text);
            komut.Parameters.AddWithValue("@p2", textBox_soyad.Text);
            komut.Parameters.AddWithValue("@p3", textBox_sifre.Text);
            komut.Parameters.AddWithValue("@p4", textBox_kullanici_adi.Text);
            komut.Parameters.AddWithValue("@p5", textBox_id.Text);
            komut.ExecuteNonQuery();

            sqlSinif.Close();
        }

        private void kullanicİGuncelle_Load(object sender, EventArgs e)
        {
            textBox_ad.Text = ad;
            textBox_kullanici_adi.Text = kullanici_adi;
            textBox_sifre.Text = sifre;
            textBox_soyad.Text = soyad;
            textBox_id.Text = id.ToString();
        }
    }
}
