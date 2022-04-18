
namespace frmogrenci
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_Ad = new System.Windows.Forms.Label();
            this.Lbl_soyad = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_giri = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(233, 142);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(127, 23);
            this.textBox1.TabIndex = 0;
            // 
            // lbl_Ad
            // 
            this.lbl_Ad.AutoSize = true;
            this.lbl_Ad.Location = new System.Drawing.Point(111, 142);
            this.lbl_Ad.Name = "lbl_Ad";
            this.lbl_Ad.Size = new System.Drawing.Size(87, 15);
            this.lbl_Ad.TabIndex = 1;
            this.lbl_Ad.Text = "KULLANICI ADI";
            // 
            // Lbl_soyad
            // 
            this.Lbl_soyad.AutoSize = true;
            this.Lbl_soyad.Location = new System.Drawing.Point(111, 174);
            this.Lbl_soyad.Name = "Lbl_soyad";
            this.Lbl_soyad.Size = new System.Drawing.Size(35, 15);
            this.Lbl_soyad.TabIndex = 2;
            this.Lbl_soyad.Text = "ŞİFRE";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(244, 184);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 3;
            // 
            // btn_giri
            // 
            this.btn_giri.Location = new System.Drawing.Point(182, 249);
            this.btn_giri.Name = "btn_giri";
            this.btn_giri.Size = new System.Drawing.Size(117, 35);
            this.btn_giri.TabIndex = 4;
            this.btn_giri.Text = "GİRİŞ";
            this.btn_giri.UseVisualStyleBackColor = true;
            this.btn_giri.Click += new System.EventHandler(this.btn_giri_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(109, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(465, 364);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_giri);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Lbl_soyad);
            this.Controls.Add(this.lbl_Ad);
            this.Controls.Add(this.textBox1);
            this.Name = "FrmLogin";
            this.Text = "FrmLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_Ad;
        private System.Windows.Forms.Label Lbl_soyad;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_giri;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}