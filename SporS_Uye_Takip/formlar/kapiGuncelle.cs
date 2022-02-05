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
    public partial class kapiGuncelle : Form
    {
        public int id { get; set; }
        public string ad { get; set; }
        public string durum { get; set; }

        public kapiGuncelle()
        {
            InitializeComponent();
        }
        
        private void button_giris_Click(object sender, EventArgs e)
        {
            sqlSinif sqlSinif = new sqlSinif();
            string kmt = "Update kapilar  set ad=@p1,durum=@p2 where kapi_id=@p3";
            SqlCommand komut = new SqlCommand(kmt, sqlSinif.Baglanti_ac());
            komut.Parameters.AddWithValue("@p1", textBox_ad.Text);
            komut.Parameters.AddWithValue("@p2",comboBox_durum.Text);
            komut.Parameters.AddWithValue("@p3", textBox_id.Text);

            komut.ExecuteNonQuery();

            sqlSinif.Close();
        }

        private void kapiGuncelle_Load(object sender, EventArgs e)
        {
            textBox_id.Text = id.ToString();
            textBox_ad.Text = ad;
            comboBox_durum.Text = durum;
        }
    }
}
