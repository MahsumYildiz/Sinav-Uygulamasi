using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp72
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Ogrenci_Click(object sender, EventArgs e)
        {
            OgrenciGiris ogrenciGiris = new OgrenciGiris();
            
            ogrenciGiris.Show();
            this.Hide();

        }

        private void Btn_SınavS_Click(object sender, EventArgs e)
        {
            SınavSorumlusu sınavSorumlusu = new SınavSorumlusu();
            
            sınavSorumlusu.Show();
            this.Hide();
        }

        private void Btn_Admin_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            
            admin.Show();
            this.Hide();
        }

        private void Btn_Kayit_Click(object sender, EventArgs e)
        {
            Kayıt kayıt = new Kayıt();
            kayıt.Show();
            this.Hide();
        }

       
    }
}
