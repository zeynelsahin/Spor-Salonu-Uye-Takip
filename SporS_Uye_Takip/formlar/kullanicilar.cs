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
    public partial class kullanicilar : Form
    {
        public kullanicilar()
        {
            InitializeComponent();
        }
        sqlSinif sqlSinif = new sqlSinif();

        public void veriListele(string komut)
        {
            SqlDataAdapter da = new SqlDataAdapter(komut, sqlSinif.Baglanti_ac());
            DataTable dt = new DataTable();
            da.Fill(dt);
            veriListesi.DataSource = dt;
            veriListesi.DataSource = dt;
            veriListesi.Columns[0].HeaderCell.Value = "İd";
            veriListesi.Columns[1].HeaderCell.Value = "Adı";
            veriListesi.Columns[2].HeaderCell.Value = "Soyadı";
            veriListesi.Columns[3].HeaderCell.Value = "Kullanıcı Adı";
            veriListesi.Columns[4].HeaderCell.Value = "Şifre";
        }

        private void kullanicilar_Load(object sender, EventArgs e)
        {
            string kmt = "select kullanici_id,ad,soyad,kullanici_adi,sifre from kullanicilar";
            veriListele(kmt);
        }

        private void textBox_ara_TextChanged(object sender, EventArgs e)
        {
            string kmt = "select *from kullanicilar where ad Like '%" + textBox_ara.Text + "%'";
            veriListele(kmt);
        }

        private void button_yenile_Click(object sender, EventArgs e)
        {
            string kmt = "select * from kullanicilar";
            veriListele(kmt);
        }

        private void button_ekle_Click(object sender, EventArgs e)
        {
            kullaniciEkle kullaniciEkle = new kullaniciEkle();
            kullaniciEkle.ShowDialog();
            string kmt = "select kullanici_id,ad,soyad,kullanici_adi,sifre from kullanicilar";
            veriListele(kmt);
        }

        private void button_sil_Click(object sender, EventArgs e)
        {
            string kmt= "delete kullanicilar where kullanici_id='"+veriListesi.CurrentRow.Cells[0].Value.ToString()+"'";
            SqlCommand komut = new SqlCommand(kmt, sqlSinif.Baglanti_ac());
            komut.ExecuteNonQuery();
            sqlSinif.Close();
           veriListesi.Rows.RemoveAt(veriListesi.SelectedRows[0].Index);
        }
        
        private void button_guncelle_Click(object sender, EventArgs e)
        {
            kullanicİGuncelle kullanicİGuncelle = new kullanicİGuncelle();
            kullanicİGuncelle.id  = Convert.ToInt32(veriListesi.CurrentRow.Cells[0].Value);
            kullanicİGuncelle.ad = veriListesi.CurrentRow.Cells[1].Value.ToString();
            kullanicİGuncelle.soyad = veriListesi.CurrentRow.Cells[2].Value.ToString();
            kullanicİGuncelle.kullanici_adi = veriListesi.CurrentRow.Cells[3].Value.ToString();
            kullanicİGuncelle.sifre = veriListesi.CurrentRow.Cells[4].Value.ToString();
            kullanicİGuncelle.ShowDialog();

            string kmt = "select kullanici_id,ad,soyad,kullanici_adi,sifre from kullanicilar";
            veriListele(kmt);
        }

        private void veriListesi_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            int deger1 = 402;
            int height = 41;
            foreach (DataGridViewRow dr in veriListesi.Rows)
            {
                height += dr.Height;
            }
            if (height > deger1)
            {
                veriListesi.Height = deger1;
            }
            else
            {
                veriListesi.Height = height;
            }
            label_adet.Top = veriListesi.Bottom + 10;

            if (veriListesi.Rows.Count > 0)
            {
                label_adet.Text = veriListesi.Rows.Count.ToString() + " adet kayıt listelendi.";
            }
            else
            {
                label_adet.Text = "Hiç kayıt bulunamadı.";
            }
        }

        private void veriListesi_DoubleClick(object sender, EventArgs e)
        {
            kullanicİGuncelle kullanicİGuncelle = new kullanicİGuncelle();
            kullanicİGuncelle.id = Convert.ToInt32(veriListesi.CurrentRow.Cells[0].Value);
            kullanicİGuncelle.ad = veriListesi.CurrentRow.Cells[1].Value.ToString();
            kullanicİGuncelle.soyad = veriListesi.CurrentRow.Cells[2].Value.ToString();
            kullanicİGuncelle.kullanici_adi = veriListesi.CurrentRow.Cells[3].Value.ToString();
            kullanicİGuncelle.sifre = veriListesi.CurrentRow.Cells[4].Value.ToString();
            kullanicİGuncelle.ShowDialog();

            string kmt = "select kullanici_id,ad,soyad,kullanici_adi,sifre from kullanicilar";
            veriListele(kmt);
        }
    }
}
