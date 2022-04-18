using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace frmogrenci
{
   
    public partial class FrmLogin : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btn_giri_Click(object sender, EventArgs e)
        {
            string sorgu = "Select * from giris where kullanici_ad=@user And sifre=@psw";
            con = new SqlConnection("server=DESKTOP-VJBC22E;Initial Catalog=dblogin;Integrated Security= True");
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@user", textBox1.Text);
            cmd.Parameters.AddWithValue("@psw", textBox2.Text);
            con.Open();
            dr = cmd.ExecuteReader();
            if(dr.Read())
            {
               
                Form1 frm = new Form1();
                frm.kadi = "Hoşgeldiniz"+ textBox1.Text;
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Kullanıcı ADI veya Şifre Hatalı");
            }
        }
    }
}
