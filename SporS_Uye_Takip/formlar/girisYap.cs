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
    public partial class girisYap : Form
    {
        public girisYap()
        {
            InitializeComponent();
        }

        sqlSinif sqlSinif = new sqlSinif();





        private void girisYap_Load(object sender, EventArgs e)
        {

            string kmt = "select *from kapilar where durum='Aktif'";
            SqlCommand komut = new SqlCommand(kmt, sqlSinif.Baglanti_ac());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox_kapi.DataSource = dt;
            comboBox_kapi.ValueMember = "kapi_id";
            comboBox_kapi.DisplayMember = "ad";
        }
        public string giris;

        private void textBox_ara_TextChanged(object sender, EventArgs e)
        {
            
            string kmt;
            button_giris.Text = "Giriş/Çıkış Yap";
            if (textBox_ara.Text != "" && textBox_ara.Text != null)
            {
                try
                {
                    kmt = "select uye_id from uyeler where uye_id=@p1";
                    SqlCommand komut = new SqlCommand(kmt, sqlSinif.Baglanti_ac());
                    komut.Parameters.AddWithValue("@p1", textBox_ara.Text);
                    SqlDataReader da = komut.ExecuteReader();
                    if (da.Read())
                    {
                        sqlSinif.Close();
                        this.pictureBox_durum.Image = global::SporS_Uye_Takip.Properties.Resources.dogru;
                        try
                        {

                            kmt = "select * from girisler where uye_id=@p1";
                            SqlCommand komut2 = new SqlCommand(kmt, sqlSinif.Baglanti_ac());
                            komut2.Parameters.AddWithValue("@p1", textBox_ara.Text);
                            SqlDataReader da1 = komut2.ExecuteReader();
                            if (da1.Read())
                            {
                                sqlSinif.Close();
                                kmt = "select top 1 giris_cikis from girisler where uye_id= '" + textBox_ara.Text + "' order by id desc";
                                SqlCommand komut1 = new SqlCommand(kmt, sqlSinif.Baglanti_ac());
                                giris = komut1.ExecuteScalar().ToString();
                                sqlSinif.Close();
                                if (giris == "Giriş")
                                {
                                    giris = "Çıkış";
                                }
                                else
                                {
                                    giris = "Giriş";
                                }
                            }
                            else
                            {
                                giris = "Giriş";

                            }

                            button_giris.Text = giris + " Yap";
                        }
                        catch (Exception)
                        {

                        }

                    }
                    else
                    {
                        this.pictureBox_durum.Image = global::SporS_Uye_Takip.Properties.Resources.yanlis;
                    }
                    sqlSinif.Close();
                }
                catch (Exception)
                {
                    sqlSinif.Close();
                    MessageBox.Show("Sayı dışında birşey girmeyiniz");
                }
            }
            else
            {
                pictureBox_durum.Image = null;
            }
        }

        private void button_giris_Click(object sender, EventArgs e)
        {
            
                if (giris == "Giriş" || giris == "Çıkış")
                {
                    string kmt;
                    string tarih = DateTime.Now.ToString("dd.MM.yyyy");
                    string saat = DateTime.Now.ToString("HH:mm:ss");

                    if (comboBox_kapi.SelectedIndex != -1)
                    {
                        kmt = "insert into girisler(giris_cikis,tarih,saat,uye_id,kapi_id) values(@p1,@p2,@p3,@p4,@p5)";
                        SqlCommand komut2 = new SqlCommand(kmt, sqlSinif.Baglanti_ac());
                        komut2.Parameters.AddWithValue("@p1", giris);
                        komut2.Parameters.AddWithValue("@p2", tarih);
                        komut2.Parameters.AddWithValue("@p3", saat);
                        komut2.Parameters.AddWithValue("@p4", textBox_ara.Text);
                        komut2.Parameters.AddWithValue("@p5", comboBox_kapi.SelectedValue);
                        komut2.ExecuteNonQuery();
                        sqlSinif.Close();

                        kmt = "select ad ,soyad from uyeler where uye_id=@p1";
                        SqlCommand komut = new SqlCommand(kmt, sqlSinif.Baglanti_ac());
                        komut.Parameters.AddWithValue("@p1", textBox_ara.Text);
                        SqlDataReader dr = komut.ExecuteReader();
                        if (dr.Read())
                        {
                            label_ad.Text = "Ad: " + dr["ad"].ToString();
                            label_soyad.Text = "Soyad: " + dr["soyad"].ToString();
                            label_saat.Text = "Saat: " + saat;
                            label_tarih.Text = "Tarih: " + tarih;
                            label_giris.Text = giris + " Yapıldı";
                        }
                        sqlSinif.Close();
                    string deger = textBox_ara.Text;
                    if (deger == "")
                    { 
                    }
                    else
                    {
                        textBox_ara.Text = "";
                        textBox_ara.Text = deger.ToString();
                        
                    } 
                    }

                }
            
        }

       
    }
}