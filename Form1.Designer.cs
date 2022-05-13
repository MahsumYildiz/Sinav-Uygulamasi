
namespace WindowsFormsApp72
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_Ogrenci = new System.Windows.Forms.Button();
            this.Btn_SınavS = new System.Windows.Forms.Button();
            this.Btn_Admin = new System.Windows.Forms.Button();
            this.Btn_Kayit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Ogrenci
            // 
            this.Btn_Ogrenci.Location = new System.Drawing.Point(90, 217);
            this.Btn_Ogrenci.Name = "Btn_Ogrenci";
            this.Btn_Ogrenci.Size = new System.Drawing.Size(122, 45);
            this.Btn_Ogrenci.TabIndex = 0;
            this.Btn_Ogrenci.Text = "Öğrenci";
            this.Btn_Ogrenci.UseVisualStyleBackColor = true;
            this.Btn_Ogrenci.Click += new System.EventHandler(this.Btn_Ogrenci_Click);
            // 
            // Btn_SınavS
            // 
            this.Btn_SınavS.Location = new System.Drawing.Point(362, 217);
            this.Btn_SınavS.Name = "Btn_SınavS";
            this.Btn_SınavS.Size = new System.Drawing.Size(122, 45);
            this.Btn_SınavS.TabIndex = 1;
            this.Btn_SınavS.Text = "SınavSorumlusu";
            this.Btn_SınavS.UseVisualStyleBackColor = true;
            this.Btn_SınavS.Click += new System.EventHandler(this.Btn_SınavS_Click);
            // 
            // Btn_Admin
            // 
            this.Btn_Admin.Location = new System.Drawing.Point(644, 217);
            this.Btn_Admin.Name = "Btn_Admin";
            this.Btn_Admin.Size = new System.Drawing.Size(122, 45);
            this.Btn_Admin.TabIndex = 2;
            this.Btn_Admin.Text = "Admin";
            this.Btn_Admin.UseVisualStyleBackColor = true;
            this.Btn_Admin.Click += new System.EventHandler(this.Btn_Admin_Click);
            // 
            // Btn_Kayit
            // 
            this.Btn_Kayit.Location = new System.Drawing.Point(362, 304);
            this.Btn_Kayit.Name = "Btn_Kayit";
            this.Btn_Kayit.Size = new System.Drawing.Size(122, 45);
            this.Btn_Kayit.TabIndex = 3;
            this.Btn_Kayit.Text = "Kayıt";
            this.Btn_Kayit.UseVisualStyleBackColor = true;
            this.Btn_Kayit.Click += new System.EventHandler(this.Btn_Kayit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 444);
            this.Controls.Add(this.Btn_Kayit);
            this.Controls.Add(this.Btn_Admin);
            this.Controls.Add(this.Btn_SınavS);
            this.Controls.Add(this.Btn_Ogrenci);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Ogrenci;
        private System.Windows.Forms.Button Btn_SınavS;
        private System.Windows.Forms.Button Btn_Admin;
        private System.Windows.Forms.Button Btn_Kayit;
    }
}

