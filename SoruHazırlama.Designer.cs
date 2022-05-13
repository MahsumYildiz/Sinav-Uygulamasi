
namespace WindowsFormsApp72
{
    partial class SoruHazırlama
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
            this.Lbl_KonuAd = new System.Windows.Forms.Label();
            this.Lbl_UniteAd = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Lbl_KonuAd
            // 
            this.Lbl_KonuAd.AutoSize = true;
            this.Lbl_KonuAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_KonuAd.Location = new System.Drawing.Point(82, 138);
            this.Lbl_KonuAd.Name = "Lbl_KonuAd";
            this.Lbl_KonuAd.Size = new System.Drawing.Size(84, 24);
            this.Lbl_KonuAd.TabIndex = 1;
            this.Lbl_KonuAd.Text = "Konu Ad";
            // 
            // Lbl_UniteAd
            // 
            this.Lbl_UniteAd.AutoSize = true;
            this.Lbl_UniteAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_UniteAd.Location = new System.Drawing.Point(82, 70);
            this.Lbl_UniteAd.Name = "Lbl_UniteAd";
            this.Lbl_UniteAd.Size = new System.Drawing.Size(82, 24);
            this.Lbl_UniteAd.TabIndex = 2;
            this.Lbl_UniteAd.Text = "Unite Ad";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(228, 70);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(228, 138);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 4;
            // 
            // SoruHazırlama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Lbl_UniteAd);
            this.Controls.Add(this.Lbl_KonuAd);
            this.Name = "SoruHazırlama";
            this.Text = "SoruHazırlama";
            this.Load += new System.EventHandler(this.SoruHazırlama_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lbl_KonuAd;
        private System.Windows.Forms.Label Lbl_UniteAd;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}