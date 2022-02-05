using SporS_Uye_Takip.siniflar;
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
using SporS_Uye_Takip.formlar;

namespace SporS_Uye_Takip
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }
        private void button_giris_Click(object sender, EventArgs e)
        {
            sqlSinif sqlSinif = new sqlSinif();
            string kmt = "select *from kullanicilar where kullanici_adi=@p1 and sifre=@p2 ";
            SqlCommand komut = new SqlCommand(kmt, sqlSinif.Baglanti_ac());
            komut.Parameters.AddWithValue("@p1", textBox_kullanici.Text);
            komut.Parameters.AddWithValue("@p2", textBox_sifre.Text);
            SqlDataReader da = komut.ExecuteReader();
            if (da.Read())
            {
                this.Hide();
                anaSayfa anaSayfa = new anaSayfa();
                anaSayfa.Show();
        
            }
            else
            {
                label_hata.Show();
            }
        }

        private void textBox_kullanici_Enter(object sender, EventArgs e)
        {
            label_hata.Hide();
        }

        private void textBox_sifre_Enter(object sender, EventArgs e)
        {
            label_hata.Hide();
        }
    }
}
