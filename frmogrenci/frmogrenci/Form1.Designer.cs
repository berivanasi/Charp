
namespace frmogrenci
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_güncell = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.lbl_numara = new System.Windows.Forms.Label();
            this.lbl_ad = new System.Windows.Forms.Label();
            this.lbl_soyad = new System.Windows.Forms.Label();
            this.lbl_şehir = new System.Windows.Forms.Label();
            this.txt_numara = new System.Windows.Forms.TextBox();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.txt_sehir = new System.Windows.Forms.TextBox();
            this.dtg_ogrenci = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ogrenci)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ekle
            // 
            this.btn_ekle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ekle.Location = new System.Drawing.Point(143, 214);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(110, 23);
            this.btn_ekle.TabIndex = 0;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_güncell
            // 
            this.btn_güncell.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_güncell.Location = new System.Drawing.Point(143, 254);
            this.btn_güncell.Name = "btn_güncell";
            this.btn_güncell.Size = new System.Drawing.Size(110, 23);
            this.btn_güncell.TabIndex = 1;
            this.btn_güncell.Text = "Güncelle";
            this.btn_güncell.UseVisualStyleBackColor = true;
            this.btn_güncell.Click += new System.EventHandler(this.btn_güncell_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_sil.Location = new System.Drawing.Point(143, 294);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(110, 23);
            this.btn_sil.TabIndex = 2;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // lbl_numara
            // 
            this.lbl_numara.AutoSize = true;
            this.lbl_numara.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_numara.Location = new System.Drawing.Point(444, 214);
            this.lbl_numara.Name = "lbl_numara";
            this.lbl_numara.Size = new System.Drawing.Size(55, 17);
            this.lbl_numara.TabIndex = 3;
            this.lbl_numara.Text = "Numara";
            // 
            // lbl_ad
            // 
            this.lbl_ad.AutoSize = true;
            this.lbl_ad.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ad.Location = new System.Drawing.Point(452, 241);
            this.lbl_ad.Name = "lbl_ad";
            this.lbl_ad.Size = new System.Drawing.Size(24, 17);
            this.lbl_ad.TabIndex = 4;
            this.lbl_ad.Text = "Ad";
            // 
            // lbl_soyad
            // 
            this.lbl_soyad.AutoSize = true;
            this.lbl_soyad.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_soyad.Location = new System.Drawing.Point(455, 262);
            this.lbl_soyad.Name = "lbl_soyad";
            this.lbl_soyad.Size = new System.Drawing.Size(44, 17);
            this.lbl_soyad.TabIndex = 5;
            this.lbl_soyad.Text = "Soyad";
            // 
            // lbl_şehir
            // 
            this.lbl_şehir.AutoSize = true;
            this.lbl_şehir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_şehir.Location = new System.Drawing.Point(456, 294);
            this.lbl_şehir.Name = "lbl_şehir";
            this.lbl_şehir.Size = new System.Drawing.Size(37, 17);
            this.lbl_şehir.TabIndex = 6;
            this.lbl_şehir.Text = "Şehir";
            // 
            // txt_numara
            // 
            this.txt_numara.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_numara.Location = new System.Drawing.Point(503, 208);
            this.txt_numara.Name = "txt_numara";
            this.txt_numara.Size = new System.Drawing.Size(135, 25);
            this.txt_numara.TabIndex = 7;
            // 
            // txt_ad
            // 
            this.txt_ad.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_ad.Location = new System.Drawing.Point(503, 238);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(135, 25);
            this.txt_ad.TabIndex = 8;
            // 
            // txt_soyad
            // 
            this.txt_soyad.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_soyad.Location = new System.Drawing.Point(503, 267);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(135, 25);
            this.txt_soyad.TabIndex = 9;
            // 
            // txt_sehir
            // 
            this.txt_sehir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_sehir.Location = new System.Drawing.Point(503, 296);
            this.txt_sehir.Name = "txt_sehir";
            this.txt_sehir.Size = new System.Drawing.Size(135, 25);
            this.txt_sehir.TabIndex = 10;
            // 
            // dtg_ogrenci
            // 
            this.dtg_ogrenci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_ogrenci.Location = new System.Drawing.Point(54, 57);
            this.dtg_ogrenci.Name = "dtg_ogrenci";
            this.dtg_ogrenci.RowTemplate.Height = 25;
            this.dtg_ogrenci.Size = new System.Drawing.Size(575, 130);
            this.dtg_ogrenci.TabIndex = 11;
            this.dtg_ogrenci.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_ogrenci_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(812, 378);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtg_ogrenci);
            this.Controls.Add(this.txt_sehir);
            this.Controls.Add(this.txt_soyad);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.txt_numara);
            this.Controls.Add(this.lbl_şehir);
            this.Controls.Add(this.lbl_soyad);
            this.Controls.Add(this.lbl_ad);
            this.Controls.Add(this.lbl_numara);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_güncell);
            this.Controls.Add(this.btn_ekle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ogrenci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_güncell;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Label lbl_numara;
        private System.Windows.Forms.Label lbl_ad;
        private System.Windows.Forms.Label lbl_soyad;
        private System.Windows.Forms.Label lbl_şehir;
        private System.Windows.Forms.TextBox txt_numara;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.TextBox txt_sehir;
        private System.Windows.Forms.DataGridView dtg_ogrenci;
        private System.Windows.Forms.Label label1;
    }
}

