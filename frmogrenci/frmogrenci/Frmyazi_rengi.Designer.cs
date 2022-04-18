
namespace frmogrenci
{
    partial class Frmyazi_rengi
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbl_rengi = new System.Windows.Forms.Label();
            this.btn_uygula = new System.Windows.Forms.Button();
            this.lbl_renkdesm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Kırmızı",
            "Sarı",
            "Siyah",
            "Turuncu"});
            this.comboBox1.Location = new System.Drawing.Point(50, 68);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 0;
            // 
            // lbl_rengi
            // 
            this.lbl_rengi.AutoSize = true;
            this.lbl_rengi.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_rengi.Location = new System.Drawing.Point(71, 37);
            this.lbl_rengi.Name = "lbl_rengi";
            this.lbl_rengi.Size = new System.Drawing.Size(77, 20);
            this.lbl_rengi.TabIndex = 1;
            this.lbl_rengi.Text = "Yazı Rengi";
            this.lbl_rengi.Click += new System.EventHandler(this.lbl_rengi_Click);
            // 
            // btn_uygula
            // 
            this.btn_uygula.Location = new System.Drawing.Point(199, 67);
            this.btn_uygula.Name = "btn_uygula";
            this.btn_uygula.Size = new System.Drawing.Size(75, 23);
            this.btn_uygula.TabIndex = 2;
            this.btn_uygula.Text = "Uygula";
            this.btn_uygula.UseVisualStyleBackColor = true;
            this.btn_uygula.Click += new System.EventHandler(this.btn_uygula_Click);
            // 
            // lbl_renkdesm
            // 
            this.lbl_renkdesm.AutoSize = true;
            this.lbl_renkdesm.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_renkdesm.Location = new System.Drawing.Point(38, 110);
            this.lbl_renkdesm.Name = "lbl_renkdesm";
            this.lbl_renkdesm.Size = new System.Drawing.Size(259, 17);
            this.lbl_renkdesm.TabIndex = 3;
            this.lbl_renkdesm.Text = "MERHABA BU BİR RENK DEĞİŞİM ALANIDIR";
            // 
            // Frmyazi_rengi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(331, 210);
            this.Controls.Add(this.lbl_renkdesm);
            this.Controls.Add(this.btn_uygula);
            this.Controls.Add(this.lbl_rengi);
            this.Controls.Add(this.comboBox1);
            this.Name = "Frmyazi_rengi";
            this.Text = "Frmyazi_rengi";
            this.Load += new System.EventHandler(this.Frmyazi_rengi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbl_rengi;
        private System.Windows.Forms.Button btn_uygula;
        private System.Windows.Forms.Label lbl_renkdesm;
    }
}