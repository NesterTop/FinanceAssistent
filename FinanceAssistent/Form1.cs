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
            FormAuth formAuth = new FormAuth(this);
            formAuth.Show();
            dataBase.ConnectionString = connectionString;
            dataBase.Open();
            dataGridView1.DataSource = dataBase.SelectData(Queries.SelectQueries.TipDohoda);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

            switch (e.Node.Text)
            {
                case "Доход":
                    dataGridView1.DataSource = dataBase.SelectData(Queries.SelectQueries.Dohod);
                    break;
                case "Тип дохода":
                    dataGridView1.DataSource = dataBase.SelectData(Queries.SelectQueries.TipDohoda);
                    break;
                case "Расход":
                    dataGridView1.DataSource = dataBase.SelectData(Queries.SelectQueries.Rashod);
                    break;
                case "Тип расхода":
                    dataGridView1.DataSource = dataBase.SelectData(Queries.SelectQueries.TipRashoda);
                    break;
                case "Семья":
                    dataGridView1.DataSource = dataBase.SelectData(Queries.SelectQueries.Semya);
                    break;
            }

        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (treeView1.SelectedNode.Text)
            {
                case "Доход":
                    
                    break;
                case "Тип дохода":
                    
                    break;
                case "Расход":
                    
                    break;
                case "Тип расхода":
                    
                    break;
                case "Семья":
                    
                    break;
            }
        }

    }
}
