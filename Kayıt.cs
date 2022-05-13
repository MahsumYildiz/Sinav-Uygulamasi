using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsFormsApp72
{
    public partial class Kayıt : Form
    {
        SqlConnection baglanti = new SqlConnection("data source=DESKTOP-2EB8G19;initial catalog=YazilimYapimiProje; integrated security=true;");
        public Kayıt()
        {
            InitializeComponent();
        }

        private void Kayıt_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sqlkayit = new SqlCommand("Insert into Tbl_Ogrenci(OgrenciAd,OgrenciSoyad,OgrenciMail,OgrenciSifre,OgrenciKadi) Values('"+Txt_Adi.Text.ToString()+ "','"+Txt_Soyadi.Text.ToString()+ "' ,'" + Txt_Mail.Text.ToString() + "','" + Txt_Sifre.Text.ToString() + "' ,'" + Txt_Kadi.Text.ToString() + "')" ,baglanti );
            sqlkayit.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci Kaydı Başarılı");

        }

        private void Txt_Kadi2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Sifre2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sqlkayit = new SqlCommand("Insert into Tbl_SınavS(SınavSAd,SınavSSoyad,SınavSMail,SınavSKadi,SınavSSifre) Values('" + Txt_Adi2.Text.ToString() + "','" + Txt_Soyadi2.Text.ToString() + "' ,'" + Txt_Mail2.Text.ToString() + "','" + Txt_Kadi2.Text.ToString() + "' ,'" + Txt_Sifre2.Text.ToString() + "')", baglanti);
            sqlkayit.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Sınav Sorumlusu Kaydı Başarılı");
        }
    }
}
