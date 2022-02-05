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
    public partial class kapilar : Form
    {
        public kapilar()
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
            veriListesi.Columns[1].HeaderCell.Value = "Ad";
            veriListesi.Columns[2].HeaderCell.Value = "Durum";
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

        private void textBox_ara_TextChanged(object sender, EventArgs e)
        {
            string kmt = "select *from kapilar where ad Like '%" + textBox_ara.Text + "%'";
            veriListele(kmt);
        }

        private void button_yenile_Click(object sender, EventArgs e)
        {
            string kmt = "select *from kapilar";
            veriListele(kmt);
        }

        private void kapilar_Load(object sender, EventArgs e)
        {
            string kmt = "select *from kapilar";
            veriListele(kmt);
        }

        private void button_ekle_Click(object sender, EventArgs e)
        {
            kapiEkle kapiEkle = new kapiEkle();
            kapiEkle.ShowDialog();
            string kmt = "select *from kapilar";
            veriListele(kmt);
        }

        private void button_sil_Click(object sender, EventArgs e)
        {
            if (veriListesi.SelectedRows.Count > 0)
            {
                string kmt = "delete kapilar where kapi_id='" + veriListesi.CurrentRow.Cells[0].Value.ToString() + "'";
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
           
            kapiGuncelle kapiGuncelle = new kapiGuncelle();
            kapiGuncelle.id= Convert.ToInt32(veriListesi.CurrentRow.Cells[0].Value);
            kapiGuncelle.ad= veriListesi.CurrentRow.Cells[1].Value.ToString();
            kapiGuncelle.durum=veriListesi.CurrentRow.Cells[2].Value.ToString();
            kapiGuncelle.ShowDialog();

            string kmt = "select *from kapilar";
            veriListele(kmt);
        }

        private void veriListesi_DoubleClick(object sender, EventArgs e)
        {
            kapiGuncelle kapiGuncelle = new kapiGuncelle();
            kapiGuncelle.id = Convert.ToInt32(veriListesi.CurrentRow.Cells[0].Value);
            kapiGuncelle.ad = veriListesi.CurrentRow.Cells[1].Value.ToString();
            kapiGuncelle.durum = veriListesi.CurrentRow.Cells[2].Value.ToString();
            kapiGuncelle.ShowDialog();

            string kmt = "select *from kapilar";
            veriListele(kmt);
        }
    }
}
