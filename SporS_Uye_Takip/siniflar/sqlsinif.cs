using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SporS_Uye_Takip.siniflar
{
    class sqlSinif
    {
        public SqlConnection bag = new SqlConnection(@"Data Source=LAPTOP-KV96ISUM;Initial Catalog=SporS_Uye_Takip;Integrated Security=true");
        public SqlConnection Baglanti_ac()//baglantıyı açar
        {
            if (bag.State != System.Data.ConnectionState.Open)
            {
                try
                {
                    bag.Open();
                }
                catch
                {
                    MessageBox.Show("Bağlantı Kurulamadı", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            return bag;
        }
        public void Close()
        {
            bag.Close();
        }

    }
}
