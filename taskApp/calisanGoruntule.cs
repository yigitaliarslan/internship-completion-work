using MySql.Data.MySqlClient;
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
    public partial class calisanGoruntule : Form
    {
        public calisanGoruntule()
        {
            InitializeComponent();
        }

        private void calisanGoruntule_Load(object sender, EventArgs e)
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
    }
}
