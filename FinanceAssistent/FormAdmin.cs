using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanceAssistent
{
    public partial class FormAdmin : Form
    {
        DataBase dataBase;

        DataTable currentTable;
        SqlDataAdapter currentAdapter;
        
        DataBaseDataSetTableAdapters.TipRashodaTableAdapter TipRashodaTableAdapter = new DataBaseDataSetTableAdapters.TipRashodaTableAdapter();
        DataBaseDataSet.TipRashodaDataTable tipRashoda = new DataBaseDataSet.TipRashodaDataTable();

        DataBaseDataSetTableAdapters.SemyaTableAdapter SemyaTableAdapter = new DataBaseDataSetTableAdapters.SemyaTableAdapter();
        DataBaseDataSet.SemyaDataTable semya = new DataBaseDataSet.SemyaDataTable();

        public FormAdmin()
        {
            dataBase = new DataBase();
            InitializeComponent();
        }
        private void FormAdmin_Load(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            TipRashodaTableAdapter.Adapter.SelectCommand = new SqlCommand("select * from TipRashoda", dataBase.GetConnection());
            TipRashodaTableAdapter.Adapter.UpdateCommand = new SqlCommandBuilder(TipRashodaTableAdapter.Adapter).GetUpdateCommand();

            TipRashodaTableAdapter.Fill(tipRashoda);
            dataGridView1.DataSource = tipRashoda;
            
            currentAdapter = TipRashodaTableAdapter.Adapter;
            currentTable = tipRashoda;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SemyaTableAdapter.Adapter.SelectCommand = new SqlCommand("select Users.Name, Semya.Name from Semya, Users where Semya.id_user = Users.Id", dataBase.GetConnection());
            SemyaTableAdapter.Adapter.UpdateCommand = new SqlCommandBuilder(SemyaTableAdapter.Adapter).GetUpdateCommand();

            MessageBox.Show(SemyaTableAdapter.Adapter.UpdateCommand.CommandText);

            SemyaTableAdapter.Fill(semya);
            dataGridView1.DataSource = semya;
            
            currentAdapter = SemyaTableAdapter.Adapter;
            currentTable = semya;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            currentAdapter.Update(currentTable);
        }

        
    }
}
