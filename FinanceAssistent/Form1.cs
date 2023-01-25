using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FinanceAssistent
{
    public partial class Form1 : Form
    {
        DataBase dataBase = new DataBase();
        string connectionString = @"Data Source=DESKTOP-AVGELME\STP; Initial Catalog=DataBase; Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataBase.ConnectionString = connectionString;
            dataBase.Open();

            dataGridView1.DataSource = dataBase.GetData(Queries.SelectQueries.TipDohoda);

            
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (e.Node.Text)
            {
                case "Доход":
                    dataGridView1.DataSource = dataBase.GetData(Queries.SelectQueries.TipDohoda);
                    break;
                case "Тип дохода":
                    dataGridView1.DataSource = dataBase.GetData(Queries.SelectQueries.TipDohoda);
                    break;
                case "Расход":
                    dataGridView1.DataSource = dataBase.GetData(Queries.SelectQueries.TipDohoda);
                    break;
                case "Тип расхода":
                    dataGridView1.DataSource = dataBase.GetData(Queries.SelectQueries.TipRashoda);
                    break;
                case "Семья":
                    dataGridView1.DataSource = dataBase.GetData(Queries.SelectQueries.TipDohoda);
                    break;
            }

        }
    }
}
