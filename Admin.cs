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
    public partial class Admin : Form
    {
        SqlConnection baglanti = new SqlConnection("data source=DESKTOP-2EB8G19;initial catalog=YazilimYapimiProje; integrated security=true;");

        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Giris3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Tbl_Admin where AdminKadi='" + txtKadi3.Text + "' AND AdminSifre='" + txtSifre3.Text + "'", baglanti);
            SqlDataReader dr = sqlCommand.ExecuteReader();
            if (dr.Read())
                MessageBox.Show("Giris Basarılı");
            else
                MessageBox.Show("Giris Hatali");
            baglanti.Close();
            
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
