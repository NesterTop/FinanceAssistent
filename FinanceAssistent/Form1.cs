using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace FinanceAssistent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-AVGELME\STP; Initial Catalog=DataBase; Integrated Security=True";

            DataBaseContext dataBaseContext = new DataBaseContext(connectionString);

            dataBaseContext.Open();

            

            dataGridView1.DataSource = dataBaseContext.TipDohoda;
        }
    }
}
