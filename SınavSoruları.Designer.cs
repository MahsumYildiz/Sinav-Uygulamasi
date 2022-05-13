
namespace WindowsFormsApp72
{
    partial class SınavSoruları
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
            this.Soru1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Lblsoru = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Soru1
            // 
            this.Soru1.AutoSize = true;
            this.Soru1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Soru1.Location = new System.Drawing.Point(67, 47);
            this.Soru1.Name = "Soru1";
            this.Soru1.Size = new System.Drawing.Size(48, 18);
            this.Soru1.TabIndex = 0;
            this.Soru1.Text = "Soru1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(310, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "Gönder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Lblsoru
            // 
            this.Lblsoru.AutoSize = true;
            this.Lblsoru.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Lblsoru.Location = new System.Drawing.Point(172, 47);
            this.Lblsoru.Name = "Lblsoru";
            this.Lblsoru.Size = new System.Drawing.Size(46, 18);
            this.Lblsoru.TabIndex = 3;
            this.Lblsoru.Text = "label1";
            this.Lblsoru.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(101, 339);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 43);
            this.button2.TabIndex = 4;
            this.button2.Text = "Başlat";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SınavSoruları
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Lblsoru);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Soru1);
            this.Name = "SınavSoruları";
            this.Text = "SınavSoruları";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Soru1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Lblsoru;
        private System.Windows.Forms.Button button2;
    }
}