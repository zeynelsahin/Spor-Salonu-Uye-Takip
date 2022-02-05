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
    public partial class uyeGirisCikis : Form
    {
        public uyeGirisCikis()
        {
            InitializeComponent();
        }
        sqlSinif sqlSinif = new sqlSinif();
        public void veriListele(string komut)//veri listeler
        {
            SqlDataAdapter da = new SqlDataAdapter(komut, sqlSinif.Baglanti_ac());
            DataTable dt = new DataTable();
            da.Fill(dt);
            veriListesi.DataSource = dt;
        }
        private string kmt = "select girisler.uye_id, uyeler.ad ,uyeler.soyad,giris_cikis,tarih,saat,kapilar.ad from girisler inner join kapilar  ON girisler.kapi_id=kapilar.kapi_id inner join uyeler on  uyeler.uye_id=girisler.uye_id ";
        private void uyeGirisCikis_Load(object sender, EventArgs e)
        {
            comboBox_aramatip.SelectedIndex = 0;
            comboBox_aramatip.Top = 88;
            comboBox_sırala.SelectedIndex = 0;
            radioButton_giriscikis.Checked = false;
            radioButton_giriscikis.Checked = true;
            if (radioButton_giriscikis.Checked)
            {
                if (comboBox_aramatip.SelectedIndex == 0)
                {
                    verilerHepsi(kmt);
                }
            }
        }
        void verilerHepsi(string kmt)
        {
            veriListele(kmt);
            veriListesi.Columns[0].HeaderCell.Value = "Üye İd";
            veriListesi.Columns[1].HeaderCell.Value = "Adı";
            veriListesi.Columns[2].HeaderCell.Value = "Soyadı";
            veriListesi.Columns[3].HeaderCell.Value = "Giriş/Çıkış";
            veriListesi.Columns[4].HeaderCell.Value = "Tarih";
            veriListesi.Columns[5].HeaderCell.Value = "Saat";
            veriListesi.Columns[6].HeaderCell.Value = "Kapi Adı";
        }

        void adSoyadKapidTum()
        {
            string kmt = "select girisler.uye_id, uyeler.ad ,uyeler.soyad,giris_cikis,tarih,saat,kapilar.ad from girisler inner join kapilar  ON girisler.kapi_id=kapilar.kapi_id inner join uyeler on  uyeler.uye_id=girisler.uye_id ";

            if (comboBox_aramatip.SelectedIndex == 1)
            {
                if (radioButton_giris.Checked)
                {
                    kmt += " where uyeler.ad Like '%" + textBox_ara.Text + "%' and  girisler.giris_cikis = 'Giriş'";
                }
                else if (radioButton_cikis.Checked)
                {
                    kmt += " where uyeler.ad Like '%" + textBox_ara.Text + "%' and  girisler.giris_cikis = 'Çıkış'";
                }
                else
                {
                    kmt += " where uyeler.ad Like '%" + textBox_ara.Text + "%'";
                }

            }
            else if (comboBox_aramatip.SelectedIndex == 2)
            {
                if (radioButton_giris.Checked)
                {
                    kmt += " where uyeler.uye_id like '" + textBox_ara.Text + "' and  girisler.giris_cikis = 'Giriş'";
                }
                else if (radioButton_cikis.Checked)
                {
                    kmt += " where uyeler.uye_id like'" + textBox_ara.Text + "' and  girisler.giris_cikis = 'Çıkış'";
                }
                else
                {
                    kmt += " where uyeler.uye_id like '%" + textBox_ara.Text + "%'";
                }

            }
            else if (comboBox_aramatip.SelectedIndex == 3)
            {
                if (radioButton_giris.Checked)
                {
                    kmt += " where uyeler.soyad Like '%" + textBox_ara.Text + "%' and  girisler.giris_cikis = 'Giriş'";
                }
                else if (radioButton_cikis.Checked)
                {
                    kmt += " where uyeler.soyad Like '%" + textBox_ara.Text + "%' and  girisler.giris_cikis = 'Çıkış'";
                }
                else
                {
                    kmt += " where uyeler.soyad Like '%" + textBox_ara.Text + "%'";
                }
            }
            else if (comboBox_aramatip.SelectedIndex == 4)
            {
                if (radioButton_giris.Checked)
                {
                    kmt += " where kapilar.ad Like '%" + textBox_ara.Text + "%' and  girisler.giris_cikis = 'Giriş'";
                }
                else if (radioButton_cikis.Checked)
                {
                    kmt += " where kapilar.ad  Like '%" + textBox_ara.Text + "%' and  girisler.giris_cikis = 'Çıkış'";
                }
                else
                {
                    kmt += " where kapilar.ad Like '%" + textBox_ara.Text + "%'";
                }
            }
            else
            {

            }

            verilerHepsi(kmt);
        }
        private void textBox_ara_TextChanged(object sender, EventArgs e)
        {
            adSoyadKapidTum();
        }

        private void radioButton_giriscikis_CheckedChanged(object sender, EventArgs e)
        {
            if (maskedTextBox.Visible == true)
            {
                if (maskedTextBox.Mask=="00:00:00")
                {
                    saat();
                }
                else
                {
                    tarih();
                }
            }
            else if (textBox_ara.Visible == true)
            {
                adSoyadKapidTum();
            }
            else { verilerHepsi(kmt); }
        }

        private void radioButton_giris_CheckedChanged(object sender, EventArgs e)
        {
            if (maskedTextBox.Visible == true)
            {
                if (maskedTextBox.Mask == "00:00:00")
                {
                    saat();
                }
                else
                {
                    tarih();
                }
            }
            else if (textBox_ara.Visible == true)
            {
                adSoyadKapidTum();
            }
            else
            {
                string kmt = "select girisler.uye_id, uyeler.ad ,uyeler.soyad,giris_cikis,tarih,saat,kapilar.ad from girisler inner join kapilar  ON girisler.kapi_id=kapilar.kapi_id inner join uyeler on  uyeler.uye_id=girisler.uye_id where girisler.giris_cikis = 'Giriş'"; 
                verilerHepsi(kmt);
            }
        }

        private void radioButton_cikis_CheckedChanged(object sender, EventArgs e)
        {
            if (maskedTextBox.Visible == true)
            {
                if (maskedTextBox.Mask == "00:00:00")
                {
                    saat();
                }
                else
                {
                    tarih();
                }
            }
            else if (textBox_ara.Visible == true)
            {
                adSoyadKapidTum();
            }
            else
            {
                string kmt = "select girisler.uye_id, uyeler.ad ,uyeler.soyad,giris_cikis,tarih,saat,kapilar.ad from girisler inner join kapilar  ON girisler.kapi_id=kapilar.kapi_id inner join uyeler on  uyeler.uye_id=girisler.uye_id where girisler.giris_cikis ='Çıkış'";
                verilerHepsi(kmt);
            }
        }

        private void veriListesi_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            int height = 41;
            int deger1 = panel_sunum.Height - 16;
      
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
        void tarih()
        {
            string kmt = "select girisler.uye_id, uyeler.ad ,uyeler.soyad,giris_cikis,tarih,saat,kapilar.ad from girisler inner join kapilar  ON girisler.kapi_id=kapilar.kapi_id inner join uyeler on  uyeler.uye_id=girisler.uye_id ";
            if (comboBox_aramatip.SelectedIndex == 5)
            {
                if (comboBox_sırala.SelectedIndex == 0)
                {
                    if (radioButton_giris.Checked)
                    {
                        kmt += " where girisler.tarih >=CONVERT(nchar,'" + maskedTextBox.Text + "',104)   and  girisler.giris_cikis = 'Giriş'";
                    }
                    else if (radioButton_cikis.Checked)
                    {
                        kmt += " where girisler.tarih >=CONVERT(nchar,'" + maskedTextBox.Text + "',104)and girisler.giris_cikis = 'Çıkış'";
                    }
                    else
                    {
                        kmt += " where girisler.tarih >=CONVERT(nchar,'" + maskedTextBox.Text + "',104)";
                    }
                }
                else if (comboBox_sırala.SelectedIndex == 1)
                {
                    if (radioButton_giris.Checked)
                    {
                        kmt += " where girisler.tarih <= CONVERT(nchar,'" + maskedTextBox.Text + "',104) and  girisler.giris_cikis = 'Giriş'";
                    }
                    else if (radioButton_cikis.Checked)
                    {
                        kmt += " where girisler.tarih <=CONVERT(nchar,'" + maskedTextBox.Text + "',104)and  girisler.giris_cikis = 'Çıkış'";
                    }
                    else
                    {
                        kmt += " where girisler.tarih <=CONVERT(nchar,'" + maskedTextBox.Text + "',104)";
                    }
                }
                else if (comboBox_sırala.SelectedIndex == 2)
                {
                    if (radioButton_giris.Checked)
                    {
                        kmt += " where girisler.tarih =CONVERT(nchar,'" + maskedTextBox.Text + "',104) and  girisler.giris_cikis = 'Giriş'";
                    }
                    else if (radioButton_cikis.Checked)
                    {
                        kmt += " where girisler.tarih =CONVERT(nchar,'" + maskedTextBox.Text + "',104)and  girisler.giris_cikis = 'Çıkış'";
                    }
                    else
                    {
                        kmt += " where girisler.tarih =CONVERT(nchar,'" + maskedTextBox.Text + "',104)";
                    }
                }
                else
                {
                    MessageBox.Show("Listeden Seçiniz");
                }
            }
            verilerHepsi(kmt);
        }
        void saat()
        {
            string kmt = "select girisler.uye_id, uyeler.ad ,uyeler.soyad,giris_cikis,tarih,saat,kapilar.ad from girisler inner join kapilar  ON girisler.kapi_id=kapilar.kapi_id inner join uyeler on  uyeler.uye_id=girisler.uye_id ";
            if (comboBox_aramatip.SelectedIndex == 6)
            {
                if (comboBox_sırala.SelectedIndex == 0)
                {
                    if (radioButton_giris.Checked)
                    {
                        kmt += " where girisler.saat >= '" + maskedTextBox.Text + "'  and  girisler.giris_cikis = 'Giriş'";
                    }
                    else if (radioButton_cikis.Checked)
                    {
                        kmt += " where girisler.saat >='" + maskedTextBox.Text + "'and  girisler.giris_cikis = 'Çıkış'";
                    }
                    else
                    {
                        kmt += " where girisler.saat >='" + maskedTextBox.Text + "'";
                    }
                }
                else if (comboBox_sırala.SelectedIndex == 1)
                {
                    if (radioButton_giris.Checked)
                    {
                        kmt += " where girisler.saat <= '" + maskedTextBox.Text + "'  and  girisler.giris_cikis = 'Giriş'";
                    }
                    else if (radioButton_cikis.Checked)
                    {
                        kmt += " where girisler.saat <='" + maskedTextBox.Text + "'and  girisler.giris_cikis = 'Çıkış'";
                    }
                    else
                    {
                        kmt += " where girisler.saat <='" + maskedTextBox.Text + "'";
                    }
                }
                else if (comboBox_sırala.SelectedIndex == 2)
                {
                    if (radioButton_giris.Checked)
                    {
                        kmt += " where girisler.saat = '" + maskedTextBox.Text + "'  and  girisler.giris_cikis = 'Giriş'";
                    }
                    else if (radioButton_cikis.Checked)
                    {
                        kmt += " where girisler.saat ='" + maskedTextBox.Text + "'and  girisler.giris_cikis = 'Çıkış'";
                    }
                    else
                    {
                        kmt += " where girisler.saat ='" + maskedTextBox.Text + "'";
                    }
                }
                else
                {
                    MessageBox.Show("Listeden Seçiniz");
                }

            }
            verilerHepsi(kmt);
        }
        private void maskedTextBox_TextChanged(object sender, EventArgs e)
        {
            if (maskedTextBox.Mask == "00:00:00")
            {
                if (maskedTextBox.Text.Length == 8)
                {
                    saat();
                }
            }
            else
            {
                tarih();
            }
            
        }

        private void comboBox_aramatip_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_aramatip.SelectedIndex != 0)
            {
                comboBox_aramatip.Top = 30;
                if (comboBox_aramatip.SelectedIndex == 0)
                {
                   verilerHepsi(kmt);
                }
                else if (comboBox_aramatip.SelectedIndex == 5)
                {
                    maskedTextBox.Mask = "00/00/0000";
                    label_sırala.Show();
                    comboBox_sırala.Show();
                    textBox_ara.Hide();
                    maskedTextBox.Show();
                }
                else if (comboBox_aramatip.SelectedIndex == 6)
                {
                    maskedTextBox.Mask = "00:00:00";
                    label_sırala.Show();
                    comboBox_sırala.Show();
                    textBox_ara.Hide();
                    maskedTextBox.Show();
                    

                }
                else
                {
                    maskedTextBox.Hide();
                    label_sırala.Hide();
                    comboBox_sırala.Hide();
                    label_ara.Show();
                    textBox_ara.Show();
                    textBox_ara.Focus();
                    adSoyadKapidTum();

                }
            }
            else
            {

                comboBox_aramatip.Top = 88;
                label_ara.Hide();
                textBox_ara.Hide();

            }
        }
        private void maskedTextBox_Leave(object sender, EventArgs e)
        {
            if (maskedTextBox.Mask == "00:00:00")
            {
                saat();
            }
            else
            {
                tarih();
            }
        }

        private void comboBox_sırala_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (maskedTextBox.Mask == "00:00:00")
            {
                if (maskedTextBox.Text.Length==8)
                {
                    saat();
                }
            }
            else
            {
                tarih();
            }
            
        }

        private void veriListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void uyeGirisCikis_Resize(object sender, EventArgs e)
        {
            int height = 41;
            int deger1 = panel_sunum.Height - 16;

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

        }
    }
}
    

