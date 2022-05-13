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
    public partial class OgrenciGiris : Form
    {
        SqlConnection baglanti = new SqlConnection("data source=DESKTOP-2EB8G19;initial catalog=YazilimYapimiProje; integrated security=true;");
        public OgrenciGiris()
        {
            InitializeComponent();
        }

        private void Btn_Giris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Tbl_Ogrenci where OgrenciKadi='" + txtKadi.Text + "' AND OgrenciSifre='" + txtSifre.Text + "'",baglanti);
            SqlDataReader dr = sqlCommand.ExecuteReader();
            if (dr.Read())
                MessageBox.Show("Giris Basarılı");                
            else
                MessageBox.Show("Giris Hatali");           
            baglanti.Close();
            SınavSoruları sınavSoruları = new SınavSoruları();
            sınavSoruları.Show();
            this.Hide();

        }

        private void OgrenciGiris_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sifremiunuttum frm = new Sifremiunuttum();
            frm.Show();
            this.Hide();
        }
    }
}
