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
    public partial class adminMenu : Form
    {
        public adminMenu()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            adminLogin form1 = new adminLogin();

            form1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calisanGoruntule calisanGoruntule = new calisanGoruntule();

            calisanGoruntule.Show();
            this.Hide();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            calisanİslemleri calisanİslemleri = new calisanİslemleri();
            calisanİslemleri.Show();

            this.Hide();


        }
    }
}
