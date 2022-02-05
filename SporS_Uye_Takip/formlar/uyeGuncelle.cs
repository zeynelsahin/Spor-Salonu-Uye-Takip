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
    public partial class uyeGuncelle : Form
    {
        public int id { get; set; }
        public uyeGuncelle()
        {
            InitializeComponent();
        }
        sqlSinif sqlSinif = new sqlSinif();
        private void uyeGuncelle_Load(object sender, EventArgs e)
        {
            string deger;
            
            string kmt1 = "select *from iller";
            SqlCommand komut1 = new SqlCommand(kmt1, sqlSinif.Baglanti_ac());
            SqlDataAdapter da = new SqlDataAdapter(komut1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox_il.DataSource = dt;
            comboBox_il.ValueMember = "id";
            comboBox_il.DisplayMember = "sehir";

            string kmt = "select *from uyeler where uye_id=@p1  ";
            SqlCommand komut = new SqlCommand(kmt, sqlSinif.Baglanti_ac());
            komut.Parameters.AddWithValue("@p1", id);
  
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
            
                maskedTextBox_tcno.Text = dr["tcno"].ToString();
                textBox_ad.Text = dr["ad"].ToString();
                textBox_soyad.Text = dr["soyad"].ToString();
                if (dr["cinsiyet"].ToString()=="erkek")
                {
                    radioButton_erkek.Checked = true;
                }
                else
                {
                    radioButton1_kadın.Checked = true;
                }
                maskedTextBox_dogumta.Text = dr["dogumtarihi"].ToString();
                textBox_adres.Text = dr["adres"].ToString();
                maskedTextBox1_telefon.Text = dr["telefon"].ToString();
                textBox_eposta.Text = dr["eposta"].ToString();
                comboBox_kangrub.Text = dr["kangrubu"].ToString();
                
                string d = dr["il"].ToString();
                string d1 = dr["ilce"].ToString();
                dr.Close();
                if ( d!="Şehir Seçiniz...")
                {
                    SqlCommand komut2 = new SqlCommand("select id from iller where sehir='" + d + "'", sqlSinif.Baglanti_ac());
                    deger = komut2.ExecuteScalar().ToString();
                    comboBox_il.SelectedIndex = Convert.ToInt32(deger) - 1;
                    sqlSinif.Close();
                }
                if (d1!="İlçe Seçiniz...")
                {

                    int a= comboBox_ilce.FindStringExact(d1);
                    comboBox_ilce.SelectedIndex = a;
                }
                
            }
            

           
          

        }

        private void comboBox_ilce_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox_il_SelectedIndexChanged(object sender, EventArgs e)
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

        private void comboBox_il_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void button_guncelle_Click(object sender, EventArgs e)
        {
            string kmt = "Update uyeler set tcno=@p1,ad=@p2,soyad=@p3,cinsiyet=@p4,dogumtarihi=@p5,adres=@p6,il=@p7,ilce=@p8,telefon=@p9,eposta=@p10,kangrubu=@p11 where uye_id='"+id+"'";
            SqlCommand komut = new SqlCommand(kmt, sqlSinif.Baglanti_ac());
            komut.Parameters.AddWithValue("@p1", maskedTextBox_tcno.Text);
            komut.Parameters.AddWithValue("@p2", textBox_ad.Text);
            komut.Parameters.AddWithValue("@p3", textBox_soyad.Text);
            if (radioButton_erkek.Checked)
            {
                komut.Parameters.AddWithValue("@p4", "Erkek");
            }
            else
            {
                komut.Parameters.AddWithValue("@p4", "Kadın");
            }

            komut.Parameters.AddWithValue("@p5", maskedTextBox_dogumta.Text);
            komut.Parameters.AddWithValue("@p6", textBox_adres.Text);
            komut.Parameters.AddWithValue("@p7", comboBox_il.Text);
            komut.Parameters.AddWithValue("@p8", comboBox_ilce.Text);
            komut.Parameters.AddWithValue("@p9", maskedTextBox1_telefon.Text);
            komut.Parameters.AddWithValue("@p10", textBox_eposta.Text);
            komut.Parameters.AddWithValue("@p11", comboBox_kangrub.Text);

            komut.ExecuteNonQuery();

            sqlSinif.Close();
            MessageBox.Show("Kayıt Güncellendi");
        }
    }
}
