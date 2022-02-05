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
    public partial class kapiEkle : Form
    {
        public kapiEkle()
        {
            InitializeComponent();
        }
        sqlSinif sqlSinif = new sqlSinif();
        private void button_giris_Click(object sender, EventArgs e)
        {
            sqlSinif sqlSinif = new sqlSinif();

            string kmt = "insert into kapilar (ad,durum) values (@p1,@p2)";
            SqlCommand komut = new SqlCommand(kmt, sqlSinif.Baglanti_ac());
            komut.Parameters.AddWithValue("@p1", textBox_ad.Text);
            komut.Parameters.AddWithValue("@p2", comboBox_durum.Text);
            komut.ExecuteNonQuery();
            sqlSinif.Close();
            MessageBox.Show("Kayıt Eklendi");
        }
    }
}
