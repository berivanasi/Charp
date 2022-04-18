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
    public partial class Frmyazi_rengi : Form
    {
        public Frmyazi_rengi()
        {
            InitializeComponent();
        }

        private void Frmyazi_rengi_Load(object sender, EventArgs e)
        {

        }

        private void lbl_rengi_Click(object sender, EventArgs e)
        {

        }

        private void btn_uygula_Click(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Kırmızı":lbl_rengi.ForeColor = Color.Red;break;
                case "Sarı": lbl_rengi.ForeColor = Color.Yellow;break;
                case "Siyah":lbl_rengi.ForeColor = Color.Black;break;
                   
            }
        }
    }
}
