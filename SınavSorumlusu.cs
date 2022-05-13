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
    public partial class SınavSorumlusu : Form
    {
        SqlConnection baglanti = new SqlConnection("data source=DESKTOP-2EB8G19;initial catalog=YazilimYapimiProje; integrated security=true;");

        public SınavSorumlusu()
        {
            InitializeComponent();
        }

        private void Btn_Giris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Tbl_SınavS where SınavSAd='" + txtKadi2.Text + "' AND SınavSSifre='" + txtSifre2.Text + "'", baglanti);
            SqlDataReader dr = sqlCommand.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Giris Basarılı");
                SoruHazırlama soruHazırlama = new SoruHazırlama();
                this.Hide();
                soruHazırlama.Show();
            }
               

            else
                MessageBox.Show("Giris Hatali");
            baglanti.Close();
        }
    }
}
