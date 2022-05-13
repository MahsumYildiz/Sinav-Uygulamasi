
namespace WindowsFormsApp72
{
    partial class Admin
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Btn_Giris3 = new System.Windows.Forms.Button();
            this.txtSifre3 = new System.Windows.Forms.TextBox();
            this.txtKadi3 = new System.Windows.Forms.TextBox();
            this.Lbl_Sifre3 = new System.Windows.Forms.Label();
            this.Lbl_Kadi3 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Btn_Giris3);
            this.groupBox3.Controls.Add(this.txtSifre3);
            this.groupBox3.Controls.Add(this.txtKadi3);
            this.groupBox3.Controls.Add(this.Lbl_Sifre3);
            this.groupBox3.Controls.Add(this.Lbl_Kadi3);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(193, 34);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(331, 356);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Admin Girişi";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // Btn_Giris3
            // 
            this.Btn_Giris3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Giris3.Location = new System.Drawing.Point(101, 184);
            this.Btn_Giris3.Name = "Btn_Giris3";
            this.Btn_Giris3.Size = new System.Drawing.Size(143, 49);
            this.Btn_Giris3.TabIndex = 4;
            this.Btn_Giris3.Text = "Giriş";
            this.Btn_Giris3.UseVisualStyleBackColor = true;
            this.Btn_Giris3.Click += new System.EventHandler(this.Btn_Giris3_Click);
            // 
            // txtSifre3
            // 
            this.txtSifre3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtSifre3.Location = new System.Drawing.Point(144, 100);
            this.txtSifre3.Name = "txtSifre3";
            this.txtSifre3.Size = new System.Drawing.Size(100, 20);
            this.txtSifre3.TabIndex = 3;
            // 
            // txtKadi3
            // 
            this.txtKadi3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtKadi3.Location = new System.Drawing.Point(144, 46);
            this.txtKadi3.Name = "txtKadi3";
            this.txtKadi3.Size = new System.Drawing.Size(100, 20);
            this.txtKadi3.TabIndex = 2;
            // 
            // Lbl_Sifre3
            // 
            this.Lbl_Sifre3.AutoSize = true;
            this.Lbl_Sifre3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Lbl_Sifre3.Location = new System.Drawing.Point(72, 98);
            this.Lbl_Sifre3.Name = "Lbl_Sifre3";
            this.Lbl_Sifre3.Size = new System.Drawing.Size(42, 20);
            this.Lbl_Sifre3.TabIndex = 1;
            this.Lbl_Sifre3.Text = "Şifre";
            // 
            // Lbl_Kadi3
            // 
            this.Lbl_Kadi3.AutoSize = true;
            this.Lbl_Kadi3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Lbl_Kadi3.Location = new System.Drawing.Point(21, 47);
            this.Lbl_Kadi3.Name = "Lbl_Kadi3";
            this.Lbl_Kadi3.Size = new System.Drawing.Size(93, 20);
            this.Lbl_Kadi3.TabIndex = 0;
            this.Lbl_Kadi3.Text = "Kullanıcı Adı";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Btn_Giris3;
        private System.Windows.Forms.TextBox txtSifre3;
        private System.Windows.Forms.TextBox txtKadi3;
        private System.Windows.Forms.Label Lbl_Sifre3;
        private System.Windows.Forms.Label Lbl_Kadi3;
    }
}