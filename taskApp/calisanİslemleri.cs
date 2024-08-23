using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taskApp
{
    public partial class calisanİslemleri : Form
    {
        public calisanİslemleri()
        {
            InitializeComponent();
        }


        void verileriGoruntule()
        {
            dbConnection dbConnection = new dbConnection();

            MySqlConnection mySqlConnection = new MySqlConnection(dbConnection.mysqlCon);

            mySqlConnection.Open();

            DataTable dataTable = new DataTable();
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("select * from workers", mySqlConnection);
            mySqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            mySqlConnection.Close();
        }

        void temizle()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtTC.Clear();
            txtGorev.Clear();

        }


        private void calisanİslemleri_Load(object sender, EventArgs e)
        {
            dbConnection dbConnection = new dbConnection();

            MySqlConnection mySqlConnection = new MySqlConnection(dbConnection.mysqlCon);

            mySqlConnection.Open();

            DataTable dataTable = new DataTable();
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("select * from workers", mySqlConnection);
            mySqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            mySqlConnection.Close();
            temizle();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            dbConnection dbConnection = new dbConnection();

            MySqlConnection baglanti = new MySqlConnection(dbConnection.mysqlCon);


            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                string kayit = "insert into workers(ad,soyad,tc,gorev) values (@ad,@soyad,@tc,@gorev)";
                MySqlCommand komut = new MySqlCommand(kayit, baglanti);
                komut.Parameters.AddWithValue("@ad", txtAd.Text);
                komut.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                komut.Parameters.AddWithValue("@tc", txtTC.Text);
                komut.Parameters.AddWithValue("@gorev", txtGorev.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Çalışan Kayıt İşlemi Gerçekleşti.");
                verileriGoruntule();
                temizle();

            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
                temizle();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dbConnection dbConnection = new dbConnection();

            MySqlConnection baglanti = new MySqlConnection(dbConnection.mysqlCon);

            try
            {
                baglanti.Open();
                string kayit = "update workers set ad=@p1,tc=@p3,soyad=@p2,gorev=@p4 where id=@p5";
                MySqlCommand guncelle = new MySqlCommand(kayit, baglanti);
                guncelle.Parameters.AddWithValue("@p1", txtAd.Text);
                guncelle.Parameters.AddWithValue("@p2", txtSoyad.Text);
                guncelle.Parameters.AddWithValue("@p3", txtTC.Text);
                guncelle.Parameters.AddWithValue("@p4", txtGorev.Text);
                guncelle.Parameters.AddWithValue("@p5", txtİd.Text);
                guncelle.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Çalışan Kayıt İşlemi Gerçekleşti.");
                verileriGoruntule();
                temizle();

            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
                temizle();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dbConnection dbConnection = new dbConnection();

            MySqlConnection baglanti = new MySqlConnection(dbConnection.mysqlCon);

            try
            {
                string Query = "delete from workers where id='" + txtİd.Text + "';";
                MySqlCommand MyCommand2 = new MySqlCommand(Query, baglanti);
                MySqlDataReader MyReader2;
                baglanti.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                baglanti.Close();
                MessageBox.Show("Çalışan Verileri Silindi.");

                verileriGoruntule();
                temizle();
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
                temizle();
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtİd.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtTC.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtGorev.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            adminMenu adminMenu = new adminMenu();

            adminMenu.Show();
            this.Hide();
        }
    }
}
