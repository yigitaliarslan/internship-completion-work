using MySql.Data.MySqlClient;


namespace taskApp
{
    public partial class adminLogin : Form
    {
        public adminLogin()
        {
            InitializeComponent();
        }


        private void btnAdminGiris_Click(object sender, EventArgs e)
        {
            dbConnection dbConnection = new dbConnection();

            MySqlConnection mySqlConnection = new MySqlConnection(dbConnection.mysqlCon);

            mySqlConnection.Open();

            MySqlCommand mySqlCommand = new MySqlCommand("select * from admin where ad='" + txtAdminName.Text + "'", mySqlConnection);
            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            if (reader.Read() == true)
            {
                if (txtAdminPass.Text == reader["sifre"].ToString())
                {
                    MessageBox.Show("Giri� Ba�ar�l�", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    adminMenu adminMenu = new adminMenu();

                    adminMenu.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Giri� Ba�ar�s�z", "System", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

        }
    }
}