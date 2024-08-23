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
    public partial class workerLogin : Form
    {
        public workerLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            workerTaskWiev workerTaskWiev = new workerTaskWiev();

            workerTaskWiev.tcNO = int.Parse(txtTcNo.Text);

            workerTaskWiev.Show();


            this.Hide();
        }
    }
}
