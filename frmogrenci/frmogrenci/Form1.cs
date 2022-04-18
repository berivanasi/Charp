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

namespace frmogrenci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //bağlantınız için yazıldı
        SqlConnection con;
        //tsql komutlarnı kullanmamıza olanak sağlar
        SqlCommand cmd;
        //doldurma işlemi
        SqlDataAdapter da;
        //çağırılan tablo ve bunların alanları
        DataSet ds;
        void vericek()
        {
            con = new SqlConnection("server=DESKTOP-VJBC22E;Initial Catalog=dbogrenci;Integrated Security =True");
            da = new SqlDataAdapter("Select * from ogrenci", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "ogrenci");
            dtg_ogrenci.DataSource = ds.Tables["ogrenci"];
            con.Close();
        }
        public string kadi;
        private void Form1_Load(object sender, EventArgs e)
        {
            vericek();
            label1.Text = kadi;
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
           //sql komutlaımı kullanabilmem için gerekli
            cmd = new SqlCommand();
            //bağlantımı açtım
            con.Open();
            cmd.Connection = con;
            //artık sıra veritabanıa bilgileri kaydetmeye geldi
            cmd.CommandText = "insert into ogrenci(ad,soyad,sehir) values ('"+ txt_ad.Text + "','" + txt_soyad.Text + "','" + txt_sehir.Text +"')";
            // derliyorum
            cmd.ExecuteNonQuery();
            //bağlantımı kapatıyorum
            con.Close();
            //metodun güncel halini getir
            vericek();
        }

        private void btn_güncell_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            //seçtiğim bir kritere göre verimi güncelleyeceğİm bu öğrenci numarası olsun
            cmd.CommandText = "update ogrenci set ad='" + txt_ad.Text + "', soyad='" + txt_soyad.Text + "', sehir='" + txt_sehir.Text + "' where ogrno='" + txt_numara.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            vericek();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "delete from ogrenci where ogrno=" + txt_numara.Text + "";
            cmd.ExecuteNonQuery();
            con.Close();
            vericek();
        }

        private void dtg_ogrenci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
