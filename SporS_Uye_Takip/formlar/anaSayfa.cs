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
    public partial class anaSayfa : Form
    {
        public anaSayfa()
        {
            InitializeComponent();
        }
        girisYap girisYap = new girisYap();
        public void veriListele(string komut)//veri listeler
        {
            SqlDataAdapter da = new SqlDataAdapter(komut, sqlSinif.Baglanti_ac());
            DataTable dt = new DataTable();
            da.Fill(dt);
            veriListesi.DataSource = dt;
            veriListesi.Columns[0].HeaderCell.Value = "İd";
            veriListesi.Columns[1].HeaderCell.Value = "Tc No";
            veriListesi.Columns[2].HeaderCell.Value = "Adı";
            veriListesi.Columns[3].HeaderCell.Value = "Soyadı";
            veriListesi.Columns[4].HeaderCell.Value = "Cinsiyeti";
            veriListesi.Columns[5].HeaderCell.Value = "İl";
            veriListesi.Columns[6].HeaderCell.Value = "İlce";
        }
        private void anaSayfa_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        sqlSinif sqlSinif = new sqlSinif();
        private void anaSayfa_Load(object sender, EventArgs e)
        {
          
            girisYap.Show();
            girisYap.Location = new Point(this.Right - 10, this.Top);
            string kmt = "select uye_id,tcno,ad,soyad,cinsiyet,il,ilce from uyeler";
            veriListele(kmt);
        }

        private void label_kullanıcı_Click(object sender, EventArgs e)
        {

        }

        private void textBox_ara_TextChanged(object sender, EventArgs e)
        {
            string kmt = "select  uye_id,tcno,ad,soyad,cinsiyet,il,ilce  from uyeler where ad Like '%" + textBox_ara.Text + "%'" ;
            veriListele(kmt);

        }

        private void button_ekle_Click(object sender, EventArgs e)
        {
            uyeEkle uyeEkle = new uyeEkle();
            uyeEkle.ShowDialog();
            string kmt = "select uye_id,tcno,ad,soyad,cinsiyet,il,ilce from uyeler";
            veriListele(kmt);
        }

        private void button_girisler_Click(object sender, EventArgs e)
        {
            uyeGirisCikis uyeGirisCikis = new uyeGirisCikis();
            uyeGirisCikis.ShowDialog();
        }

        private void veriListesi_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            int deger1 = 376;
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

        private void button_kullanicilar_Click(object sender, EventArgs e)
        {
            kullanicilar kullanicilar = new kullanicilar();
            kullanicilar.ShowDialog();
        }

        private void button_kapilar_Click(object sender, EventArgs e)
        {     
           
            kapilar kapilar = new kapilar();
            kapilar.ShowDialog();
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (girisYap.Visible==true)
            {

            }
            else
            {
                girisYap girisYap = new girisYap();
                girisYap.Show();
                girisYap.Location = new Point(this.Right - 10, this.Top);
                
            }
           
           
        }

        private void button_sil_Click(object sender, EventArgs e)
        {
            if (veriListesi.SelectedRows.Count > 0)
            {
                string kmt = "delete uyeler where uye_id='" + veriListesi.CurrentRow.Cells[0].Value.ToString() + "'";
                SqlCommand komut = new SqlCommand(kmt, sqlSinif.Baglanti_ac());
                komut.ExecuteNonQuery();
                sqlSinif.Close();
                veriListesi.Rows.RemoveAt(veriListesi.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Seçim Yapınız");
            }
        }

        private void button_guncelle_Click(object sender, EventArgs e)
        {
            uyeGuncelle uyeGuncelle = new uyeGuncelle();
            uyeGuncelle.id= Convert.ToInt32(veriListesi.CurrentRow.Cells[0].Value);
            uyeGuncelle.ShowDialog();
            string kmt = "select uye_id,tcno,ad,soyad,cinsiyet,il,ilce from uyeler";
            veriListele(kmt);
        }

        private void veriListesi_DoubleClick(object sender, EventArgs e)
        {
            uyeGuncelle uyeGuncelle = new uyeGuncelle();
            uyeGuncelle.id = Convert.ToInt32(veriListesi.CurrentRow.Cells[0].Value);
            uyeGuncelle.ShowDialog();
        }

        private void button_yenile_Click(object sender, EventArgs e)
        {

        }
    }
}