using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace taskApp
{
    public partial class workerTaskWiev : Form
    {
        public workerTaskWiev()
        {
            InitializeComponent();
        }

        public int tcNO;

        private void workerTaskWiev_Load(object sender, EventArgs e)
        {
            dbConnection dbConnection = new dbConnection();

            MySqlConnection mySqlConnection = new MySqlConnection(dbConnection.mysqlCon);

            mySqlConnection.Open();

            DataTable dataTable = new DataTable();
            string Query = "select * from workers where tc='" + tcNO + "';";


            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(Query, mySqlConnection);
            mySqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            mySqlConnection.Close();

            label1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            workerLogin workerLogin = new workerLogin();
            workerLogin.Show();
            this.Hide();
        }
    }
}
