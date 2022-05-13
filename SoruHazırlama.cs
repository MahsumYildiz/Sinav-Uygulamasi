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
    public partial class SoruHazırlama : Form
    {
        public SoruHazırlama()
        {
            InitializeComponent();
        }
        DataTable dt;
        SqlDataAdapter da;
        SqlConnection baglanti = new SqlConnection("data source=DESKTOP-2EB8G19;initial catalog=YazilimYapimiProje; integrated security=true;");
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SoruHazırlama_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            dt = new DataTable();
            da = new SqlDataAdapter("select * from Tbl_Unite", baglanti);
            da.Fill(dt);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "UniteAd";
            comboBox1.ValueMember = "UniteId";
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                dt = new DataTable();
                da = new SqlDataAdapter("select * from Tbl_Konu where UniteId=" + (int)(comboBox1.SelectedValue), baglanti);
                da.Fill(dt);
                comboBox2.ValueMember = "KonuId";
                comboBox2.DisplayMember = "KonuAd";
                comboBox2.DataSource = dt;
            }
        }
    }
}
