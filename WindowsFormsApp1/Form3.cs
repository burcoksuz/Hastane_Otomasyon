using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //ADO.NET KÜTÜPHANELERİ

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        //veritabanına bağlanmayı sağlayan bağlantı cümlesi veritabanı bilgilerini içerir.
        SqlConnection conn = new SqlConnection("Server=215-13\\SQLEXPRESS;Database=Hastane;uid=sa;pwd=Ibb2022#!;");

        //windows autenhication
        //SqlConnection conn = new SqlConnection("Server=215-13\\{SQLEXPRESS;Database=CRM1;Integrated Security=true;");


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form2 form2= new Form2();
            form2.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void Listeleme()
        {
            SqlCommand komut = new SqlCommand();  //sql komutunu yazmamızı sağlayan komut.
            komut.Connection = conn;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "PListele";

            SqlDataAdapter dr = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            dr.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Listeleme();
        }

    }
}
